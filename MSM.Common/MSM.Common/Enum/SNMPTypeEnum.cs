using System.ComponentModel;

namespace MSMEnumerations
{
    public enum SNMPVersionEnum
    {
        [Description("v1")]
        v1 = 1,

        [Description("v2")]
        v2 = 2,

        [Description("v3")]
        v3 = 3,

    }

    public enum AuthProtocolEnum
    {
        [Description("None")]
        None = 0,

        [Description("MD5")]
        MD5 = 1,

        [Description("SHA1")]
        SHA1 = 2
    }

    public enum PrivProtocolEnum
    {
        [Description("None")]
        None = 0,

        [Description("DES")]
        DES = 1,

        [Description("AES")]
        AES = 2
    }

    public enum SecurityLevelEnum
    {
        [Description("None")]
        None = 0,

        [Description("noAuthNoPriv")]
        noAuthNoPriv = 1,

        [Description("authNoPriv")]
        authNoPriv = 2,

        [Description("authPriv")]
        authPriv = 3
    }
}
