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
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Justification = "ControllerType enum"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Justification = "ControllerType enum")]
    public enum ControllerTypeEnum
    {
        /// <summary>
        /// The compack
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "COMPACK", Justification = "Compack")]
        [Description("ComPack")]
        COMPACK = 1,

        /// <summary>
        /// The orion
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ORION", Justification = "Orion")]
        [Description("Orion")]
        ORION = 2,

        /// <summary>
        /// The smartpack2
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SMARTPACK", Justification = "Smartpack 2")]
        [Description("SmartPack 2")]
        SMARTPACK2 = 3,

        /// <summary>
        /// The smartpacks
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SMARTPACKS", Justification = "Smartpack S")]
        [Description("SmartPack S")]
        SMARTPACKS = 4,

        /// <summary>
        /// The smartpack
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SMARTPACK", Justification = "Smartpack")]
        [Description("SmartPack")]
        SMARTPACK = 5,

        /// <summary>
        /// The smartpack
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "MCF", Justification = "MCF")]
        [Description("SmartPack (MCF5235)")]
        MCF5235 = 6,

        /// <summary>
        /// The smartpack
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "MCF", Justification = "MCF")]
        [Description("SmartPack (MCF5208)")]
        MCF5208 = 7,

        /////// <summary>
        /////// The smartpack
        /////// </summary>
        ////[Description("SmartPack (SB70)")]
        ////SB70 = 8,

        /////// <summary>
        /////// The smartpack
        /////// </summary>
        ////[Description("SmartPack (SB72)")]
        ////SB72 = 9,
    }
}
