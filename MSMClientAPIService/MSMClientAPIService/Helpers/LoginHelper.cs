using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Xml;
using Microsoft.Extensions.Configuration;
using Tørketrommel;

namespace MSMClientAPIService.Helpers
{
    public class LoginHelper
    {
        private const string PART_NUMBER = "406000.003";
        private const string PRODUCT = "Multisite Monitor";
        private const string PRODUCT_VERSION = "2.9";
        private const string SERIAL_SETTING = "SerialNumber";
        private static Tørketrommel.Tørketrommel tørk;
        private static readonly Dictionary<string, UserSession> UserSessions = new Dictionary<string, UserSession>();
        private static readonly Dictionary<string, string> UserHostNameDict = new Dictionary<string, string>();

        private readonly IConfiguration config;

        public LoginHelper(IConfiguration config)
        {
            this.config = config;
        }

        public string GetSettingCfg(string setting)
        {
            string filename = "";
            var xmlDoc = new XmlDocument();
            try
            {
                filename = this.config["SettingsFilePathCfg"];
                xmlDoc.Load(filename);
                var rtn = xmlDoc.GetElementsByTagName(setting)[0].InnerText;
                return rtn;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public void RegisterTørkService()
        {
            var serialNumber = this.GetSettingCfg(SERIAL_SETTING);
            tørk = Tørketrommel.Tørketrommel.Instance(PRODUCT, serialNumber, PRODUCT_VERSION, PART_NUMBER);
            enumTørketrommel status = tørk.Status;

            Timer sessionTimer = new Timer(120000);
            sessionTimer.Elapsed += sessionTimer_Elapsed;
            sessionTimer.Start();
        }

        private void sessionTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            lock (UserSessions)
            {
                var expired = UserSessions.Where(x => (DateTime.Now - x.Value.LastAccess).Minutes > 2).ToDictionary(x => x.Key, y => y.Value);
                foreach (var item in expired)
                {
                    UserSessions.Remove(item.Key);
                }
            }
        }

        /// <summary>
        /// Gets the number of User is Active
        /// </summary>
        /// <value>
        /// Number of user is active
        /// </value>
        public static int ActiveUsers
        {
            get
            {
                return UserSessions.Keys.Count;
            }
        }

        /// <summary>
        /// Gets the tørketrommel.
        /// </summary>
        /// <value>
        /// The tørketrommel.
        /// </value>
        public static int NumberOfClients
        {
            get
            {
                return tørk.NumberOfClients;
            }
        }

        /// <summary>
        /// LicenseStatus ok?.
        /// </summary>
        /// <value>
        /// The license serial.
        /// </value>
        public static bool LicenseStatusOK
        {
            get
            {
                return (tørk.Status == enumTørketrommel.Ok);
            }
        }

        /// <summary>
        /// Gets host name of a user that logged in
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public static string GetUserHostName(string username)
        {
            if (UserHostNameDict.ContainsKey(username))
            {
                if (UserHostNameDict[username] == "::1")
                {
                    return Environment.MachineName;
                }

                return UserHostNameDict[username];
            }

            return string.Empty;
        }

        /// <summary>
        /// Determines whether [is user online] [the specified username].
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public static bool IsUserOnline(string username)
        {
            if (username != null)
            {
                username = username.ToLower();

                lock (UserSessions)
                {
                    return UserSessions.ContainsKey(username);
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether [is already loginned] [the specified username].
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="sessionId">The session identifier.</param>
        /// <returns></returns>
        public static bool IsAlreadyLoggedIn(string username, string sessionId)
        {
            if (username != null)
            {
                username = username.ToLower();

                lock (UserSessions)
                {
                    if (UserSessions.ContainsKey(username))
                    {
                        return sessionId != UserSessions[username].SessionId;
                    }
                }
            }

            return false;
        }
    }

    /// <summary>
    /// Keep user session and last access date time
    /// </summary>
    public class UserSession
    {
        /// <summary>
        /// Gets or sets the session identifier.
        /// </summary>
        /// <value>
        /// The session identifier.
        /// </value>
        public string SessionId { get; set; }

        /// <summary>
        /// Gets or sets the last access.
        /// </summary>
        /// <value>
        /// The last access.
        /// </value>
        public DateTime LastAccess { get; set; }
    }
}
