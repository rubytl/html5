namespace DataModel.DataPoints
{

    using System;
    using System.Collections.Generic;

    public class DeltaDataPoints : IDataPoint
    {
        #region properties
        
        public List<DataPointDef> Items { get; set; }

        #endregion properties

        
        public DeltaDataPoints()
        {
            
            if (Items == null)
                Items = new List<DataPointDef>();

            // System status
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SystemStatus, DataPath = "1002_1060_006e:Value", DataType = "vBool" });
            // Battery voltage - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryOutputVoltageValue, DataPath = "1090_1000_0001:Value", DataType = "vFloatp2" });
            // Battery voltage - description
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryOutputVoltageDescription, DataPath = "1090_1000_0001:Description", DataType = "vString16" });
            // Battery voltage - unit
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryOutputVoltageUnitText, DataPath = "1090_1000_0001:Unit", DataType = "vString16" });
            // Load current - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadCurrentValue, DataPath = "1090_1002_0001:Value", DataType = "vFloatp1" });
            // Load current - description
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadCurrentDescription, DataPath = "1090_1002_0001:Description", DataType = "vString16" });
            // Load current - unit
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadCurrentUnitText, DataPath = "1090_1002_0001:Unit", DataType = "vString16" });
            // Rectifier current - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.RectifierCurrentValue, DataPath = "1090_1004_0001:Value", DataType = "vFloatp1" });
            // Rectifier current - description
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.RectifierCurrentDescription, DataPath = "1090_1004_0001:Description", DataType = "vString16" });
            // Rectifier current - unit
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.RectifierCurrentUnitText, DataPath = "1090_1004_0001:Unit", DataType = "vString16" });
            // Battery temperature - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTemperatureValue, DataPath = "10d3_1060_0001:Value", DataType = "vFloatp1" });
            // Battery temperature - description
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTemperatureDescription, DataPath = "10d3_1060_0001:Description", DataType = "vString16" });
            // Battery temperature - unit text
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTemperatureUnitText, DataPath = "10d3_1060_0001:Unit", DataType = "vString16" });
            // Battery temperature - minor high
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTemperatureMinorHigh, DataPath = "10e6_2022_0001:Value", DataType = "vFloatp1_int" });
            // System lattitude
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LatDegree, DataPath = "1000_1243_0001:Value", DataType = "vFloatp7" });
            // System longitude
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LongDegree, DataPath = "1000_1244_0001:Value", DataType = "vFloatp7" });

            #region Energy logs
            // Solar hour energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarHourEnergyLog, DataPath = "ELTEK_MSM:SolarHourEnergy", DataType = "vU16int4" });
            // Solar hour energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarDayEnergyLog, DataPath = "ELTEK_MSM_DAILY:SolarDayEnergyLog", DataType = "vU16int4" });
            // Wind hour energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindHourEnergyLog, DataPath = "ELTEK_MSM:WindHourEnergy", DataType = "vU16int4" });
            // Wind day energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindDayEnergyLog, DataPath = "ELTEK_MSM_DAILY:WindDayEnergyLog", DataType = "vU16int4" });
            // Rectifier hour energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.RectifierHourEnergyLog, DataPath = "ELTEK_MSM:RectifierHourEnergy", DataType = "vU16int4" });
            // Rectifier day energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.RectifierDayEnergyLog, DataPath = "ELTEK_MSM_DAILY:RectifierDayEnergyLog", DataType = "vU16int4" });
            // AC Input hour energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInputHourEnergyLog, DataPath = "ELTEK_MSM:ACInputHourEnergyLog", DataType = "vU16int4" });
            // AC Input day energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInputDayEnergyLog, DataPath = "ELTEK_MSM_DAILY:ACInputDayEnergyLog", DataType = "vU16int4" });
            // Generator hour energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorHourEnergyLog, DataPath = "ELTEK_MSM:GeneratorHourEnergyLog", DataType = "vU16int4" });
            // Generator day energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorDayEnergyLog, DataPath = "ELTEK_MSM_DAILY:GeneratorDayEnergyLog", DataType = "vU16int4" });
            #endregion

            #region Run hour logs
            // Generator day run hour log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorDayTripLog, DataPath = "ELTEK_MSM_DAILY:GeneratorDayTripLog", DataType = "vU16int4" });
            // Battery day run hour log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryDayTripLog, DataPath = "ELTEK_MSM_DAILY:BatteryDayTripLog", DataType = "vU16int4" });
            // Mains day run hour log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACinputDayAvailabilityLog, DataPath = "ELTEK_MSM_DAILY:ACinputDayAvailabilityLog", DataType = "vU16int4" });
            #endregion

            #region Solar values
            // Solar current - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarCurrentValue, DataPath = "1090_100b_0001:Value", DataType = "vFloatp1" });
            // Solar current - description
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarCurrentDescription, DataPath = "1090_100b_0001:Description", DataType = "vString16" });
            // Solar current - unit
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarCurrentUnitText, DataPath = "1090_100b_0001:Unit", DataType = "vString16" });
            // Solar energy -  total
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarEnergyWattMeter, DataPath = "1090_1395_0001:Value", DataType = "vU16int5" });
            #endregion

            // Load energy - total
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadEnergyWattMeter, DataPath = "1090_1391_0001:Value", DataType = "vU16int5" });
            // Battery real cycles(discharge)
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTotalDischargeCycles, DataPath = "10eb_2040_0001:Value", DataType = "vU16int5" });
            // Rectifier energy - total
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.RectifierEnergyWattMeter, DataPath = "1090_1393_0001:Value", DataType = "vU16int5" });
            // Location name
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SiteName, DataPath = "1000_1240_0001:Value", DataType = "vString32" });
            // Controller hour
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ControllerHour, DataPath = "ELTEK_MSM:ControllerHour", DataType = "vU8int3" });
            // Controller minutes
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ControllerMinutes, DataPath = "ELTEK_MSM:ControllerMinutes", DataType = "vU8int3" });

            #region Wind values
            // Windcharger current - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindCurrentValue, DataPath = "1090_1007_0001:Value", DataType = "vFloatp1" });
            // Windcharger current - unit
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindCurrentUnitText, DataPath = "1090_1007_0001:Unit", DataType = "vString16" });
            // Windcharger current - description
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindCurrentDescription, DataPath = "1090_1007_0001:Description", DataType = "vString16" });
            #endregion

            // Battery discharge Ah - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryAhDischargedValue, DataPath = "10eb_2048_0001:Value", DataType = "vFloatp1" });
            // Load hour energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadHourEnergyLog, DataPath = "ELTEK_MSM:LoadHourEnergy", DataType = "vU16int4" });
            // Load day energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadDayEnergyLog, DataPath = "ELTEK_MSM_DAILY:LoadDayEnergyLog", DataType = "vU16int4" });
            //Battery time left value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTimeLeftValue, DataPath = "10e0_10aa_0001:Value", DataType = "vU16int5" });
            // Design life in years(Battery life time major high alarm level)
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryLifeTimeMajorHigh, DataPath = "10eb_2020_0001:Value", DataType = "vU16int5" });
            // Battery remining days notification(Battery life time minor high alarm level)
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryLifeTimeMinorHigh, DataPath = "10eb_2022_0001:Value", DataType = "vU16int5" });
            //Battery life time enable
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryLifeTimeEnable, DataPath = "10eb_01a1_0001:Value", DataType = "vBool" });
            //Battery time left minutes major low(Backup Time Limit (Expected Backup Time)
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTimeLeftMajorLow, DataPath = "10e0_1071_0000:Value", DataType = "vU16int5" });
            //Battery time left enable 
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTimeLeftEnable, DataPath = "10e0_1070_0000:Value", DataType = "vBool" });
            // Battery remaining days(Battery life time - value)
            //Items.Add(new DataPointDef { Id = 157, ProtocolId = ProtocolDef.batteryLifeTimeValue, DataPath = "10eb_2044_0001:Value", DataType = "vU16int5" });
            //Symmetry toplevel status
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatterySymmetryTopLevel, DataPath = "batterySymmetryTopLevel:Value", DataType = "vBool" });
            //Symmetry toplevel status
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryLifeTimeStatus, DataPath = "10eb_2050_0001:Value", DataType = "vBool" });
            //Symmetry toplevel status
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTimeLeftStatus, DataPath = "10e0_1080_0001:Value", DataType = "vBool" });
            //Battery run time meter - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTotalTripMeter, DataPath = "1120_2022_@BatteryRunTime:Value", DataType = "vU16int5" });
            // Mains monitor phase 1 hour energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase1HourEnergyLog, DataPath = "ELTEK_MSM:MainsMonPhase1HourEnergy", DataType = "vU16int4" });
            // Mains monitor phase 1 hour energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase1DayEnergyLog, DataPath = "ELTEK_MSM_DAILY:MainsMonPhase1DayEnergyLog", DataType = "vU16int4" });
            // Mains monitor phase 1 hour energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase2HourEnergyLog, DataPath = "ELTEK_MSM:MainsMonPhase2HourEnergy", DataType = "vU16int4" });
            // Mains monitor phase 1 hour energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase2DayEnergyLog, DataPath = "ELTEK_MSM_DAILY:MainsMonPhase2DayEnergyLog", DataType = "vU16int4" });
            // Mains monitor phase 1 hour energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase3HourEnergyLog, DataPath = "ELTEK_MSM:MainsMonPhase3HourEnergy", DataType = "vU16int4" });
            // Mains monitor phase 1 hour energy log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase3DayEnergyLog, DataPath = "ELTEK_MSM_DAILY:MainsMonPhase3DayEnergyLog", DataType = "vU16int4" });
            // Rectifier hour current log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.RectifierHourCurrentLog, DataPath = "ELTEK_MSM:RectifierHourCurrent", DataType = "vU16int4" });
            // Solar hour current log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarHourCurrentLog, DataPath = "ELTEK_MSM:SolarHourCurrent", DataType = "vU16int4" });
            // Wind hour current log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindHourCurrentLog, DataPath = "ELTEK_MSM:WindHourCurrent", DataType = "vU16int4" });
            // Load hour current log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadHourCurrentLog, DataPath = "ELTEK_MSM:LoadHourCurrent", DataType = "vU16int4" });

            // Number of User Interface Modules - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfUserInterfaceModules, DataPath = "2000:Value", DataType = "vU16int5" });
            // Number of Gateway Modbus Modules - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfGatewayModbusModules, DataPath = "3001:Value", DataType = "vU16int5" });
            // Number of Gateway Battery Modules - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfGatewayBatteryModules, DataPath = "3002:Value", DataType = "vU16int5" });
            // Number of Static Voltage Regulators - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfStaticVoltageRegulators, DataPath = "4000:Value", DataType = "vU16int5" });
            // Number of Healty Phase Selectors - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfHealtyPhaseSelectors, DataPath = "5000:Value", DataType = "vU16int5" });
            // Number of String Sensor Modules - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfStringSensorModules, DataPath = "6000:Value", DataType = "vU16int5" });
            // Number of Block Sensor Modules - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfBlockSensorModules, DataPath = "7000:Value", DataType = "vU16int5" });
            // Number of AirCon Modules - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfAirConModules, DataPath = "8001:Value", DataType = "vU16int5" });
            // Number of Fan Control Modules - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfFanControlModules, DataPath = "8002:Value", DataType = "vU16int5" });
            // Number of IO units - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfIOMonitors, DataPath = "9000:Value", DataType = "vU16int5" });
            // Number of rectifiers - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfRectifiers, DataPath = "A000:Value", DataType = "vU16int5" });
            // Number of DCDC Converters - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfDCDCConverters, DataPath = "B001:Value", DataType = "vU16int5" });
            // Number of AC modules - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfACMonitors, DataPath = "C000:Value", DataType = "vU16int5" });
            // Number of Solar Inverters - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfSolarInverters, DataPath = "D001:Value", DataType = "vU16int5" });
            // Number of Generators Modules - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfGeneratorsModules, DataPath = "F000:Value", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfBattery_Lead_Acid_Batteries, DataPath = "10b0:Value", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfBattery_Lithium_Batteries, DataPath = "10b1:Value", DataType = "vU16int5" });
            // Battery symmetry block measurement status
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatterySymmetryBlock, DataPath = "1002_1060_0041:Value", DataType = "vBool" });
            // Battery symmetry middle point measurement status
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatterySymmetryMiddlePoint, DataPath = "1002_1060_0038:Value", DataType = "vBool" });
            // Battery temperatur log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTemperatureLogHourly, DataPath = "ELTEK_MSM:BatteryHourTemperature", DataType = "vU16int4" });
            // Temperature type
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.TemperatureType, DataPath = "ELTEK_MSM:TemperatureType", DataType = "vU8int1" });
            // Battery average temperature
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTempAverageValue, DataPath = "batteryAverageValue:Value", DataType = "vS16int5" });
            // Battery life time - battery remaining life time
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryRemainingLifeTime, DataPath = "10eb_2044_0001:Value", DataType = "vU16int5" });
            // ACInput phase 1 voltage - value
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInput_Phase1_Voltage_Value, DataPath = "1090_1360_0001:Value", DataType = "vFloatp1_int" });
            // ACInput phase 1 voltage - description
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInput_Phase1_Voltage_Description, DataPath = "1090_1360_0001:Description", DataType = "vString16" });
            // ACInput phase 1 voltage - unit text
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInput_Phase1_Voltage_UnitText, DataPath = "1090_1360_0001:Unit", DataType = "vString16" });

        }

    }
}
