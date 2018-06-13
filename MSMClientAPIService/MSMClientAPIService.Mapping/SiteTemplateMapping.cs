using System;
using System.Collections.Generic;
using System.Text;
using MSM.Data.Models;
using MSMClientAPIService.Mapping.Models;

namespace MSMClientAPIService.Mapping
{
    public class SiteTemplateMapping
    {
        public static void MapTemplateModelToExistingTemplate(SiteTemplateModel model, SiteTemplate entity)
        {
            entity.TemplateName = model.TemplateName;
            entity.MainsMonitor = model.MainsMonitor;
            entity.MainsMonitorOnSystem = model.MainsMonitorOnSystem;
            entity.Monitor1 = model.Monitor1;
            entity.Monitor2 = model.Monitor2;
            entity.Monitor3 = model.Monitor3;
            entity.Monitor4 = model.Monitor4;
            entity.Monitor5 = model.Monitor5;
            entity.Monitor6 = model.Monitor6;
            entity.OnGrid = model.OnGrid;
            entity.MainsFractionTarget = model.MainsFractionTarget;
            entity.Solar = model.Solar;
            entity.SolarEnergyTarget = model.SolarEnergyTarget;
            entity.Wind = model.Wind;
            entity.WindEnergyTarget = model.WindEnergyTarget;
            entity.RenewEnergyTarget = model.RenewEnergyTarget;
            entity.Generator = model.Generator;
            entity.GenRunHourTarget = model.GenRunHourTarget;
            entity.GenEfficiencyTarget = model.GenEfficiencyTarget;
            entity.PeakLoadRange = model.PeakLoadRange;
            entity.AverageLoadRange = model.AverageLoadRange;
            entity.Battery = model.Battery;
            entity.InstalledBatteryBackupTarget = model.InstalledBatteryBackupTarget;
            entity.AveLoadResetInterval = model.AveLoadResetInterval;
            entity.BatteryDischargeAh = model.BatteryDischargeAh;
            entity.OverChargetTarget = model.OverChargetTarget;
            entity.MainsAvlTarget = model.MainsAvlTarget;
            entity.ConnQualityTarget = model.ConnQualityTarget;
            entity.ConnLossTarget = model.ConnLossTarget;
            entity.IoUnitWithEcbonSystem = model.IoUnitWithEcbonSystem;
            entity.EcbrunTimeTarget = model.EcbrunTimeTarget;
            entity.AirConRunTimeTarget = model.AirConRunTimeTarget;
        }

        public static SiteTemplate MapTemplateModelToTemplate(SiteTemplateModel model)
        {
            return new SiteTemplate()
            {
                TemplateName = model.TemplateName,
                MainsMonitor = model.MainsMonitor,
                MainsMonitorOnSystem = model.MainsMonitorOnSystem,
                Monitor1 = model.Monitor1,
                Monitor2 = model.Monitor2,
                Monitor3 = model.Monitor3,
                Monitor4 = model.Monitor4,
                Monitor5 = model.Monitor5,
                Monitor6 = model.Monitor6,
                OnGrid = model.OnGrid,
                MainsFractionTarget = model.MainsFractionTarget,
                Solar = model.Solar,
                SolarEnergyTarget = model.SolarEnergyTarget,
                Wind = model.Wind,
                WindEnergyTarget = model.WindEnergyTarget,
                RenewEnergyTarget = model.RenewEnergyTarget,
                Generator = model.Generator,
                GenRunHourTarget = model.GenRunHourTarget,
                GenEfficiencyTarget = model.GenEfficiencyTarget,
                PeakLoadRange = model.PeakLoadRange,
                AverageLoadRange = model.AverageLoadRange,
                Battery = model.Battery,
                InstalledBatteryBackupTarget = model.InstalledBatteryBackupTarget,
                AveLoadResetInterval = model.AveLoadResetInterval,
                BatteryDischargeAh = model.BatteryDischargeAh,
                OverChargetTarget = model.OverChargetTarget,
                MainsAvlTarget = model.MainsAvlTarget,
                ConnQualityTarget = model.ConnQualityTarget,
                ConnLossTarget = model.ConnLossTarget,
                IoUnitWithEcbonSystem = model.IoUnitWithEcbonSystem,
                EcbrunTimeTarget = model.EcbrunTimeTarget,
                AirConRunTimeTarget = model.AirConRunTimeTarget,
            };
        }
    }
}
