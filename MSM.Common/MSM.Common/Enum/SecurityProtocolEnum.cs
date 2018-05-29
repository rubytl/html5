// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Eltek AS" file="ControllerTypeEnum.cs">
//   (c) Copyright 2010-2013 Eltek
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace MSMEnumerations
{
    using System.ComponentModel;

    /// <summary>
    /// The ControllerTypeEnum
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Justification = "SecurityProtocol enum"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = "SecurityProtocol enum")]
    public enum SecurityProtocolEnum
    {
        /// <summary>
        /// Ssl3
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SSL3", Justification = "SSL3")]
        [Description("SSL3")]
        Ssl3 = 48,

        /// <summary>
        /// Tls12
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "TLS1.2", Justification = "TLS1.2")]
        [Description("TLS1.2")]
        Tls12 = 3072,

    }
}
