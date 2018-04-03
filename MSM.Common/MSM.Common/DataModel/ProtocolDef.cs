namespace DataModel.DataPoints
{
    using System.ComponentModel;

    public enum ProtocolDef
    {
        /// <summary>
        /// The compack
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "NoDef", Justification = "nodef")]
        [Description("No definition")]
        NoDef,

        [Description("System Status")]
        SystemStatus = 1,

        [Description("System Mode")]
        SystemMode = 2,

        [Description("Battery Output Voltage")]
        BatteryOutputVoltageValue = 3,

        [Description("Battery Output Voltage Description")]
        BatteryOutputVoltageDescription = 4,

        [Description("Load Current")]
        LoadCurrentValue = 5,

        [Description("Rectifier Current")]
        RectifierCurrentValue = 6,

        [Description("Battery Temperature")]
        BatteryTemperatureValue = 7,

        [Description("Load Current Description")]
        LoadCurrentDescription = 8,

        [Description("Rectifier Weekly Energy Log")]
        RectifierWeekEnergyLog = 9,

        [Description("Rectifier Weekly Energy Log")]
        RectifierHourEnergyLog = 10,

        RectifierDayEnergyLog = 11,

        SolarDayEnergyLog = 12,

        SolarWeekEnergyLog = 13,

        SolarHourEnergyLog = 14,

        GeneratorHourEnergyLog = 15,

        GeneratorDayEnergyLog = 16,

        GeneratorWeekEnergyLog = 17,

        ACInputHourEnergyLog = 18,

        ACInputDayEnergyLog = 19,

        ACInputWeekEnergyLog = 20,
        
        SolarCurrentValue = 21,

        SolarHourEnergyMinMaxLog = 22,

        SolarDayEnergyMinMaxLog = 23,

        SolarWeekEnergyMinMaxLog = 24,
        GeneratorHourEnergyMinMaxLog = 25,
        GeneratorDayEnergyMinMaxLog = 26,
        GeneratorWeekEnergyMinMaxLog = 27,
        ACInputHourEnergyMinMaxLog = 28,
        ACInputDayEnergyMinMaxLog = 29,
        ACInputWeekEnergyMinMaxLog = 30,
        RectifierHourEnergyMinMaxLog = 31,
        RectifierDayEnergyMinMaxLog = 32,
        RectifierWeekEnergyMinMaxLog = 33,

        LatDegree = 34,
        LatDegreeDecimal = 35,
        LongDegree = 36,
        LongDegreeDecimal = 37,

        MultisiteMonitorVitalData = 38,
        LoadCurrentUnitText = 39,
        BatteryOutputVoltageUnitText = 40,
        RectifierCurrentUnitText = 41,
        SolarCurrentUnitText = 42,
        BatteryTemperatureDescription = 43,
        BatteryTemperatureUnitText = 44,
        RectifierCurrentDescription = 45,
        SolarCurrentDescription = 46,
        BatteryOutputVoltageUnit = 47,
        LoadCurrentUnit = 48,
        RectifierCurrentUnit = 49,
        BatteryTemperatureUnit = 50,
        SolarCurrentUnit = 51,
        GeneratorTank1VolumeValue = 52,
        GeneratorTank1VolumeDescription = 53,
        GeneratorTank1VolumeUnitText = 54,
        GeneratorTank1VolumeUnit = 55,
        GeneratorTank2VolumeValue = 56,
        GeneratorTank2VolumeDescription = 57,
        GeneratorTank2VolumeUnitText = 58,
        GeneratorTank2VolumeUnit = 59,

        SolarEnergyWattMeter = 60,
        GeneratorEnergyWattMeter = 61,
        GeneratorTank1TotalFuelConsumption = 62,
        GeneratorTank2TotalFuelConsumption = 63,
        GeneratorTotalTripMeter = 64,
        LoadEnergyWattMeter = 65,
        BatteryTotalDischargeCycles = 66,
        GeneratorStarted = 67,

        ACInputEnergyWattMeter = 69,
        GeneratorTank1DayFuelConsumptionMinMaxLog = 70,
        GeneratorTank1WeekFuelConsumptionMinMaxLog = 71,
        GeneratorTank1MonthFuelConsumptionMinMaxLog = 72,
        GeneratorTank1DayFuelConsumptionLog = 73,
        GeneratorTank1WeekFuelConsumptionLog = 74,
        GeneratorTank1MonthFuelConsumptionLog = 75,
        GeneratorTank2DayFuelConsumptionMinMaxLog = 76,
        GeneratorTank2WeekFuelConsumptionMinMaxLog = 77,
        GeneratorTank2MonthFuelConsumptionMinMaxLog = 78,
        GeneratorTank2DayFuelConsumptionLog = 79,
        GeneratorTank2WeekFuelConsumptionLog = 80,
        GeneratorTank2MonthFuelConsumptionLog = 81,
        RectifierEnergyWattMeter = 82,

        SiteName = 85,
        SystemDeciAmpSetting = 86,

        ControllerHour = 87,
        ControllerMinutes = 88,
        MultiSiteHour = 89,
        MultiSiteMinutes = 90,

        WindDayEnergyLog = 91,
        WindWeekEnergyLog = 92,
        WindHourEnergyLog = 93,
        WindCurrentValue = 94,
        WindHourEnergyMinMaxLog = 95,
        WindDayEnergyMinMaxLog = 96,
        WindWeekEnergyMinMaxLog = 97,
        WindCurrentUnitText = 98,
        WindCurrentDescription = 99,
        WindCurrentUnit = 100,
        WindEnergyWattMeter = 101,
        GeneratorDayTripLog = 102,
        GeneratorWeekTripLog = 103,
        GeneratorMonthTripLog = 104,
        GeneratorTank1TotalVolume = 105,

        RectifierCapacityValue = 112,
        BatteryAhChargedValue = 113,
        BatteryAhDischargedValue = 114,
        LoadHourEnergyLog = 115,
        LoadDayEnergyLog = 116,
        LoadWeekEnergyLog = 117,
        
        BatteryTimeLeftValue = 118,

        MainsMon1HourEnergyLog = 119,
        MainsMon1DayEnergyLog = 120,
        MainsMon1WeekEnergyLog = 121,
        NumberOfACMonitors = 122,
        
        BatteryTempAverageValue = 123,
        TemperatureType = 124,
        
        MainsMon1HourEnergyMinMaxLog = 125,
        MainsMon1DayEnergyMinMaxLog = 126,
        MainsMon1WeekEnergyMinMaxLog = 127,
        LoadHourEnergyMinMaxLog = 128,
        LoadDayEnergyMinMaxLog = 129,
        LoadWeekEnergyMinMaxLog = 130,
        GeneratorDayTripMinMaxLog = 131,
        GeneratorWeekTripMinMaxLog = 132,
        GeneratorMonthTripMinMaxLog = 133,

        MultiSiteActiveAlarms = 134,
        MultiSiteInAlarmSinceStart = 136,
        MultiSiteInWarningSinceStart = 137,
        MultiSiteOfflineSinceStart = 138,
        MultiSiteOKSinceStart = 139,
        
        ACinputDayOutageLog = 141,
        ACinputWeekOutageLog = 142,
        ACinputMonthOutageLog = 143,
        ACinputDayOutageMinMaxLog = 144,
        ACinputWeekOutageMinMaxLog = 145,
        ACinputMonthOutageMinMaxLog = 146,

        GeneratorTank1VolumeMinorLow = 147,
        GeneratorTank1VolumeMajorLow = 148,

        BatteryLifeTimeMajorHigh = 149,
        BatteryLifeTimeMinorHigh = 150,
        BatteryLifeTimeEnable = 151,
        BatteryTimeLeftMajorLow = 152,
        BatteryTimeLeftMinorLow = 153,
        BatteryTimeLeftEnable = 154,
        BatteryTemperatureMinorHigh = 155,
        BatteryTemperatureEnable = 156,
        BatteryLifeTimeValue = 157,
        BatteryBank1SymmetryStatus = 158,
        BatteryAhChargedEnable = 159,
        BatteryAhDischargedEnable = 160,
        BatteryBank1SymmetryEnable = 161,
        BatterySymmetryTopLevel = 162,
        BatteryLifeTimeStatus = 163,
        BatteryTimeLeftStatus = 164,

        GeneratorTank1VolumeStatus = 165,

        BatteryDayTripLog = 168,
        BatteryWeekTripLog = 169,
        BatteryMonthTripLog = 170,
        BatteryDayTripMinMaxLog = 171,
        BatteryWeekTripMinMaxLog = 172,
        BatteryMonthTripMinMaxLog = 173,
        BatteryTotalTripMeter = 174,

        MainsMonPhase1HourEnergyLog = 175,
        MainsMonPhase1DayEnergyLog = 176,
        MainsMonPhase1WeekEnergyLog = 177,
        MainsMonPhase1HourEnergyMinMaxLog = 178,
        MainsMonPhase1DayEnergyMinMaxLog = 179,
        MainsMonPhase1WeekEnergyMinMaxLog = 180,
        MainsMonPhase2HourEnergyLog = 181,
        MainsMonPhase2DayEnergyLog = 182,
        MainsMonPhase2WeekEnergyLog = 183,
        MainsMonPhase2HourEnergyMinMaxLog = 184,
        MainsMonPhase2DayEnergyMinMaxLog = 185,
        MainsMonPhase2WeekEnergyMinMaxLog = 186,
        MainsMonPhase3HourEnergyLog = 187,
        MainsMonPhase3DayEnergyLog = 188,
        MainsMonPhase3WeekEnergyLog = 189,
        MainsMonPhase3HourEnergyMinMaxLog = 190,
        MainsMonPhase3DayEnergyMinMaxLog = 191,
        MainsMonPhase3WeekEnergyMinMaxLog = 192,

        RectifierHourCurrentLog = 193,
        SolarHourCurrentLog = 194,
        GeneratorHourCurrentLog = 195,
        ACInputHourCurrentLog = 196,
        WindHourCurrentLog = 197,
        LoadHourCurrentLog = 198,
        MainsMonitorTotHourCurrentLog = 199,
        MainsMonitorPhase1HourCurrentLog = 200,
        MainsMonitorPhase2HourCurrentLog = 201,
        MainsMonitorPhase3HourCurrentLog = 202,

        AirConDayTripLog = 203,
        AirConWeekTripLog = 204,
        AirConMonthTripLog = 205,
        AirConDayTripMinMaxLog = 206,
        AirConWeekTripMinMaxLog = 207,
        AirConMonthTripMinMaxLog = 208,
        ECBDayTripLog = 209,
        ECBWeekTripLog = 210,
        ECBMonthTripLog = 211,
        ECBDayTripMinMaxLog = 212,
        ECBWeekTripMinMaxLog = 213,
        ECBMonthTripMinMaxLog = 214,


        NumberOfControlUnits = 215,
        NumberOfSmartNode = 216,
        NumberOfBatteryMonitors = 217,
        NumberOfLoadMonitors = 218,
        NumberOfMultiMonitors = 219,
        NumberOfIOMonitors = 220,
        // for number of ac monitors see NumberOfACMonitors = 122,
        NumberOfRectifiers = 222,

        ACInput_Phase1_Voltage_Value = 223,
        ACInput_Phase1_Voltage_Status = 224,
        ACInput_Phase1_Voltage_UnitText = 225,
        ACInput_Phase1_Voltage_Description = 226,

        BatterySymmetryBlock = 227,
        BatterySymmetryMiddlePoint = 228,

        BatteryTemperatureLogHourly = 229,
        BatteryRemainingLifeTime = 230,

        DriverType = 231,

        ACInput_Phase1_Voltage_Unit = 232,
         
        Load_Current_PeakValue = 233,
        Load_Current_AverageValue = 234,
        Load_Current_AverageCounter = 235,

        Battery_Capacity_Total_Value = 236,
        Battery_Capacity_Total_Status = 237,

        NumberOfSolarInverters = 238,
        NumberOfGeneratorsModules = 239,
        NumberOfDCDCConverters = 240,
        NumberOfFanControlModules = 241,
        NumberOfAirConModules = 242,
        NumberOfBlockSensorModules = 243,
        NumberOfStringSensorModules = 244,
        NumberOfHealtyPhaseSelectors = 245,
        NumberOfStaticVoltageRegulators = 246,
        NumberOfGatewayBatteryModules = 247,
        NumberOfGatewayModbusModules = 248,
        NumberOfUserInterfaceModules = 249,

        BatteryTemperatureLogDaily = 250,

        ACinputDayAvailabilityLog = 251, // inverted value of ACinputDayOutageLog = 141,
        ACinputWeekAvailabilityLog = 252, // inverted value of ACinputWeekOutageLog = 142
        ACinputMonthAvailabilityLog = 253,// inverted value of ACinputMonthOutageLog = 143

        // Multi tenant load energy
        LoadMon1LoadString1HourEnergyLog = 254,
        LoadMon1LoadString2HourEnergyLog = 255,
        LoadMon1LoadString3HourEnergyLog = 256,
        LoadMon1LoadString4HourEnergyLog = 257,
        LoadMon1LoadString5HourEnergyLog = 258,
        LoadMon1LoadString6HourEnergyLog = 259,
        LoadMon1LoadString7HourEnergyLog = 260,
        LoadMon1LoadString8HourEnergyLog = 261,
        
        LoadMon1LoadString1HourMinMaxEnergyLog = 262,
        LoadMon1LoadString2HourMinMaxEnergyLog = 263,
        LoadMon1LoadString3HourMinMaxEnergyLog = 264,
        LoadMon1LoadString4HourMinMaxEnergyLog = 265,
        LoadMon1LoadString5HourMinMaxEnergyLog = 266,
        LoadMon1LoadString6HourMinMaxEnergyLog = 267,
        LoadMon1LoadString7HourMinMaxEnergyLog = 268,
        LoadMon1LoadString8HourMinMaxEnergyLog = 269,

        LoadMon1LoadString1DayEnergyLog = 270,
        LoadMon1LoadString2DayEnergyLog = 271,
        LoadMon1LoadString3DayEnergyLog = 272,
        LoadMon1LoadString4DayEnergyLog = 273,
        LoadMon1LoadString5DayEnergyLog = 274,
        LoadMon1LoadString6DayEnergyLog = 275,
        LoadMon1LoadString7DayEnergyLog = 276,
        LoadMon1LoadString8DayEnergyLog = 277,

        LoadMon1LoadString1DayMinMaxEnergyLog = 278,
        LoadMon1LoadString2DayMinMaxEnergyLog = 279,
        LoadMon1LoadString3DayMinMaxEnergyLog = 280,
        LoadMon1LoadString4DayMinMaxEnergyLog = 281,
        LoadMon1LoadString5DayMinMaxEnergyLog = 282,
        LoadMon1LoadString6DayMinMaxEnergyLog = 283,
        LoadMon1LoadString7DayMinMaxEnergyLog = 284,
        LoadMon1LoadString8DayMinMaxEnergyLog = 285,
    
        LoadMon1LoadString1WeekEnergyLog = 286,
        LoadMon1LoadString2WeekEnergyLog = 287,
        LoadMon1LoadString3WeekEnergyLog = 288,
        LoadMon1LoadString4WeekEnergyLog = 289,
        LoadMon1LoadString5WeekEnergyLog = 290,
        LoadMon1LoadString6WeekEnergyLog = 291,
        LoadMon1LoadString7WeekEnergyLog = 292,
        LoadMon1LoadString8WeekEnergyLog = 293,

        LoadMon1LoadString1WeekMinMaxEnergyLog = 294,
        LoadMon1LoadString2WeekMinMaxEnergyLog = 295,
        LoadMon1LoadString3WeekMinMaxEnergyLog = 296,
        LoadMon1LoadString4WeekMinMaxEnergyLog = 297,
        LoadMon1LoadString5WeekMinMaxEnergyLog = 298,
        LoadMon1LoadString6WeekMinMaxEnergyLog = 299,
        LoadMon1LoadString7WeekMinMaxEnergyLog = 300,
        LoadMon1LoadString8WeekMinMaxEnergyLog = 301,

        Battery_Type = 302,
        Battery_Type_Text = 303,
        Battery_Install_Year = 304,
        Battery_Install_Month = 305,
        Battery_Install_Day = 306,
        NumberOfBattery_Strings = 307,
        Battery_String_Capacity = 308,
        NumberOfBattery_Lead_Acid_Batteries = 309,
        NumberOfBattery_Lithium_Batteries = 310,
        NumberOfRectiverterModules = 311
    }
}
