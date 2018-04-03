//using MSMJsonService.Enumerations;
using System;
using System.Collections.Generic;

/*using System.Linq;
//using System.Web;
//using System.Data.Linq.Mapping;
using System.Configuration;*/


namespace DataModel.DataPoints
{

    public class DataPoints
    {
        private Dictionary<string, DataPoint> pathMap;
        public Dictionary<string, DataPoint> PathMap
        {
            get { return pathMap; }
        }

        private static DataPoints instance;
        public List<DataPoint> Items { get; set; }

        public static DataPoints Instance()
        {
            if (instance == null)
                instance = new DataPoints();

            return instance;
        }

        private DataPoints()
        {
            if (Items == null)
                Items = new List<DataPoint>();

            Items.Add(new DataPoint { Id = 1, SystemType = "SystemType_DcPlant", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "SystemId_status" });
            Items.Add(new DataPoint { Id = 2, SystemType = "SystemType_DcPlant", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "DcPlantId_systemMode" });
            Items.Add(new DataPoint { Id = 3, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_outputVoltage", Element = "MonitorId_value" });
            Items.Add(new DataPoint { Id = 4, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_outputVoltage", Element = "MonitorId_cfgDescription" });
            Items.Add(new DataPoint { Id = 5, SystemType = "SystemType_LoadDistribution", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_value" });
            Items.Add(new DataPoint { Id = 6, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_value" });
            Items.Add(new DataPoint { Id = 7, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_temp", Element = "MonitorId_value" });
            Items.Add(new DataPoint { Id = 8, SystemType = "SystemType_LoadDistribution", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_cfgDescription" });
            Items.Add(new DataPoint { Id = 9, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
            Items.Add(new DataPoint { Id = 10, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });

            Items.Add(new DataPoint { Id = 11, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 12, SystemType = "SystemType_SolarCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 13, SystemType = "SystemType_SolarCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
            Items.Add(new DataPoint { Id = 14, SystemType = "SystemType_SolarCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 15, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 16, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 17, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
            Items.Add(new DataPoint { Id = 18, SystemType = "SystemType_AC_input", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 19, SystemType = "SystemType_AC_input", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 20, SystemType = "SystemType_AC_input", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });

            Items.Add(new DataPoint { Id = 21, SystemType = "SystemType_SolarCharger", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_value" });
            Items.Add(new DataPoint { Id = 22, SystemType = "SystemType_SolarCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 23, SystemType = "SystemType_SolarCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 24, SystemType = "SystemType_SolarCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 25, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 26, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 27, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 28, SystemType = "SystemType_AC_input", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 29, SystemType = "SystemType_AC_input", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 30, SystemType = "SystemType_AC_input", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });

            Items.Add(new DataPoint { Id = 31, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 32, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 33, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });

            Items.Add(new DataPoint { Id = 34, SystemType = "SystemType_DcPlant", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "DcPlantId_cfgLatDegree" });
            Items.Add(new DataPoint { Id = 35, SystemType = "SystemType_DcPlant", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "DcPlantId_cfgLatDegreeDecimal" });
            Items.Add(new DataPoint { Id = 36, SystemType = "SystemType_DcPlant", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "DcPlantId_cfgLonDegree" });
            Items.Add(new DataPoint { Id = 37, SystemType = "SystemType_DcPlant", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "DcPlantId_cfgLonDegreeDecimal" });

            // Special for use internally
            Items.Add(new DataPoint { Id = 38, SystemType = "SystemType_Multisite", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "VitalData1" });

            Items.Add(new DataPoint { Id = 39, SystemType = "SystemType_LoadDistribution", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_unitText" });
            Items.Add(new DataPoint { Id = 40, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_outputVoltage", Element = "MonitorId_unitText" });

            Items.Add(new DataPoint { Id = 41, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_unitText" });
            Items.Add(new DataPoint { Id = 42, SystemType = "SystemType_SolarCharger", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_unitText" });
            Items.Add(new DataPoint { Id = 43, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_temp", Element = "MonitorId_cfgDescription" });
            Items.Add(new DataPoint { Id = 44, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_temp", Element = "MonitorId_unitText" });
            Items.Add(new DataPoint { Id = 45, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_cfgDescription" });
            Items.Add(new DataPoint { Id = 46, SystemType = "SystemType_SolarCharger", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_cfgDescription" });
            Items.Add(new DataPoint { Id = 47, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_outputVoltage", Element = "MonitorId_unit" });
            Items.Add(new DataPoint { Id = 48, SystemType = "SystemType_LoadDistribution", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_unit" });
            Items.Add(new DataPoint { Id = 49, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_unit" });
            Items.Add(new DataPoint { Id = 50, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_temp", Element = "MonitorId_unit" });

            Items.Add(new DataPoint { Id = 51, SystemType = "SystemType_SolarCharger", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_unit" });
            Items.Add(new DataPoint { Id = 52, SystemType = "SystemType_Generator", SystemIndex = "255", SubSystem = "1", SubSystemIndex = "255", DataObject = "Object_volume", Element = "MonitorId_value" });
            Items.Add(new DataPoint { Id = 53, SystemType = "SystemType_Generator", SystemIndex = "255", SubSystem = "1", SubSystemIndex = "255", DataObject = "Object_volume", Element = "MonitorId_cfgDescription" });
            Items.Add(new DataPoint { Id = 54, SystemType = "SystemType_Generator", SystemIndex = "255", SubSystem = "1", SubSystemIndex = "255", DataObject = "Object_volume", Element = "MonitorId_unitText" });
            Items.Add(new DataPoint { Id = 55, SystemType = "SystemType_Generator", SystemIndex = "255", SubSystem = "1", SubSystemIndex = "255", DataObject = "Object_volume", Element = "MonitorId_unit" });
            Items.Add(new DataPoint { Id = 56, SystemType = "SystemType_Generator", SystemIndex = "255", SubSystem = "2", SubSystemIndex = "255", DataObject = "Object_volume", Element = "MonitorId_value" });
            Items.Add(new DataPoint { Id = 57, SystemType = "SystemType_Generator", SystemIndex = "255", SubSystem = "2", SubSystemIndex = "255", DataObject = "Object_volume", Element = "MonitorId_cfgDescription" });
            Items.Add(new DataPoint { Id = 58, SystemType = "SystemType_Generator", SystemIndex = "255", SubSystem = "2", SubSystemIndex = "255", DataObject = "Object_volume", Element = "MonitorId_unitText" });
            Items.Add(new DataPoint { Id = 59, SystemType = "SystemType_Generator", SystemIndex = "255", SubSystem = "2", SubSystemIndex = "255", DataObject = "Object_volume", Element = "MonitorId_unit" });

            Items.Add(new DataPoint { Id = 60, SystemType = "SystemType_SolarCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_wattMeter" });
            Items.Add(new DataPoint { Id = 61, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_wattMeter" });
            Items.Add(new DataPoint { Id = 62, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_tripMeter" });
            Items.Add(new DataPoint { Id = 63, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "2", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_tripMeter" });
            Items.Add(new DataPoint { Id = 64, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_tripLog", Element = "TripLogId_tripMeter" });
            Items.Add(new DataPoint { Id = 65, SystemType = "SystemType_LoadDistribution", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_wattMeter" });
            Items.Add(new DataPoint { Id = 66, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_tripMeter" });
            Items.Add(new DataPoint { Id = 67, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_this", Element = "GeneratorID_generatorStarted" });
            Items.Add(new DataPoint { Id = 69, SystemType = "SystemType_AC_input", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_wattMeter" });
            Items.Add(new DataPoint { Id = 70, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 71, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 72, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_MonthMinMaxLog" });
            Items.Add(new DataPoint { Id = 73, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_DayTripLog" });
            Items.Add(new DataPoint { Id = 74, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_WeekTripLog" });
            Items.Add(new DataPoint { Id = 75, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_MonthTripLog" });
            Items.Add(new DataPoint { Id = 76, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "2", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 77, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "2", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 78, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "2", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_MonthMinMaxLog" });
            Items.Add(new DataPoint { Id = 79, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "2", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_DayTripLog" });
            Items.Add(new DataPoint { Id = 80, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "2", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_WeekTripLog" });
            Items.Add(new DataPoint { Id = 81, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "2", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_MonthTripLog" });
            Items.Add(new DataPoint { Id = 82, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_wattMeter" });
            //Items.Add(new DataPoint { Id = 83, SystemType = "SystemType_Multisite", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_KPIData", Element = "KPIData_SolarProducedTarget" });
            //Items.Add(new DataPoint { Id = 84, SystemType = "SystemType_Multisite", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_KPIData", Element = "KPIData_GeneratorProducedTarget" });

            Items.Add(new DataPoint { Id = 85, SystemType = "SystemType_DcPlant", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "DcPlantId_cfgLocationName" });
            Items.Add(new DataPoint { Id = 86, SystemType = "SystemType_DcPlant", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "SystemId_cfgDesiAmpere" });
            Items.Add(new DataPoint { Id = 87, SystemType = "SystemType_ControlSystem", SystemIndex = "1", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_clock", Element = "ClockId_TimeHour" });
            Items.Add(new DataPoint { Id = 88, SystemType = "SystemType_ControlSystem", SystemIndex = "1", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_clock", Element = "ClockId_TimeMinute" });
            Items.Add(new DataPoint { Id = 89, SystemType = "SystemType_Multisite", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "ClockId_TimeHour" });
            Items.Add(new DataPoint { Id = 90, SystemType = "SystemType_Multisite", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "ClockId_TimeMinute" });

            Items.Add(new DataPoint { Id = 91, SystemType = "SystemType_WindCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 92, SystemType = "SystemType_WindCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
            Items.Add(new DataPoint { Id = 93, SystemType = "SystemType_WindCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 94, SystemType = "SystemType_WindCharger", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_value" });
            Items.Add(new DataPoint { Id = 95, SystemType = "SystemType_WindCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 96, SystemType = "SystemType_WindCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 97, SystemType = "SystemType_WindCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 98, SystemType = "SystemType_WindCharger", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_unitText" });
            Items.Add(new DataPoint { Id = 99, SystemType = "SystemType_WindCharger", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_cfgDescription" });
            Items.Add(new DataPoint { Id = 100, SystemType = "SystemType_WindCharger", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_current", Element = "MonitorId_unit" });
            Items.Add(new DataPoint { Id = 101, SystemType = "SystemType_WindCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_wattMeter" });

            //Run hours
            Items.Add(new DataPoint { Id = 102, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_tripLog", Element = "TripLogId_DayTripLog" });
            Items.Add(new DataPoint { Id = 103, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_tripLog", Element = "TripLogId_WeekTripLog" });
            Items.Add(new DataPoint { Id = 104, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_tripLog", Element = "TripLogId_MonthTripLog" });
            //generator fuel level, max level, log
            Items.Add(new DataPoint { Id = 105, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_this", Element = "TankMonId_cfgTotVolume" });
            /*
            Items.Add(new DataPoint { Id = 106, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_DayTripLog" });
            Items.Add(new DataPoint { Id = 107, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_WeekTripLog" });
            Items.Add(new DataPoint { Id = 108, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_MonthTripLog" });
            //Generator energy log
            Items.Add(new DataPoint { Id = 109, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 110, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 111, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
             */
            //rectifier capacity
            Items.Add(new DataPoint { Id = 112, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "0", SubSystemIndex = "0", DataObject = "Object_quality", Element = "MonitorId_value" });
            Items.Add(new DataPoint { Id = 113, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_ahCharged", Element = "MonitorId_value" });
            Items.Add(new DataPoint { Id = 114, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_ahDischarged", Element = "MonitorId_value" });
            //Load energy
            Items.Add(new DataPoint { Id = 115, SystemType = "SystemType_LoadDistribution", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 116, SystemType = "SystemType_LoadDistribution", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 117, SystemType = "SystemType_LoadDistribution", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
            //Battery time left value
            Items.Add(new DataPoint { Id = 118, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_dischargeTimeLeft", Element = "MonitorId_value" });
            //MainsMonitor1 energy log
            Items.Add(new DataPoint { Id = 119, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 120, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 121, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
            //Numberof mains monitor
            Items.Add(new DataPoint { Id = 122, SystemType = "SystemType_ControlSystem", SystemIndex = "TOPLEVEL", SubSystem = "7", SubSystemIndex = "0", DataObject = "Object_this", Element = "SystemId_cfgMaxNoOfSubSystems" });
            //Battery average temperature & scale
            Items.Add(new DataPoint { Id = 123, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_temp", Element = "MonitorId_averageValue" });
            Items.Add(new DataPoint { Id = 124, SystemType = "SystemType_DcPlant", SystemIndex = "TOPLEVEL", SubSystem = "0", SubSystemIndex = "0", DataObject = "Object_this", Element = "SystemId_cfgTempType" });

            //MainsMonitor1 MinMax log
            Items.Add(new DataPoint { Id = 125, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 126, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 127, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });

            //Load energy MinMag Log
            Items.Add(new DataPoint { Id = 128, SystemType = "SystemType_LoadDistribution", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 129, SystemType = "SystemType_LoadDistribution", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 130, SystemType = "SystemType_LoadDistribution", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });

            Items.Add(new DataPoint { Id = 131, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_tripLog", Element = "TripLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 132, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_tripLog", Element = "TripLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 133, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_tripLog", Element = "TripLogId_MonthMinMaxLog" });

            // Special for use internally
            Items.Add(new DataPoint { Id = 134, SystemType = "SystemType_Multisite", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "ActiveAlarms" });
            //Items.Add(new DataPoint { Id = 135, SystemType = "SystemType_Multisite", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "AlarmStatusOnOff" }); // Historical alarm on/off events

            Items.Add(new DataPoint { Id = 136, SystemType = "SystemType_Multisite", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "InAlarmSinceStart" });
            Items.Add(new DataPoint { Id = 137, SystemType = "SystemType_Multisite", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "InWarningSinceStart" });
            Items.Add(new DataPoint { Id = 138, SystemType = "SystemType_Multisite", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "OfflineSinceStart" });
            Items.Add(new DataPoint { Id = 139, SystemType = "SystemType_Multisite", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "OkSinceStart" });

            //Items.Add(new DataPoint { Id = 140, SystemType = "SystemType_Multisite", SystemIndex = "TOPLEVEL", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "SiteStartDate" }); 

            //Mians outage log
            Items.Add(new DataPoint { Id = 141, SystemType = "SystemType_AC_input", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_DayTripLog" });
            Items.Add(new DataPoint { Id = 142, SystemType = "SystemType_AC_input", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_WeekTripLog" });
            Items.Add(new DataPoint { Id = 143, SystemType = "SystemType_AC_input", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_MonthTripLog" });
            //Mians outage MinMaxLog
            Items.Add(new DataPoint { Id = 144, SystemType = "SystemType_AC_input", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 145, SystemType = "SystemType_AC_input", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 146, SystemType = "SystemType_AC_input", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "TOPLEVEL", DataObject = "Object_tripLog", Element = "TripLogId_MonthMinMaxLog" });

            // new 2.3
            Items.Add(new DataPoint { Id = 147, SystemType = "SystemType_Generator", SystemIndex = "255", SubSystem = "1", SubSystemIndex = "255", DataObject = "Object_volume", Element = "MonitorId_cfgMinorLowLevel" });
            Items.Add(new DataPoint { Id = 148, SystemType = "SystemType_Generator", SystemIndex = "255", SubSystem = "1", SubSystemIndex = "255", DataObject = "Object_volume", Element = "MonitorId_cfgMajorLowLevel" });

            Items.Add(new DataPoint { Id = 149, SystemType = "SystemType_Battery", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_tempLevelHour", Element = "MonitorId_cfgMajorHighLevel" });
            Items.Add(new DataPoint { Id = 150, SystemType = "SystemType_Battery", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_tempLevelHour", Element = "MonitorId_cfgMinorHighLevel" });
            Items.Add(new DataPoint { Id = 151, SystemType = "SystemType_Battery", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_tempLevelHour", Element = "MonitorId_cfgEnable" });

            Items.Add(new DataPoint { Id = 152, SystemType = "SystemType_Battery", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_dischargeTimeLeft", Element = "MonitorId_cfgMajorLowLevel" });
            Items.Add(new DataPoint { Id = 153, SystemType = "SystemType_Battery", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_dischargeTimeLeft", Element = "MonitorId_cfgMinorLowLevel" });
            Items.Add(new DataPoint { Id = 154, SystemType = "SystemType_Battery", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_dischargeTimeLeft", Element = "MonitorId_cfgEnable" });

            Items.Add(new DataPoint { Id = 155, SystemType = "SystemType_Battery", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_temp", Element = "MonitorId_cfgMinorHighLevel" });
            Items.Add(new DataPoint { Id = 156, SystemType = "SystemType_Battery", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_temp", Element = "MonitorId_cfgEnable" });

            Items.Add(new DataPoint { Id = 157, SystemType = "SystemType_Battery", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_tempLevelHour", Element = "MonitorId_value" });
            //Symmetry toplevel status
            Items.Add(new DataPoint { Id = 158, SystemType = "SystemType_Battery", SystemIndex = "1", SubSystem = "14", SubSystemIndex = "255", DataObject = "Object_this", Element = "MonitorId_status" });

            Items.Add(new DataPoint { Id = 159, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_ahCharged", Element = "MonitorId_cfgEnable" });
            Items.Add(new DataPoint { Id = 160, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_ahDischarged", Element = "MonitorId_cfgEnable" });

            Items.Add(new DataPoint { Id = 161, SystemType = "SystemType_Battery", SystemIndex = "1", SubSystem = "14", SubSystemIndex = "255", DataObject = "Object_this", Element = "MonitorId_cfgEnable" });
            Items.Add(new DataPoint { Id = 162, SystemType = "SystemType_Battery", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_this", Element = "BatteryId_symmetryStatus" });
            Items.Add(new DataPoint { Id = 163, SystemType = "SystemType_Battery", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_tempLevelHour", Element = "MonitorId_status" });
            Items.Add(new DataPoint { Id = 164, SystemType = "SystemType_Battery", SystemIndex = "255", SubSystem = "255", SubSystemIndex = "255", DataObject = "Object_dischargeTimeLeft", Element = "MonitorId_status" });

            Items.Add(new DataPoint { Id = 165, SystemType = "SystemType_Generator", SystemIndex = "255", SubSystem = "1", SubSystemIndex = "255", DataObject = "Object_volume", Element = "MonitorId_status" });
            //Items.Add(new DataPoint { Id = 166, SystemType = "SystemType_Generator", SystemIndex = "255", SubSystem = "1", SubSystemIndex = "255", DataObject = "Object_volume", Element = "MonitorId_cfgMinorLowLevel" });
            Items.Add(new DataPoint { Id = 167, SystemType = "SystemType_Generator", SystemIndex = "255", SubSystem = "1", SubSystemIndex = "255", DataObject = "Object_volume", Element = "MonitorId_cfgMajorLowLevel" });

            //Battery run hour
            Items.Add(new DataPoint { Id = 168, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "2", DataObject = "Object_tripLog", Element = "TripLogId_DayTripLog" });
            Items.Add(new DataPoint { Id = 169, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "2", DataObject = "Object_tripLog", Element = "TripLogId_WeekTripLog" });
            Items.Add(new DataPoint { Id = 170, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "2", DataObject = "Object_tripLog", Element = "TripLogId_MonthTripLog" });
            Items.Add(new DataPoint { Id = 171, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "2", DataObject = "Object_tripLog", Element = "TripLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 172, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "2", DataObject = "Object_tripLog", Element = "TripLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 173, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "2", DataObject = "Object_tripLog", Element = "TripLogId_MonthMinMaxLog" });
            Items.Add(new DataPoint { Id = 174, SystemType = "SystemType_Battery", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "2", DataObject = "Object_tripLog", Element = "TripLogId_tripMeter" });

            // Added from 2.4.2
            Items.Add(new DataPoint { Id = 175, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "1", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 176, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "1", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 177, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "1", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });

            Items.Add(new DataPoint { Id = 178, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "1", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 179, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "1", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 180, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "1", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });

            Items.Add(new DataPoint { Id = 181, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "2", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 182, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "2", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 183, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "2", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });

            Items.Add(new DataPoint { Id = 184, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "2", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 185, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "2", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 186, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "2", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });

            Items.Add(new DataPoint { Id = 187, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "3", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 188, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "3", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 189, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "3", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });

            Items.Add(new DataPoint { Id = 190, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "3", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 191, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "3", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 192, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "3", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });

            // current logs for scaling of hourly energy logs
            Items.Add(new DataPoint { Id = 193, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourCurrentLog" });
            Items.Add(new DataPoint { Id = 194, SystemType = "SystemType_SolarCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourCurrentLog" });
            Items.Add(new DataPoint { Id = 195, SystemType = "SystemType_Generator", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourCurrentLog" });
            Items.Add(new DataPoint { Id = 196, SystemType = "SystemType_AC_input", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourCurrentLog" });
            Items.Add(new DataPoint { Id = 197, SystemType = "SystemType_WindCharger", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourCurrentLog" });
            Items.Add(new DataPoint { Id = 198, SystemType = "SystemType_LoadDistribution", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourCurrentLog" });
            Items.Add(new DataPoint { Id = 199, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "TOPLEVEL", DataObject = "Object_energyLog", Element = "EnergyLogId_HourCurrentLog" });
            Items.Add(new DataPoint { Id = 200, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "1", DataObject = "Object_energyLog", Element = "EnergyLogId_HourCurrentLog" });
            Items.Add(new DataPoint { Id = 201, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "2", DataObject = "Object_energyLog", Element = "EnergyLogId_HourCurrentLog" });
            Items.Add(new DataPoint { Id = 202, SystemType = "SystemType_AC_input", SystemIndex = "251", SubSystem = "1", SubSystemIndex = "3", DataObject = "Object_energyLog", Element = "EnergyLogId_HourCurrentLog" });

            // ECB and Aircon triplog ( hardcoded to I/O unit 1 output 1(ACU1) and 5(ECB) )
            Items.Add(new DataPoint { Id = 203, SystemType = "SystemType_ControlSystem", SystemIndex = "81", SubSystem = "ControlUnitPart_alarmHandler", SubSystemIndex = "1", DataObject = "Object_tripLog", Element = "TripLogId_DayTripLog" });
            Items.Add(new DataPoint { Id = 204, SystemType = "SystemType_ControlSystem", SystemIndex = "81", SubSystem = "ControlUnitPart_alarmHandler", SubSystemIndex = "1", DataObject = "Object_tripLog", Element = "TripLogId_WeekTripLog" });
            Items.Add(new DataPoint { Id = 205, SystemType = "SystemType_ControlSystem", SystemIndex = "81", SubSystem = "ControlUnitPart_alarmHandler", SubSystemIndex = "1", DataObject = "Object_tripLog", Element = "TripLogId_MonthTripLog" });
            Items.Add(new DataPoint { Id = 206, SystemType = "SystemType_ControlSystem", SystemIndex = "81", SubSystem = "ControlUnitPart_alarmHandler", SubSystemIndex = "1", DataObject = "Object_tripLog", Element = "TripLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 207, SystemType = "SystemType_ControlSystem", SystemIndex = "81", SubSystem = "ControlUnitPart_alarmHandler", SubSystemIndex = "1", DataObject = "Object_tripLog", Element = "TripLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 208, SystemType = "SystemType_ControlSystem", SystemIndex = "81", SubSystem = "ControlUnitPart_alarmHandler", SubSystemIndex = "1", DataObject = "Object_tripLog", Element = "TripLogId_MonthMinMaxLog" });

            // ECB triplog (I/O unit 1, output 5)
            Items.Add(new DataPoint { Id = 209, SystemType = "SystemType_ControlSystem", SystemIndex = "81", SubSystem = "ControlUnitPart_alarmHandler", SubSystemIndex = "5", DataObject = "Object_tripLog", Element = "TripLogId_DayTripLog" });
            Items.Add(new DataPoint { Id = 210, SystemType = "SystemType_ControlSystem", SystemIndex = "81", SubSystem = "ControlUnitPart_alarmHandler", SubSystemIndex = "5", DataObject = "Object_tripLog", Element = "TripLogId_WeekTripLog" });
            Items.Add(new DataPoint { Id = 211, SystemType = "SystemType_ControlSystem", SystemIndex = "81", SubSystem = "ControlUnitPart_alarmHandler", SubSystemIndex = "5", DataObject = "Object_tripLog", Element = "TripLogId_MonthTripLog" });
            Items.Add(new DataPoint { Id = 212, SystemType = "SystemType_ControlSystem", SystemIndex = "81", SubSystem = "ControlUnitPart_alarmHandler", SubSystemIndex = "5", DataObject = "Object_tripLog", Element = "TripLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 213, SystemType = "SystemType_ControlSystem", SystemIndex = "81", SubSystem = "ControlUnitPart_alarmHandler", SubSystemIndex = "5", DataObject = "Object_tripLog", Element = "TripLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 214, SystemType = "SystemType_ControlSystem", SystemIndex = "81", SubSystem = "ControlUnitPart_alarmHandler", SubSystemIndex = "5", DataObject = "Object_tripLog", Element = "TripLogId_MonthMinMaxLog" });

            // Number of sub systems(number of units/modules)
            Items.Add(new DataPoint { Id = 215, SystemType = "SystemType_ControlSystem", SystemIndex = "TOPLEVEL", SubSystem = "CONTROLUNIT", SubSystemIndex = "255", DataObject = "Object_this", Element = "SystemId_cfgMaxNoOfSubSystems" });
            Items.Add(new DataPoint { Id = 216, SystemType = "SystemType_ControlSystem", SystemIndex = "TOPLEVEL", SubSystem = "SMARTNODE", SubSystemIndex = "255", DataObject = "Object_this", Element = "SystemId_cfgMaxNoOfSubSystems" });
            Items.Add(new DataPoint { Id = 217, SystemType = "SystemType_ControlSystem", SystemIndex = "TOPLEVEL", SubSystem = "BATTERYMONITOR", SubSystemIndex = "255", DataObject = "Object_this", Element = "SystemId_cfgMaxNoOfSubSystems" });
            Items.Add(new DataPoint { Id = 218, SystemType = "SystemType_ControlSystem", SystemIndex = "TOPLEVEL", SubSystem = "LOADMONITOR", SubSystemIndex = "255", DataObject = "Object_this", Element = "SystemId_cfgMaxNoOfSubSystems" });
            Items.Add(new DataPoint { Id = 219, SystemType = "SystemType_ControlSystem", SystemIndex = "TOPLEVEL", SubSystem = "MULTIMONITOR", SubSystemIndex = "255", DataObject = "Object_this", Element = "SystemId_cfgMaxNoOfSubSystems" });
            Items.Add(new DataPoint { Id = 220, SystemType = "SystemType_ControlSystem", SystemIndex = "TOPLEVEL", SubSystem = "IOMON", SubSystemIndex = "255", DataObject = "Object_this", Element = "SystemId_cfgMaxNoOfSubSystems" });
            Items.Add(new DataPoint { Id = 221, SystemType = "SystemType_ControlSystem", SystemIndex = "TOPLEVEL", SubSystem = "ACMONITOR", SubSystemIndex = "255", DataObject = "Object_this", Element = "SystemId_cfgMaxNoOfSubSystems" });
            Items.Add(new DataPoint { Id = 222, SystemType = "SystemType_Rectifier", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_this", Element = "SystemId_cfgMaxNoOfSubSystems" });

            //Maing input voltage Phase 1
            Items.Add(new DataPoint { Id = 223, SystemType = "SystemType_AC_input", SystemIndex = "1", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_inputVoltage", Element = "MonitorId_value" });  //vS16int5
            Items.Add(new DataPoint { Id = 224, SystemType = "SystemType_AC_input", SystemIndex = "1", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_inputVoltage", Element = "MonitorId_status" });  //vU8int2
            Items.Add(new DataPoint { Id = 225, SystemType = "SystemType_AC_input", SystemIndex = "1", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_inputVoltage", Element = "MonitorId_unitText" });  //vString16
            Items.Add(new DataPoint { Id = 226, SystemType = "SystemType_AC_input", SystemIndex = "1", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_inputVoltage", Element = "MonitorId_cfgDescription" });  //vString16
            Items.Add(new DataPoint { Id = 231, SystemType = "SystemType_AC_input", SystemIndex = "1", SubSystem = "TOPLEVEL", SubSystemIndex = "TOPLEVEL", DataObject = "Object_inputVoltage", Element = "MonitorId_unit" });

            // Multi tenant load energy - hourly
            Items.Add(new DataPoint { Id = 254, SystemType = "SystemType_LoadMonitorLoadString1", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 255, SystemType = "SystemType_LoadMonitorLoadString2", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 256, SystemType = "SystemType_LoadMonitorLoadString3", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 257, SystemType = "SystemType_LoadMonitorLoadString4", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 258, SystemType = "SystemType_LoadMonitorLoadString5", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 259, SystemType = "SystemType_LoadMonitorLoadString6", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 260, SystemType = "SystemType_LoadMonitorLoadString7", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { Id = 261, SystemType = "SystemType_LoadMonitorLoadString8", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourEnergyLog" });

            // Multi tenant load MinMax - hourly
            Items.Add(new DataPoint { Id = 262, SystemType = "SystemType_LoadMonitorLoadString1MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 263, SystemType = "SystemType_LoadMonitorLoadString2MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 264, SystemType = "SystemType_LoadMonitorLoadString3MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 265, SystemType = "SystemType_LoadMonitorLoadString4MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 266, SystemType = "SystemType_LoadMonitorLoadString5MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 267, SystemType = "SystemType_LoadMonitorLoadString6MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 268, SystemType = "SystemType_LoadMonitorLoadString7MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });
            Items.Add(new DataPoint { Id = 269, SystemType = "SystemType_LoadMonitorLoadString8MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_HourMinMaxLog" });

            // Multi tenant load energy - daily
            Items.Add(new DataPoint { Id = 270, SystemType = "SystemType_LoadMonitorLoadString1", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 271, SystemType = "SystemType_LoadMonitorLoadString2", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 272, SystemType = "SystemType_LoadMonitorLoadString3", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 273, SystemType = "SystemType_LoadMonitorLoadString4", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 274, SystemType = "SystemType_LoadMonitorLoadString5", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 275, SystemType = "SystemType_LoadMonitorLoadString6", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 276, SystemType = "SystemType_LoadMonitorLoadString7", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { Id = 277, SystemType = "SystemType_LoadMonitorLoadString8", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayEnergyLog" });

            // Multi tenant load MinMax - daily
            Items.Add(new DataPoint { Id = 278, SystemType = "SystemType_LoadMonitorLoadString1MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 279, SystemType = "SystemType_LoadMonitorLoadString2MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 280, SystemType = "SystemType_LoadMonitorLoadString3MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 281, SystemType = "SystemType_LoadMonitorLoadString4MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 282, SystemType = "SystemType_LoadMonitorLoadString5MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 283, SystemType = "SystemType_LoadMonitorLoadString6MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 284, SystemType = "SystemType_LoadMonitorLoadString7MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });
            Items.Add(new DataPoint { Id = 285, SystemType = "SystemType_LoadMonitorLoadString8MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_DayMinMaxLog" });

            // Multi tenant load energy - weekly
            Items.Add(new DataPoint { Id = 286, SystemType = "SystemType_LoadMonitorLoadString1", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
            Items.Add(new DataPoint { Id = 287, SystemType = "SystemType_LoadMonitorLoadString2", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
            Items.Add(new DataPoint { Id = 288, SystemType = "SystemType_LoadMonitorLoadString3", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
            Items.Add(new DataPoint { Id = 289, SystemType = "SystemType_LoadMonitorLoadString4", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
            Items.Add(new DataPoint { Id = 290, SystemType = "SystemType_LoadMonitorLoadString5", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
            Items.Add(new DataPoint { Id = 291, SystemType = "SystemType_LoadMonitorLoadString6", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
            Items.Add(new DataPoint { Id = 292, SystemType = "SystemType_LoadMonitorLoadString7", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });
            Items.Add(new DataPoint { Id = 293, SystemType = "SystemType_LoadMonitorLoadString8", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekEnergyLog" });

            // Multi tenant load MinMax - weekly
            Items.Add(new DataPoint { Id = 294, SystemType = "SystemType_LoadMonitorLoadString1MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 295, SystemType = "SystemType_LoadMonitorLoadString2MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 296, SystemType = "SystemType_LoadMonitorLoadString3MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 297, SystemType = "SystemType_LoadMonitorLoadString4MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 298, SystemType = "SystemType_LoadMonitorLoadString5MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 299, SystemType = "SystemType_LoadMonitorLoadString6MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 300, SystemType = "SystemType_LoadMonitorLoadString7MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });
            Items.Add(new DataPoint { Id = 301, SystemType = "SystemType_LoadMonitorLoadString8MinMax", SystemIndex = "TOPLEVEL", SubSystem = "TOPLEVEL", SubSystemIndex = "0", DataObject = "Object_energyLog", Element = "EnergyLogId_WeekMinMaxLog" });

            pathMap = new Dictionary<string, DataPoint>();

            string key = string.Empty;

            for (int i = 0; i < Items.Count; i++)
            {
                key = string.Format("{0}.{1}.{2}.{3}.{4}.{5}", Items[i].SystemType, Items[i].SystemIndex, Items[i].SubSystem, Items[i].SubSystemIndex, Items[i].DataObject, Items[i].Element);
                pathMap[key] = Items[i];
            }
        }

        //public static List<DataPoint> GetId(List<DataPoint> dataPoints, string Element)
        /// <summary>
        /// Gets the id, based on a list of datapints and a specific Element ( E.g: Get the id's of description of a minitor when you have the value).
        /// </summary>
        /// <param name="dataPoints">The data points.</param>
        /// <param name="Element">The element.</param>
        /// <returns></returns>
        public static List<int> GetId(List<DataPoint> dataPoints, string Element)
        {
            //            List<DataPoint> newList = new List<DataPoint>();
            DateTime incomming = DateTime.Now;
            List<int> newList = new List<int>();

            foreach (var itemExt in dataPoints)
            {
                foreach (var itemInternal in DataPoints.instance.Items)
                {
                    if (itemExt.SystemType == itemInternal.SystemType &&
                        itemExt.SystemIndex == itemInternal.SystemIndex &&
                        itemExt.SubSystem == itemInternal.SubSystem &&
                        itemExt.SubSystemIndex == itemInternal.SubSystemIndex &&
                        itemExt.DataObject == itemInternal.DataObject &&
                        Element.Equals(itemInternal.Element))
                        newList.Add(itemInternal.Id);
                }
            }
            TimeSpan diff = DateTime.Now - incomming;
            //if (Log.IsErrorEnabled)
            //{
            //    Log.Error(string.Format(string.Format("GetID. Timediff: {0}:{1},{2}", diff.Minutes, diff.Seconds, diff.Milliseconds)));
            //}
            return newList;
        }

        //    public PeriodicLogType GetPeriodicLogType(int protocolID)
        //    {
        //        foreach(var item in DataPoints.Instance().Items)
        //        {
        //            if(item.Id == protocolID && !item.Element.Contains("MinMax"))
        //            {
        //                if(item.Element.Contains("Hour"))
        //                    return PeriodicLogType.Hourly;
        //                else if(item.Element.Contains("Day"))
        //                    return PeriodicLogType.Daily;
        //                else if(item.Element.Contains("Week"))
        //                    return PeriodicLogType.Weekly;
        //                else if(item.Element.Contains("Month"))
        //                    return PeriodicLogType.Monthly;
        //            }
        //        }
        //        return PeriodicLogType.None;
        //    }
    }

    //public enum PeriodicLogType
    //{
    //    None,
    //    Hourly,
    //    Daily,
    //    Weekly,
    //    Monthly
    //};

    //[Table(Name = "dbo.DataPaths")]
    public class DataPoint
    {
        public DataPoint()
        {
        }

        //[ReadOnly(true)]
        //[Key]
        //[Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        // [Column]
        public string SystemType { get; set; }

        //[Column]
        public string SystemIndex { get; set; }

        //[Column]
        public string SubSystem { get; set; }

        //[Column]
        public string SubSystemIndex { get; set; }

        //[Column]
        public string DataObject { get; set; }

        //[Column]
        public string Element { get; set; }
    }
}