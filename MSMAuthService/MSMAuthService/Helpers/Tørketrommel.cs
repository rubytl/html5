// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Eltek AS" file="Tørketrommel.cs">
// //   (c) Copyright 2010-2014 Eltek AS
// // </copyright>
// // <summary>
// //   MultisiteMonitor.Web, Tørketrommel.cs
// //   $Revision: 18$
// //   $Author: haenno$
// //   $Date: 8. mars 2016 11:04:00$
// //   $Modtime: 8. mars 2016 10:44:09$
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace Tørketrommel
{
    #region Using directives

    using System;
    using System.Collections;
    using System.IO;
    using System.Management;
    using System.Net;
    using System.Net.NetworkInformation;
    using System.Reflection;
    using System.Security.Cryptography;
    using System.Text;
    using System.Timers;
    using System.Xml.Serialization;

    using EltekLicenseService;

    #endregion

    public enum enumTørketrommel  // WARNING: Do not expose these errordetails ever
    {
        NoServerOrFileFound,
        NoValidCryptoKeyFound,
        NotAbleToDecrypt,
        NotAbleToDeserialize,
        HWSerialMismatch,
        ServerNameMismatch,
        ServerDateBeforeLicenseStartDate,
        ExpiredDueToServerClock,
        ExpiredDueToInternalCounter,
        Unknown,
        Ok,
        NotValid,
        ProductVersionMismatch,
        ProductSerialMismatch
    }

    public class Tørketrommel
    {
        private const string KEY_FILE = "key.txt";
        private const string LICENSE_FILE = "license.txt";
        private const string CUSTOMER = "Eltek";

        private const int DAY = 720; // 12 hours

        private static Tørketrommel instance; // Singleton

        // Timer related
        private static Timer _checkLicenseTimer;
        private static enumState _state = enumState.NoServerOrLicenseFile;
        private static int SjekkTørketrommel;

        // product spesific variables
        private static string _productSerial;
        private static string _product;
        private static string _productVersion;
        private static string _productPartNumber;
        private static string _license;

        // added to avoid trying to connect to server when using licens file
        // To avoid slow startup when no server is available
        private static bool _forcedToUseLicenseFile;

        private static string _productBuild;

        private static string _hwSerial;
        private static string _activeAddress;
        private static string _allMacAddress;
        private static TørketrommelData msgDeserialized;
        private static enumTørketrommel _status;

        private Tørketrommel()
        {
            this.InitializeTørketrommel();
        }

        private Tørketrommel(string product, string productSerial, string productVersion, string productPartNumber, bool forceToLicenseFile)
        {
            _forcedToUseLicenseFile = forceToLicenseFile;
            _product = product;
            _productSerial = productSerial;
            _productVersion = productVersion;
            _productPartNumber = productPartNumber;
            _productBuild = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.InitializeTørketrommel();
        }

        public event EventHandler eventStatusChanged;

        private enum enumState
        {
            ServerOK,
            NoServerOrLicenseFile,
            LicenseFile
        }

        #region properties

        public enumTørketrommel Status
        {
            get
            {
                return _status;
            }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    if (this.eventStatusChanged != null)
                    {
                        this.eventStatusChanged(null, new EventArgs());
                    }
                }
            }
        }

        public string OSVersion
        {
            get
            {
                return Environment.OSVersion.VersionString;
            }
        }

        public string ServerName
        {
            get
            {
                return Environment.MachineName;
            }
        }

        public string HWSerial
        {
            get
            {
                return _hwSerial;
            }
        }

        public string MAC
        {
            get
            {
                return _activeAddress;
            }
        }

        public int NumberOfClients
        {
            get
            {
                if (msgDeserialized == null)
                {
                    return 0;
                }
                else
                {
                    return msgDeserialized.NumberOfClients;
                }
            }
        }

        public int NumberOfSites
        {
            get
            {
                return msgDeserialized == null ? 1 : msgDeserialized.NumberOfSites;
            }
        }

        public string Product
        {
            get
            {
                return _product;
            }
        }

        public string ProductVersion
        {
            get
            {
                return _productVersion;
            }
        }

        public string ProductPartNumber
        {
            get
            {
                return _productPartNumber;
            }
        }

        public string ProductSerial
        {
            get
            {
                return _productSerial;
            }
            set
            {
                if (_productSerial == value)
                {
                    return;
                }

                _productSerial = value;
                switch (_state)
                {
                    case enumState.ServerOK:
                        this.GetLicense();
                        break;
                    case enumState.LicenseFile:
                        this.CheckLicense();
                        break;
                }
            }
        }

        public string ProductBuild
        {
            get
            {
                return _productBuild;
            }
        }

        #endregion

        public static Tørketrommel Instance()
        {
            return instance ?? (instance = new Tørketrommel());
        }

        public static Tørketrommel Instance(string product, string productSerial, string productVersion, string productPartNumber)
        {
            return instance ?? (instance = new Tørketrommel(product, productSerial, productVersion, productPartNumber, false));
        }

        public static Tørketrommel Instance(string product, string productSerial, string productVersion, string productPartNumber, bool forceToUseLicenseFile)
        {
            return instance ?? (instance = new Tørketrommel(product, productSerial, productVersion, productPartNumber, forceToUseLicenseFile));
        }

        private static bool ConnectToLicenseServer(ref string license, string product, string productversion, string productbuild, string productSerial, string ipAddress, string macAddress, string allMacAddress, string hdSerial, string osVersion)
        {
            // send request to License server
            try
            {
                var eltService = new EltekLicenseServiceClient();
                // license = eltService.GetLicense(product, productversion, productbuild, CUSTOMER, productSerial, Environment.UserName, Environment.MachineName, ipAddress, macAddress, hdSerial, osVersion);
                license = eltService.GetLicenseVer2Async(product, productversion, productbuild, CUSTOMER, productSerial, Environment.UserName, Environment.MachineName, ipAddress, macAddress, allMacAddress, hdSerial, osVersion).Result;
                return true;
            }
            catch (Exception)
            {
                license = string.Empty;
                return false;
            }
        }

        private static TørketrommelData DeserializeObject(string xmlizedString)
        {
            try
            {
                var xs = new XmlSerializer(typeof(TørketrommelData));
                var memoryStream = new MemoryStream(StringToUTF8ByteArray(xmlizedString));
                return (TørketrommelData)xs.Deserialize(memoryStream);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static Byte[] StringToUTF8ByteArray(String xmlString)
        {
            var encoding = new UTF8Encoding();
            var byteArray = encoding.GetBytes(xmlString);
            return byteArray;
        }

        private static bool ReadFile(string fileName, ref string fileContent)
        {
            try
            {
                var filePath = fileName;
                var currentDir = Directory.GetCurrentDirectory();

                // Windows service
                if (currentDir.ToLower().Equals(@"c:\windows\system32"))
                {
                    var path = Assembly.GetExecutingAssembly().Location;
                    filePath = Path.GetDirectoryName(path) + @"\" + fileName;
                }

                if (File.Exists(filePath))
                {
                    var streamReader = new StreamReader(filePath, true);
                    fileContent = streamReader.ReadToEnd();
                    streamReader.Close();
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static string GetLocalIP()
        {
            var ipAddress = string.Empty;

            // get local IP addresses
            var localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            var ip = localIPs[0].ToString();
            if (!string.IsNullOrEmpty(ip))
            {
                ipAddress = ip;
            }

            return ipAddress;
        }

        private static string GetAllMacAddresses()
        {
            var macAddress = string.Empty;

            // get MAC address
            foreach (var nif in NetworkInterface.GetAllNetworkInterfaces())
            {
                var mac = nif.GetPhysicalAddress().ToString();
                if (!string.IsNullOrEmpty(mac))
                {
                    macAddress += mac + ";";
                }
            }

            return macAddress;
        }

        private static string GetMacAddress()
        {
            var macAddress = string.Empty;

            // get MAC address
            foreach (var nif in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nif.OperationalStatus == OperationalStatus.Up)
                {
                    var mac = nif.GetPhysicalAddress().ToString();
                    if (!string.IsNullOrEmpty(mac))
                    {
                        macAddress = mac;
                        return macAddress;
                    }
                }
            }

            return macAddress;
        }

        private static string GetMotherboardSerial()
        {
            var ret = "NoMotherBoardSerial";

            var scope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\cimv2");
            scope.Connect();

            var wmiClass = new ManagementObject(scope, new ManagementPath("Win32_BaseBoard.Tag=\"Base Board\""), new ObjectGetOptions());

            foreach (var propData in wmiClass.Properties)
            {
                // Console.WriteLine(String.Format("{0,-25}{1}", propData.Name, Convert.ToString(propData.Value)));
                if (propData.Name.Equals("SerialNumber"))
                {
                    ret = propData.Value.ToString();
                }
            }

            return ret;
        }

        private static string DecryptString(string inputString, int keySize, string xmlString)
        {
            // TODO: Add Proper Exception Handlers
            var rsaCryptoServiceProvider = new RSACryptoServiceProvider(keySize);
            rsaCryptoServiceProvider.FromXmlString(xmlString);
            var base64BlockSize = ((keySize / 8) % 3 != 0) ? (((keySize / 8) / 3) * 4) + 4 : ((keySize / 8) / 3) * 4;
            var iterations = inputString.Length / base64BlockSize;
            var arrayList = new ArrayList();
            for (var i = 0; i < iterations; i++)
            {
                var encryptedBytes = Convert.FromBase64String(inputString.Substring(base64BlockSize * i, base64BlockSize));

                // Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
                // If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
                // Comment out the next line and the corresponding one in the EncryptString function.
                Array.Reverse(encryptedBytes);
                arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(encryptedBytes, true));
            }

            return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
        }

        // TODO: Add timer and event that runs Task
        // Should be run once pr day and everytime the application starts
        private void GetLicense()
        {
            try
            {
                string ipAddress;
                _license = string.Empty;

                try
                {
                    _activeAddress = GetMacAddress();
                }
                catch (Exception)
                {
                    _activeAddress = "1234567890";
                }

                try
                {
                    _allMacAddress = GetAllMacAddresses();
                }
                catch (Exception)
                {
                    _allMacAddress = string.Empty;
                }

                try
                {
                    ipAddress = GetLocalIP();
                }
                catch (Exception)
                {
                    ipAddress = "255.255.255.255";
                }

                try
                {
                    _hwSerial = GetMotherboardSerial();
                    if (string.IsNullOrEmpty(_hwSerial))
                    {
                        _hwSerial = "None";
                    }
                }
                catch (Exception)
                {
                    _hwSerial = "None";
                }

                if (_forcedToUseLicenseFile || !ConnectToLicenseServer(ref _license, Product, ProductVersion, ProductBuild, ProductSerial, ipAddress, _activeAddress, _allMacAddress, _hwSerial, OSVersion))
                {
                    // If not connected to License server look for license file
                    if (!ReadFile(LICENSE_FILE, ref _license))
                    {
                        _state = enumState.NoServerOrLicenseFile;
                        Status = enumTørketrommel.NoServerOrFileFound;
                        return;
                    }
                    // license file found
                    _state = enumState.LicenseFile; // _isLicenseFile = true; // License is read from a file, not the license-server
                }
                else
                {
                    _state = enumState.ServerOK;
                }
                SjekkTørketrommel = 0;

                this.CheckLicense();
            }
            catch (Exception ex)
            {
                Status = enumTørketrommel.Unknown;
            }
        }

        private void CheckLicense()
        {
            if (_license == string.Empty)
            {
                return;
            }

            try
            {
                var key = "<RSAKeyValue><Modulus>qIOohXejsljvqIjj16CSHYi1AUCc4k3fjfYJiNjXN4R++eN8vcsjbkK+jeDqqHUFPoscNu4R3pWYz5j1f76LY63dsMZMmzKgolrvspg/SORHw5H4c3KEiFUBXUiDMQYCnik+rPEZCr5cLYyxqHkwTYAuU8lRaIcXXZsfnMpPYZk=</Modulus><Exponent>AQAB</Exponent><P>6RwneMv8cWSkvVZovR8fEhiA3lNaQNgicxpGWKoHpKXVzaXmsV7vUV1un0Pkdx1ntbrewpdLJK+JXgOIzjQBTQ==</P><Q>uQ+3x5RPExeJAIs6xAd88qhfJ2dtEx17UGn8Qq4ugf8RAB6+J4OivnglGKhEddmtZbimOu6DtkTd5FJZChY7fQ==</Q><DP>0iLFGkmYSYfWUa/BPyr80U0xbjlpVKcBdw0qeObdePjdYUK6UQ4pYgl9nSiQnSfuw42vHW9RF8L9a7h37JpIyQ==</DP><DQ>s7Oumw/KBVkKQUvxwZ8f1qZm1+WXxkMPlpOEUN/A65zaTkqMDeTGaLxUEXB8IhBBT5CRYpJvtdODwI2yRpg2JQ==</DQ><InverseQ>C8WPYn2IV0XM8avppwEnKrvMkuprNrI3Ef+IikSIsKV2FTwH5Q5VfY0nhMTpZx6t+tFXzvQJfWSZ3DhemheAKA==</InverseQ><D>ntaq7FNfO2bVT9joWoGB+NC5PJr4xd99T0SQrCsoga4kOcsR85wco3vKPdW5mlvjO5bIW4Z/1XzQ8y1MisLCgwJe9A32Nw0AU+MOM28j1R9E+AtivnB3aecFMzXzA1Gz9ncFScf44Dwxp6KFHrq/3MYlx3MVUJ6OvgHm9I3YB2E=</D></RSAKeyValue>";
                string decrypted;
                if (!ReadFile(KEY_FILE, ref key))
                {

                    // _status = enumTørketrommel.NoValidCryptoKeyFound;
                    // return; // try the default key
                }

                try
                {
                    decrypted = DecryptString(_license, 1024, key);
                }
                catch (Exception)
                {
                    Status = enumTørketrommel.NotAbleToDecrypt;
                    return;
                }

                try
                {
                    msgDeserialized = DeserializeObject(decrypted);
                    if (msgDeserialized == null)
                    {
                        _status = enumTørketrommel.NotAbleToDeserialize;
                        return;
                    }
                }
                catch (Exception)
                {
                    Status = enumTørketrommel.NotAbleToDeserialize;
                    return;
                }

                // Check HWSerial
                if (!_hwSerial.Replace(" ", "").Equals(msgDeserialized.HWSerial.Replace(" ", ""))) // reomve spaces because of bug in crypt/decrypt 
                {
                    Status = enumTørketrommel.HWSerialMismatch;
                    return;
                }

                // Check server name
                if (Environment.MachineName != msgDeserialized.Workstation)
                {
                    Status = enumTørketrommel.ServerNameMismatch;
                    return;
                }

                // Check valid
                if (!msgDeserialized.Valid)
                {
                    Status = enumTørketrommel.NotValid;
                    return;
                }

                // Check SW Revision
                if (!msgDeserialized.ProductVersion.Equals(_productVersion))
                {
                    Status = enumTørketrommel.ProductVersionMismatch;
                    return;
                }

                // Check StartDate against server clock

                // Check Start Date against internal counter/timer

                // Check ExpireDate
                if (_state == enumState.LicenseFile)
                {
                    // Check Product serial. Only neccesary when using license file ( when connected to license server this is already done in the server)
                    if (msgDeserialized.ProductSerial != null && !msgDeserialized.ProductSerial.Equals(_productSerial))
                    {
                        Status = enumTørketrommel.ProductSerialMismatch;
                        return;
                    }

                    if (msgDeserialized.Expires < DateTime.Now)
                    {
                        Status = enumTørketrommel.ExpiredDueToInternalCounter;
                        return;
                    }
                }

                Status = enumTørketrommel.Ok;
            }
            catch (Exception ex)
            {
                Status = enumTørketrommel.Unknown;
            }
        }

        private void InitializeTørketrommel()
        {
            this.GetLicense();
#if DEBUG
            // Create a timer with a five second interval.
            _checkLicenseTimer = new Timer(60000);
#else
    // Create a timer with a sixty second interval.
            _checkLicenseTimer = new System.Timers.Timer(60000);
#endif
            // Hook up the Elapsed event for the timer.
            _checkLicenseTimer.Elapsed += this.Timer_Elapsed;

            _checkLicenseTimer.Enabled = true;
            _checkLicenseTimer.AutoReset = true;

            SjekkTørketrommel = 0;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // #if DEBUG
            //            return;
            // #endif
            switch (_state)
            {

                case enumState.NoServerOrLicenseFile:  // Server connection error, check every minute
                    this.GetLicense();
                    break;

                case enumState.LicenseFile:
                case enumState.ServerOK: // Server connection OK, check every 12th hour
#if DEBUG
                    this.GetLicense(); // Check license every 60 sec in DEBUG mode
#else
                    // Check license every 12th hour in RELEASE mode
                    SjekkTørketrommel += 1;
                    if (SjekkTørketrommel >= DAY)
                    {
                        GetLicense();
                        SjekkTørketrommel = 0;
                    }
#endif
                    break;
            }

        }


    }
}
