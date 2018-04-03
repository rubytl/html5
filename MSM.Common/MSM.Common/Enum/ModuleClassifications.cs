using System.ComponentModel;

namespace MSMEnumerations
{
    public enum ModuleClassifications
    {
        [Description("Control unit")]
        ControlUnit = 1,

        [Description("Battery string")]
        BatteryString = 2,

        [Description("Rectifier")]
        Rectifier = 5,

        [Description("Solar")]
        Solar = 12,
        
        [Description("Rectiverter")]
        Rectiverter = 21
    }
}
