namespace DataModel.DataPoints
{

    using System;
    using System.Collections.Generic;

    public class EltekDataPoints : IDataPoint 
    {
        #region properties

        public List<DataPointDef> Items {get; set;}

        #endregion properties

        
        public EltekDataPoints()
        {
            
            if (Items == null)
                Items = new List<DataPointDef>();

            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SystemStatus, DataPath = "1.255.255.255.1:SystemId_status", DataType = "vU8int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SystemMode, DataPath = "1.255.255.255.1:DcPlantId_systemMode", DataType = "vU8int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryOutputVoltageValue, DataPath = "2.255.255.255.2:MonitorId_value", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryOutputVoltageDescription, DataPath = "2.255.255.255.2:MonitorId_cfgDescription", DataType = "vString16" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadCurrentValue, DataPath = "3.255.255.255.3:MonitorId_value", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.RectifierCurrentValue, DataPath = "5.255.255.255.3:MonitorId_value", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTemperatureValue, DataPath = "2.255.255.255.4:MonitorId_value", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadCurrentDescription, DataPath = "3.255.255.255.3:MonitorId_cfgDescription", DataType = "vString16" });

            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.RectifierWeekEnergyLog, DataPath = "5.255.255.0.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.RectifierHourEnergyLog, DataPath = "5.255.255.0.68:EnergyLogId_HourEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.RectifierDayEnergyLog, DataPath = "5.255.255.0.68:EnergyLogId_DayEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarDayEnergyLog, DataPath = "12.255.255.0.68:EnergyLogId_DayEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarWeekEnergyLog, DataPath = "12.255.255.0.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarHourEnergyLog, DataPath = "12.255.255.0.68:EnergyLogId_HourEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorHourEnergyLog, DataPath = "11.255.255.0.68:EnergyLogId_HourEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorDayEnergyLog, DataPath = "11.255.255.0.68:EnergyLogId_DayEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorWeekEnergyLog, DataPath = "11.255.255.0.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInputHourEnergyLog, DataPath = "4.255.255.0.68:EnergyLogId_HourEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInputDayEnergyLog, DataPath = "4.255.255.0.68:EnergyLogId_DayEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInputWeekEnergyLog, DataPath = "4.255.255.0.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int4" });

            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarCurrentValue, DataPath = "12.255.255.255.3:MonitorId_value", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarHourEnergyMinMaxLog, DataPath = "12.255.255.0.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarDayEnergyMinMaxLog, DataPath = "12.255.255.0.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarWeekEnergyMinMaxLog, DataPath = "12.255.255.0.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorHourEnergyMinMaxLog, DataPath = "11.255.255.0.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorDayEnergyMinMaxLog, DataPath = "11.255.255.0.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorWeekEnergyMinMaxLog, DataPath = "11.255.255.0.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInputHourEnergyMinMaxLog, DataPath = "4.255.255.0.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInputDayEnergyMinMaxLog, DataPath = "4.255.255.0.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInputWeekEnergyMinMaxLog, DataPath = "4.255.255.0.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });

            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.RectifierHourEnergyMinMaxLog, DataPath = "5.255.255.0.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.RectifierDayEnergyMinMaxLog, DataPath = "5.255.255.0.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.RectifierWeekEnergyMinMaxLog, DataPath = "5.255.255.0.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" } );
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LatDegree, DataPath = "1.255.255.255.1:DcPlantId_cfgLatDegree", DataType = "vS16int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LatDegreeDecimal, DataPath = "1.255.255.255.1:DcPlantId_cfgLatDegreeDecimal", DataType = "vU32int7" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LongDegree, DataPath = "1.255.255.255.1:DcPlantId_cfgLonDegree", DataType = "vS16int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LongDegreeDecimal, DataPath = "1.255.255.255.1:DcPlantId_cfgLonDegreeDecimal", DataType = "vU32int7" });
                                         
            // Special for use internally
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MultisiteMonitorVitalData, DataPath = "SystemType_Multisite.255.255.255.1:VitalData1", DataType = "vString16" });

            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.LoadCurrentUnitText, DataPath = "3.255.255.255.3:MonitorId_unitText", DataType = "vString16" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.BatteryOutputVoltageUnitText, DataPath = "2.255.255.255.2:MonitorId_unitText", DataType = "vString16" } );
                                          
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.RectifierCurrentUnitText, DataPath = "5.255.255.255.3:MonitorId_unitText", DataType = "vString16" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.SolarCurrentUnitText, DataPath = "12.255.255.255.3:MonitorId_unitText", DataType = "vString16" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.BatteryTemperatureDescription, DataPath = "2.255.255.255.4:MonitorId_cfgDescription", DataType = "vString16" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.BatteryTemperatureUnitText, DataPath = "2.255.255.255.4:MonitorId_unitText", DataType = "vString16" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.RectifierCurrentDescription, DataPath = "5.255.255.255.3:MonitorId_cfgDescription", DataType = "vString16" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.SolarCurrentDescription, DataPath = "12.255.255.255.3:MonitorId_cfgDescription", DataType = "vString16" } );
            Items.Add( new DataPointDef { ProtocolId = ProtocolDef.BatteryOutputVoltageUnit, DataPath = "2.255.255.255.2:MonitorId_unit", DataType = "vU8int1" });
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.LoadCurrentUnit, DataPath = "3.255.255.255.3:MonitorId_unit", DataType = "vU8int1" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.RectifierCurrentUnit, DataPath = "5.255.255.255.3:MonitorId_unit", DataType = "vU8int1" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.BatteryTemperatureUnit, DataPath = "2.255.255.255.4:MonitorId_unit", DataType = "vU8int1" } );
                                         
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.SolarCurrentUnit, DataPath = "12.255.255.255.3:MonitorId_unit", DataType = "vU8int1" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank1VolumeValue, DataPath = "11.255.1.255.81:MonitorId_value", DataType = "vU16int5" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank1VolumeDescription, DataPath = "11.255.1.255.81:MonitorId_cfgDescription", DataType = "vString16" });
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank1VolumeUnitText, DataPath = "11.255.1.255.81:MonitorId_unitText", DataType = "vString16" });
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank1VolumeUnit, DataPath = "11.255.1.255.81:MonitorId_unit", DataType = "vU8int1" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank2VolumeValue, DataPath = "11.255.2.255.81:MonitorId_value", DataType = "vU16int5" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank2VolumeDescription, DataPath = "11.255.2.255.81:MonitorId_cfgDescription", DataType = "vString16" });
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank2VolumeUnitText, DataPath = "11.255.2.255.81:MonitorId_unitText", DataType = "vString16" });
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank2VolumeUnit, DataPath = "11.255.2.255.81:MonitorId_unit", DataType = "vU8int1" } );
                                          
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.SolarEnergyWattMeter, DataPath = "12.255.255.0.68:EnergyLogId_wattMeter", DataType = "vS32int7" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorEnergyWattMeter, DataPath = "11.255.255.0.68:EnergyLogId_wattMeter", DataType = "vS32int7" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank1TotalFuelConsumption, DataPath = "11.255.1.255.79:TripLogId_tripMeter", DataType = "vS32int7" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank2TotalFuelConsumption, DataPath = "11.255.2.255.79:TripLogId_tripMeter", DataType = "vS32int7" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTotalTripMeter, DataPath = "11.255.255.0.79:TripLogId_tripMeter", DataType = "vS32int7" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.LoadEnergyWattMeter, DataPath = "3.255.255.0.68:EnergyLogId_wattMeter", DataType = "vS32int7" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.BatteryTotalDischargeCycles, DataPath = "2.255.255.255.79:TripLogId_tripMeter", DataType = "vS32int7" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorStarted, DataPath = "11.255.255.0.1:GeneratorID_generatorStarted", DataType = "vU8int1" });
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.ACInputEnergyWattMeter, DataPath = "4.255.255.0.68:EnergyLogId_wattMeter", DataType = "vS32int7" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank1DayFuelConsumptionMinMaxLog, DataPath = "11.255.1.255.79:TripLogId_DayMinMaxLog", DataType = "vU8int3" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank1WeekFuelConsumptionMinMaxLog, DataPath = "11.255.1.255.79:TripLogId_WeekMinMaxLog", DataType = "vU8int3" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank1MonthFuelConsumptionMinMaxLog, DataPath = "11.255.1.255.79:TripLogId_MonthMinMaxLog", DataType = "vU8int3" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank1DayFuelConsumptionLog, DataPath = "11.255.1.255.79:TripLogId_DayTripLog", DataType = "vU16int4" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank1WeekFuelConsumptionLog, DataPath = "11.255.1.255.79:TripLogId_WeekTripLog", DataType = "vU16int4" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank1MonthFuelConsumptionLog, DataPath = "11.255.1.255.79:TripLogId_MonthTripLog", DataType = "vU16int4" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank2DayFuelConsumptionMinMaxLog, DataPath = "11.255.2.255.79:TripLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank2WeekFuelConsumptionMinMaxLog, DataPath = "11.255.2.255.79:TripLogId_WeekMinMaxLog", DataType = "vU8int3" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank2MonthFuelConsumptionMinMaxLog, DataPath = "11.255.2.255.79:TripLogId_MonthMinMaxLog", DataType = "vU8int3" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank2DayFuelConsumptionLog, DataPath = "11.255.2.255.79:TripLogId_DayTripLog", DataType = "vU16int4" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank2WeekFuelConsumptionLog, DataPath = "11.255.2.255.79:TripLogId_WeekTripLog", DataType = "vU16int4" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank2MonthFuelConsumptionLog, DataPath = "11.255.2.255.79:TripLogId_MonthTripLog", DataType = "vU16int4" } );
            Items.Add( new DataPointDef{ ProtocolId = ProtocolDef.GeneratorTank2MonthFuelConsumptionLog, DataPath = "5.255.255.0.68:EnergyLogId_wattMeter", DataType = "vS32int7" } );
           //Items.Add(new DataPointDef{ ProtocolId = ProtocolDef., DataPath = "SystemType_Multisite.255.255.255.Object_KPIData.KPIData_SolarProducedTarget" });
           //Items.Add(new DataPointDef{ ProtocolId = ProtocolDef., DataPath = "SystemType_Multisite.255.255.255.Object_KPIData.KPIData_GeneratorProducedTarget" });
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SiteName, DataPath = "1.255.255.255.1:DcPlantId_cfgLocationName", DataType = "vString32" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SystemDeciAmpSetting, DataPath = "1.255.255.255.1:SystemId_cfgDesiAmpere", DataType = "vU8int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ControllerHour, DataPath = "6.1.255.0.11:ClockId_TimeHour", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ControllerMinutes, DataPath = "6.1.255.0.11:ClockId_TimeMinute", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MultiSiteHour, DataPath = "SystemType_Multisite.255.255.255.1:ClockId_TimeHour", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MultiSiteMinutes, DataPath = "SystemType_Multisite.255.255.255.1:ClockId_TimeMinute", DataType = "vU8int3" });
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindDayEnergyLog, DataPath = "13.255.255.0.68:EnergyLogId_DayEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindWeekEnergyLog, DataPath = "13.255.255.0.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindHourEnergyLog, DataPath = "13.255.255.0.68:EnergyLogId_HourEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindCurrentValue, DataPath = "13.255.255.255.3:MonitorId_value", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindHourEnergyMinMaxLog, DataPath = "13.255.255.0.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindDayEnergyMinMaxLog, DataPath = "13.255.255.0.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindWeekEnergyMinMaxLog, DataPath = "13.255.255.0.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindCurrentUnitText, DataPath = "13.255.255.255.3:MonitorId_unitText", DataType = "vString16" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindCurrentDescription, DataPath = "13.255.255.255.3:MonitorId_cfgDescription", DataType = "vString16" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindCurrentUnit,  DataPath = "13.255.255.255.3:MonitorId_unit", DataType = "vU8int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindEnergyWattMeter,  DataPath = "13.255.255.0.68:EnergyLogId_wattMeter", DataType = "vS32int7" });
                                          
            //Run hours                   
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorDayTripLog, DataPath = "11.255.255.0.79:TripLogId_DayTripLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorWeekTripLog, DataPath = "11.255.255.0.79:TripLogId_WeekTripLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorMonthTripLog, DataPath = "11.255.255.0.79:TripLogId_MonthTripLog", DataType = "vU16int4" });
            //generator fuel level, max level, log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorTank1TotalVolume, DataPath = "11.255.1.255.1:TankMonId_cfgTotVolume", DataType = "vU16int5" });
            /*
            Items.Add(new DataPoint { DataPath = "11.255.1.255.79:TripLogId_DayTripLog", DataType = "vU16int4" });
            Items.Add(new DataPoint { DataPath = "11.255.1.255.79:TripLogId_WeekTripLog", DataType = "vU16int4" });
            Items.Add(new DataPoint { DataPath = "11.255.1.255.79:TripLogId_MonthTripLog" });
            //Generator energy log
            Items.Add(new DataPoint { DataPath = "11.255.255.0.68:EnergyLogId_HourEnergyLog" });
            Items.Add(new DataPoint { DataPath = "11.255.255.0.68:EnergyLogId_DayEnergyLog" });
            Items.Add(new DataPoint { DataPath = "11.255.255.0.68:EnergyLogId_WeekEnergyLog" });
             */
            //rectifier capacity
            Items.Add(new DataPointDef {ProtocolId = ProtocolDef.RectifierCapacityValue, DataPath = "5.255.0.0.49:MonitorId_value", DataType = "vU16int5" });
            Items.Add(new DataPointDef {ProtocolId = ProtocolDef.BatteryAhChargedValue, DataPath = "2.255.255.255.92:MonitorId_value", DataType = "vU16int5" });
            Items.Add(new DataPointDef {ProtocolId = ProtocolDef.BatteryAhDischargedValue, DataPath = "2.255.255.255.93:MonitorId_value", DataType = "vU16int5" });
            //Load energy               
            Items.Add(new DataPointDef {ProtocolId = ProtocolDef.LoadHourEnergyLog, DataPath = "3.255.255.0.68:EnergyLogId_HourEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef {ProtocolId = ProtocolDef.LoadDayEnergyLog, DataPath = "3.255.255.0.68:EnergyLogId_DayEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef {ProtocolId = ProtocolDef.LoadWeekEnergyLog, DataPath = "3.255.255.0.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int4" });
            //Battery time left value    
            Items.Add(new DataPointDef {ProtocolId = ProtocolDef.BatteryTimeLeftValue, DataPath = "2.255.255.255.64:MonitorId_value", DataType = "vU16int5" });
            //MainsMonitor1 energy log  
            Items.Add(new DataPointDef {ProtocolId = ProtocolDef.MainsMon1HourEnergyLog, DataPath = "4.251.1.255.68:EnergyLogId_HourEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef {ProtocolId = ProtocolDef.MainsMon1DayEnergyLog, DataPath = "4.251.1.255.68:EnergyLogId_DayEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef {ProtocolId = ProtocolDef.MainsMon1WeekEnergyLog, DataPath = "4.251.1.255.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int4" });
            //Numberof mains monitor    
            Items.Add(new DataPointDef {ProtocolId = ProtocolDef.NumberOfACMonitors, DataPath = "6.255.7.255.1:SystemId_cfgMaxNoOfSubSystems", DataType = "vU8int2" });
            //Battery average temperature & scale   
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTempAverageValue, DataPath = "2.255.255.255.4:MonitorId_averageValue", DataType = "vS16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.TemperatureType, DataPath = "1.255.0.0.1:SystemId_cfgTempType", DataType = "vU8int1" });
                                          
            //MainsMonitor1 MinMax log    
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMon1HourEnergyMinMaxLog, DataPath = "4.251.1.255.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMon1DayEnergyMinMaxLog, DataPath = "4.251.1.255.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMon1WeekEnergyMinMaxLog, DataPath = "4.251.1.255.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
                                          
            //Load energy MinMag Log      
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadHourEnergyMinMaxLog, DataPath = "3.255.255.0.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadDayEnergyMinMaxLog, DataPath = "3.255.255.0.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadWeekEnergyMinMaxLog, DataPath = "3.255.255.0.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorDayTripMinMaxLog, DataPath = "11.255.255.0.79:TripLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorWeekTripMinMaxLog, DataPath = "11.255.255.0.79:TripLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorMonthTripMinMaxLog, DataPath = "11.255.255.0.79:TripLogId_MonthMinMaxLog", DataType = "vU8int3" });
                                         
            // Special for use internally
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MultiSiteActiveAlarms, DataPath = "SystemType_Multisite.255.255.255.1:ActiveAlarms", DataType = "vU8int3" });
            //Items.Add(new DataPoint { ProtocolId = ProtocolDef., DataPath = "SystemType_Multisite.255.255.255.1.AlarmStatusOnOff" }); // Historical alarm on/off events
                                                    
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MultiSiteInAlarmSinceStart, DataPath = "SystemType_Multisite.255.255.255.1:InAlarmSinceStart", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MultiSiteInWarningSinceStart, DataPath = "SystemType_Multisite.255.255.255.1:InWarningSinceStart", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MultiSiteOfflineSinceStart, DataPath = "SystemType_Multisite.255.255.255.1:OfflineSinceStart", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MultiSiteOKSinceStart, DataPath = "SystemType_Multisite.255.255.255.1:OkSinceStart", DataType = "vU8int3" });
            
            //Items.Add(new DataPoint { DataPath = "SystemType_Multisite.255.255.255.1.SiteStartDate" }); 

            //Mians outage log
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACinputDayOutageLog, DataPath = "4.255.255.255.79:TripLogId_DayTripLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACinputWeekOutageLog, DataPath = "4.255.255.255.79:TripLogId_WeekTripLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACinputMonthOutageLog, DataPath = "4.255.255.255.79:TripLogId_MonthTripLog", DataType = "vU16int4" });
            //Mians outage MinMaxLog     
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACinputDayOutageMinMaxLog, DataPath = "4.255.255.255.79:TripLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACinputWeekOutageMinMaxLog, DataPath = "4.255.255.255.79:TripLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACinputMonthOutageMinMaxLog, DataPath = "4.255.255.255.79:TripLogId_MonthMinMaxLog", DataType = "vU8int3" });
                                         
            // new 2.3                   
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorTank1VolumeMinorLow, DataPath = "11.255.1.255.81:MonitorId_cfgMinorLowLevel", DataType = "vS16int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorTank1VolumeMajorLow, DataPath = "11.255.1.255.81:MonitorId_cfgMajorLowLevel", DataType = "vS16int1" });
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryLifeTimeMajorHigh, DataPath = "2.255.255.255.52:MonitorId_cfgMajorHighLevel", DataType = "vS16int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryLifeTimeMinorHigh, DataPath = "2.255.255.255.52:MonitorId_cfgMinorHighLevel", DataType = "vS16int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryLifeTimeEnable, DataPath = "2.255.255.255.52:MonitorId_cfgEnable", DataType = "vU8int1" });
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTimeLeftMajorLow, DataPath = "2.255.255.255.64:MonitorId_cfgMajorLowLevel", DataType = "vS16int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTimeLeftMinorLow, DataPath = "2.255.255.255.64:MonitorId_cfgMinorLowLevel", DataType = "vS16int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTimeLeftEnable, DataPath = "2.255.255.255.64:MonitorId_cfgEnable", DataType = "vU8int1" });
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTemperatureMinorHigh, DataPath = "2.255.255.255.4:MonitorId_cfgMinorHighLevel", DataType = "vS16int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTemperatureEnable, DataPath = "2.255.255.255.4:MonitorId_cfgEnable", DataType = "vU8int1" });
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryLifeTimeValue, DataPath = "2.255.255.255.52:MonitorId_value", DataType = "vU16int5" });
            //Symmetry 255 status
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryBank1SymmetryStatus, DataPath = "2.1.14.255.1:MonitorId_status", DataType = "vU8int1" });
                                          
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryAhChargedEnable, DataPath = "2.255.255.255.92:MonitorId_cfgEnable", DataType = "vU8int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryAhDischargedEnable, DataPath = "2.255.255.255.93:MonitorId_cfgEnable", DataType = "vU8int1" });
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryBank1SymmetryEnable, DataPath = "2.1.14.255.1:MonitorId_cfgEnable", DataType = "vU8int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatterySymmetryTopLevel, DataPath = "2.255.255.255.1:BatteryId_symmetryStatus", DataType = "vU8int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryLifeTimeStatus, DataPath = "2.255.255.255.52:MonitorId_status", DataType = "vU8int1" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTimeLeftStatus, DataPath = "2.255.255.255.64:MonitorId_status", DataType = "vU8int1" });
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorTank1VolumeStatus, DataPath = "11.255.1.255.81:MonitorId_status", DataType = "vU8int1" });
            //Items.Add(new DataPoint { ProtocolId = ProtocolDef., DataPath = "11.255.1.255.81:MonitorId_cfgMinorLowLevel" });
            //Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorTank1VolumeMajorLow, DataPath = "11.255.1.255.81:MonitorId_cfgMajorLowLevel", DataType = "vS16int1" });
                                                   
            //Battery run hour                     
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryDayTripLog, DataPath = "2.255.255.2.79:TripLogId_DayTripLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryWeekTripLog, DataPath = "2.255.255.2.79:TripLogId_WeekTripLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryMonthTripLog, DataPath = "2.255.255.2.79:TripLogId_MonthTripLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryDayTripMinMaxLog, DataPath = "2.255.255.2.79:TripLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryWeekTripMinMaxLog, DataPath = "2.255.255.2.79:TripLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryMonthTripMinMaxLog, DataPath = "2.255.255.2.79:TripLogId_MonthMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.BatteryTotalTripMeter, DataPath = "2.255.255.2.79:TripLogId_tripMeter", DataType = "vS32int7" });
                                                   
            // Added from 2.4.2                    
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase1HourEnergyLog, DataPath = "4.251.1.1.68:EnergyLogId_HourEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase1DayEnergyLog, DataPath = "4.251.1.1.68:EnergyLogId_DayEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase1WeekEnergyLog, DataPath = "4.251.1.1.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int4" });
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase1HourEnergyMinMaxLog, DataPath = "4.251.1.1.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase1DayEnergyMinMaxLog, DataPath = "4.251.1.1.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase1WeekEnergyMinMaxLog, DataPath = "4.251.1.1.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase2HourEnergyLog, DataPath = "4.251.1.2.68:EnergyLogId_HourEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase2DayEnergyLog, DataPath = "4.251.1.2.68:EnergyLogId_DayEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase2WeekEnergyLog, DataPath = "4.251.1.2.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int4" });
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase2HourEnergyMinMaxLog, DataPath = "4.251.1.2.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase2DayEnergyMinMaxLog, DataPath = "4.251.1.2.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase2WeekEnergyMinMaxLog, DataPath = "4.251.1.2.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
                                         
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase3HourEnergyLog, DataPath = "4.251.1.3.68:EnergyLogId_HourEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase3DayEnergyLog, DataPath = "4.251.1.3.68:EnergyLogId_DayEnergyLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase3WeekEnergyLog, DataPath = "4.251.1.3.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int4" });
                                          
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase3HourEnergyMinMaxLog,  DataPath = "4.251.1.3.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase3DayEnergyMinMaxLog, DataPath = "4.251.1.3.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonPhase3WeekEnergyMinMaxLog, DataPath = "4.251.1.3.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
                                                  
            // current logs for scaling of hourly energy logs
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.RectifierHourCurrentLog, DataPath = "5.255.255.0.68:EnergyLogId_HourCurrentLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.SolarHourCurrentLog, DataPath = "12.255.255.0.68:EnergyLogId_HourCurrentLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.GeneratorHourCurrentLog, DataPath = "11.255.255.0.68:EnergyLogId_HourCurrentLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInputHourCurrentLog, DataPath = "4.255.255.0.68:EnergyLogId_HourCurrentLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.WindHourCurrentLog, DataPath = "13.255.255.0.68:EnergyLogId_HourCurrentLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadHourCurrentLog, DataPath = "3.255.255.0.68:EnergyLogId_HourCurrentLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonitorTotHourCurrentLog, DataPath = "4.251.1.255.68:EnergyLogId_HourCurrentLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonitorPhase1HourCurrentLog, DataPath = "4.251.1.1.68:EnergyLogId_HourCurrentLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonitorPhase2HourCurrentLog, DataPath = "4.251.1.2.68:EnergyLogId_HourCurrentLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.MainsMonitorPhase3HourCurrentLog, DataPath = "4.251.1.3.68:EnergyLogId_HourCurrentLog", DataType = "vU16int4" });
                                                   
            // ECB and Aircon triplog ( hardcoded to I/O unit 1 output 1(ACU1) and 5(ECB) )
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.AirConDayTripLog, DataPath = "6.81.14.1.79:TripLogId_DayTripLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.AirConWeekTripLog, DataPath = "6.81.14.1.79:TripLogId_WeekTripLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.AirConMonthTripLog, DataPath = "6.81.14.1.79:TripLogId_MonthTripLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.AirConDayTripMinMaxLog, DataPath = "6.81.14.1.79:TripLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.AirConWeekTripMinMaxLog, DataPath = "6.81.14.1.79:TripLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.AirConMonthTripMinMaxLog, DataPath = "6.81.14.1.79:TripLogId_MonthMinMaxLog", DataType = "vU8int3" });
                                                    
            // ECB triplog (I/O unit 1, output 5)   
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ECBDayTripLog, DataPath = "6.81.14.5.79:TripLogId_DayTripLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ECBWeekTripLog, DataPath = "6.81.14.5.79:TripLogId_WeekTripLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ECBMonthTripLog, DataPath = "6.81.14.5.79:TripLogId_MonthTripLog", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ECBDayTripMinMaxLog, DataPath = "6.81.14.5.79:TripLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ECBWeekTripMinMaxLog, DataPath = "6.81.14.5.79:TripLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ECBMonthTripMinMaxLog, DataPath = "6.81.14.5.79:TripLogId_MonthMinMaxLog", DataType = "vU8int3" });
                                                    
            // Number of sub systems(number of unit s/modules)
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfControlUnits, DataPath = "6.255.1.255.1:SystemId_cfgMaxNoOfSubSystems", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfSmartNode, DataPath = "6.255.2.255.1:SystemId_cfgMaxNoOfSubSystems", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfBatteryMonitors, DataPath = "6.255.3.255.1:SystemId_cfgMaxNoOfSubSystems", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfLoadMonitors, DataPath = "6.255.4.255.1:SystemId_cfgMaxNoOfSubSystems", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfMultiMonitors, DataPath = "6.255.5.255.1:SystemId_cfgMaxNoOfSubSystems", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfIOMonitors, DataPath = "6.255.6.255.1:SystemId_cfgMaxNoOfSubSystems", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfACMonitors, DataPath = "6.255.7.255.1:SystemId_cfgMaxNoOfSubSystems", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfRectifiers, DataPath = "5.255.255.255.1:SystemId_cfgMaxNoOfSubSystems", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfSolarInverters, DataPath = "12.255.255.255.1:SystemId_cfgMaxNoOfSubSystems", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfRectiverterModules, DataPath = "21.255.255.255.1:SystemId_cfgMaxNoOfSubSystems", DataType = "vU8int2" });
            
            //Mains input voltage Phase 1
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInput_Phase1_Voltage_Value, DataPath = "4.1.255.255.57:MonitorId_value", DataType = "vS16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInput_Phase1_Voltage_Status, DataPath = "4.1.255.255.57:MonitorId_status", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInput_Phase1_Voltage_UnitText, DataPath = "4.1.255.255.57:MonitorId_unitText", DataType = "vString16" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInput_Phase1_Voltage_Description, DataPath = "4.1.255.255.57:MonitorId_cfgDescription", DataType = "vString16" });

            //smartpack driver, check 
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.DriverType, DataPath = "8.0.0.0.1:0", DataType = "vU8int2" });
            
            //Mains input voltage Phase 1
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.ACInput_Phase1_Voltage_Unit, DataPath = "4.1.255.255.57:MonitorId_unit", DataType = "vU8int1" });

            //load current peak/average
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.Load_Current_AverageValue, DataPath = "3.255.0.0.3:21", DataType = "vS16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.Load_Current_PeakValue, DataPath = "3.255.0.0.3:20", DataType = "vS16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.Load_Current_AverageCounter, DataPath = "3.255.0.0.3:29", DataType = "vU16int5" });

            //battery total capacity
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.Battery_Capacity_Total_Value, DataPath = "2.255.255.255.9:MonitorId_value", DataType = "vS16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.Battery_Capacity_Total_Status, DataPath = "2.255.255.255.9:MonitorId_status", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.Battery_Type, DataPath = "2.255.255.255.1:BatteryId_cfgBatteryType", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.Battery_Type_Text, DataPath = "2.255.255.255.1:BattTypeId_cfgBatteryTypeText", DataType = "vString32" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.Battery_Install_Year, DataPath = "2.255.255.255.1:BatteryId_cfgBattInstallDateYear", DataType = "vU16int4" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.Battery_Install_Month, DataPath = "2.255.255.255.1:BatteryId_cfgBattInstallDateMonth", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.Battery_Install_Day, DataPath = "2.255.255.255.1:BatteryId_cfgBattInstallDateDay", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.NumberOfBattery_Strings, DataPath = "2.1.255.255.1:SystemId_cfgMaxNoOfSubSystems", DataType = "vU8int2" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.Battery_String_Capacity, DataPath = "2.255.255.255.1:27", DataType = "vU16int5" });

            // Multi tenant load energy - hourly
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString1HourEnergyLog, DataPath = "3.252.1.1.68:EnergyLogId_HourEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString2HourEnergyLog, DataPath = "3.252.1.2.68:EnergyLogId_HourEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString3HourEnergyLog, DataPath = "3.252.1.3.68:EnergyLogId_HourEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString4HourEnergyLog, DataPath = "3.252.1.4.68:EnergyLogId_HourEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString5HourEnergyLog, DataPath = "3.252.1.5.68:EnergyLogId_HourEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString6HourEnergyLog, DataPath = "3.252.1.6.68:EnergyLogId_HourEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString7HourEnergyLog, DataPath = "3.252.1.7.68:EnergyLogId_HourEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString8HourEnergyLog, DataPath = "3.252.1.8.68:EnergyLogId_HourEnergyLog", DataType = "vU16int5" });
            
            // Multi tenant load MinMax - hourly
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString1HourMinMaxEnergyLog, DataPath = "3.252.1.1.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString2HourMinMaxEnergyLog, DataPath = "3.252.1.2.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString3HourMinMaxEnergyLog, DataPath = "3.252.1.3.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString4HourMinMaxEnergyLog, DataPath = "3.252.1.4.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString5HourMinMaxEnergyLog, DataPath = "3.252.1.5.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString6HourMinMaxEnergyLog, DataPath = "3.252.1.6.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString7HourMinMaxEnergyLog, DataPath = "3.252.1.7.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString8HourMinMaxEnergyLog, DataPath = "3.252.1.8.68:EnergyLogId_HourMinMaxLog", DataType = "vU8int3" });

            // Multi tenant load energy - daily
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString1DayEnergyLog, DataPath = "3.252.1.1.68:EnergyLogId_DayEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString2DayEnergyLog, DataPath = "3.252.1.2.68:EnergyLogId_DayEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString3DayEnergyLog, DataPath = "3.252.1.3.68:EnergyLogId_DayEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString4DayEnergyLog, DataPath = "3.252.1.4.68:EnergyLogId_DayEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString5DayEnergyLog, DataPath = "3.252.1.5.68:EnergyLogId_DayEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString6DayEnergyLog, DataPath = "3.252.1.6.68:EnergyLogId_DayEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString7DayEnergyLog, DataPath = "3.252.1.7.68:EnergyLogId_DayEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString8DayEnergyLog, DataPath = "3.252.1.8.68:EnergyLogId_DayEnergyLog", DataType = "vU16int5" });

            // Multi tenant load MinMax - daily
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString1DayMinMaxEnergyLog, DataPath = "3.252.1.1.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString2DayMinMaxEnergyLog, DataPath = "3.252.1.2.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString3DayMinMaxEnergyLog, DataPath = "3.252.1.3.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString4DayMinMaxEnergyLog, DataPath = "3.252.1.4.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString5DayMinMaxEnergyLog, DataPath = "3.252.1.5.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString6DayMinMaxEnergyLog, DataPath = "3.252.1.6.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString7DayMinMaxEnergyLog, DataPath = "3.252.1.7.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString8DayMinMaxEnergyLog, DataPath = "3.252.1.8.68:EnergyLogId_DayMinMaxLog", DataType = "vU8int3" });

            // Multi tenant load energy - weekly
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString1WeekEnergyLog, DataPath = "3.252.1.1.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString2WeekEnergyLog, DataPath = "3.252.1.2.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString3WeekEnergyLog, DataPath = "3.252.1.3.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString4WeekEnergyLog, DataPath = "3.252.1.4.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString5WeekEnergyLog, DataPath = "3.252.1.5.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString6WeekEnergyLog, DataPath = "3.252.1.6.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString7WeekEnergyLog, DataPath = "3.252.1.7.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int5" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString8WeekEnergyLog, DataPath = "3.252.1.8.68:EnergyLogId_WeekEnergyLog", DataType = "vU16int5" });

            // Multi tenant load MinMax - weekly
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString1WeekMinMaxEnergyLog, DataPath = "3.252.1.1.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString2WeekMinMaxEnergyLog, DataPath = "3.252.1.2.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString3WeekMinMaxEnergyLog, DataPath = "3.252.1.3.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString4WeekMinMaxEnergyLog, DataPath = "3.252.1.4.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString5WeekMinMaxEnergyLog, DataPath = "3.252.1.5.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString6WeekMinMaxEnergyLog, DataPath = "3.252.1.6.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString7WeekMinMaxEnergyLog, DataPath = "3.252.1.7.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
            Items.Add(new DataPointDef { ProtocolId = ProtocolDef.LoadMon1LoadString8WeekMinMaxEnergyLog, DataPath = "3.252.1.8.68:EnergyLogId_WeekMinMaxLog", DataType = "vU8int3" });
        }                                          
                                                   
    }                                              
}                                                  
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
