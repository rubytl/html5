// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Eltek AS" file="eNexusJsonEnum.cs">
//   (c) Copyright 2010-2015 Eltek AS
// </copyright>
// <summary>
//   eNexusJsonEnum
//   $Revision: 13$
//   $Author: haenno$//   $Archive $
//   $Date: 10. november 2017 08:27:16$
//   $Modtime: 30. august 2017 08:29:59$
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MSMEnumerations
{
    using System.Collections.Generic;
    using System.ComponentModel;

    #region Enumerations

    /// <summary>
    /// The eNexusWrite_JsonResponse class
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "e")]
    public enum eNexusWrite_JsonResponse
    {
        /// <summary>
        /// The failed
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "failed")]
        [Description("failed")]
        failed,

        /// <summary>
        /// The successful
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "successful")]
        [Description("successful")]
        successful,

        /// <summary>
        /// The no response
        /// </summary>
        [Description("No response or time out")]
        NoResponse
    }

    /// <summary>
    /// The eNexus_Function class
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "e")]
    public enum eNexus_Function
    {
        /// <summary>
        /// The function_ read value
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_ReadValue,

        /// <summary>
        /// The function_ write value
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_WriteValue,

        /// <summary>
        /// The function_ no response
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_NoResponse,

        /// <summary>
        /// The function_ response value
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_ResponseValue,

        /// <summary>
        /// The function_ to high
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_ToHigh,

        /// <summary>
        /// The function_ to low
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_ToLow,

        /// <summary>
        /// The function_ read only
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_ReadOnly,

        /// <summary>
        /// The function_ read maximum
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_ReadMax,

        /// <summary>
        /// The function_ read minimum
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_ReadMin,

        /// <summary>
        /// The function_ set default CFG
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "Cfg")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_SetDefaultCfg,

        /// <summary>
        /// The function_ read default
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_ReadDefault,

        /// <summary>
        /// The function_ RSP minimum
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "Rsp")]
        Function_RspMin,

        /// <summary>
        /// The function_ RSP maximum
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "Rsp")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_RspMax,

        /// <summary>
        /// The function_ RSP default
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "Rsp")]
        Function_RspDefault,

        /// <summary>
        /// The function_ no minimum RSP
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "Rsp")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_NoMinRsp,

        /// <summary>
        /// The function_ no maximum RSP
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "Rsp")]
        Function_NoMaxRsp,

        /// <summary>
        /// The function_ no default RSP
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "Rsp")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_NoDefaultRsp,

        /// <summary>
        /// The function_ event
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_Event,

        /// <summary>
        /// The function_ status
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_Status,

        /// <summary>
        /// The function_ update
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_Update,

        /// <summary>
        /// The function_ not initialized
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_NotInitialized,

        /// <summary>
        /// The function_ log on
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_LogOn,

        /// <summary>
        /// The function_ do update value
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_DoUpdateValue,

        /// <summary>
        /// The function_ command
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_Command,

        /// <summary>
        /// The function_ log on request
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_LogOnRequest,

        /// <summary>
        /// The function_ log on response
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_LogOnResponse,

        /// <summary>
        /// The function_ go to serial bus
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_GoToSerialBus,

        /// <summary>
        /// The function_ current share
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_CurrentShare,

        /// <summary>
        /// The function_ master CFG
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "Cfg")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_MasterCfg,

        /// <summary>
        /// The function_ not present
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_NotPresent,

        /// <summary>
        /// The function_ start state machine
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_StartStateMachine,

        /// <summary>
        /// The function_ enable current share
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_EnableCurrentShare,

        /// <summary>
        /// The function_ disable current share
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_DisableCurrentShare,

        /// <summary>
        /// The function_ logg data
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "Logg")]
        Function_LoggData,

        /// <summary>
        /// The function_ set default calibration values
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Function_SetDefaultCalibrationValues,

        /// <summary>
        /// The function_ ps internal_ read as write_master password only
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "master")]
        Function_PSInternal_ReadAsWrite_masterPasswordOnly = 234,

        /// <summary>
        /// The function_ ps internal_test output
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "test")]
        Function_PSInternal_testOutput = 235
    }

    /// <summary>
    /// The eNexus_Object class
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1027:MarkEnumsWithFlags", Justification = "eNexusJsonEnum"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "e")]
    public enum eNexus_Object
    {
        /// <summary>
        /// The object_broadcast
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "broadcast")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_broadcast,

        /// <summary>
        /// The object_this
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "this")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_this,

        /// <summary>
        /// The object_output voltage
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "output")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_outputVoltage,

        /// <summary>
        /// The object_current
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "current")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_current,

        /// <summary>
        /// The object_temp
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "temp")]
        Object_temp,

        /// <summary>
        /// The object_power
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "power")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_power,

        /// <summary>
        /// The object_lvd
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "lvd")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "lvd")]
        Object_lvd,

        /// <summary>
        /// The object_breaker
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "breaker")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_breaker,

        /// <summary>
        /// The object_fuse
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "fuse")]
        Object_fuse,

        /// <summary>
        /// The object_capacity
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "capacity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_capacity,

        /// <summary>
        /// The object_product
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "product")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_product,

        /// <summary>
        /// The object_clock
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "clock")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_clock,

        /// <summary>
        /// The object_software
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "software")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_software,

        /// <summary>
        /// The object_analog input
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "analog")]
        Object_analogInput,

        /// <summary>
        /// The object_digital input
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "digital")]
        Object_digitalInput,

        /// <summary>
        /// The object_digital output
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "digital")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_digitalOutput,

        /// <summary>
        /// The object_comport
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "comport")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_comport,

        /// <summary>
        /// The object_used capacity
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "used")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_usedCapacity,

        /// <summary>
        /// The object_remaining capacity
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "remaining")]
        Object_remainingCapacity,

        /// <summary>
        /// The object_delta voltage
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "delta")]
        Object_deltaVoltage,

        /// <summary>
        /// The object_internal volt
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "internal")]
        Object_internalVolt,

        /// <summary>
        /// The object_in voltage
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "in")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_inVoltage,

        /// <summary>
        /// The object_analog output
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "analog")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_analogOutput,

        /// <summary>
        /// The object_speed
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "speed")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_speed,

        /// <summary>
        /// The object_error
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "error")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_error,

        /// <summary>
        /// The object_ovs
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "ovs")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "ovs")]
        Object_ovs,

        /// <summary>
        /// The object_switch
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "switch")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_switch,

        /// <summary>
        /// The object_current limit reached
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "current")]
        Object_currentLimitReached,

        /// <summary>
        /// The object_eeprom
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "eeprom")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "eeprom")]
        Object_eeprom,

        /// <summary>
        /// The object_flash
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "flash")]
        Object_flash,

        /// <summary>
        /// The object_ram
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "ram")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_ram,

        /// <summary>
        /// The object_red led
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "red")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_redLed,

        /// <summary>
        /// The object_yellow led
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "yellow")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_yellowLed,

        /// <summary>
        /// The object_green led
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "green")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_greenLed,

        /// <summary>
        /// The object_alarm output
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "alarm")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_alarmOutput,

        /// <summary>
        /// The object_speed control
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "speed")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_speedControl,

        /// <summary>
        /// The object_current limit control
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "current")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_currentLimitControl,

        /// <summary>
        /// The object_volt reference control
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "volt")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_voltRefControl,

        /// <summary>
        /// The object_shut down control
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "shutDown")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "shut")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_shutDownControl,

        /// <summary>
        /// The object_bar graph
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "bar")]
        Object_barGraph,

        /// <summary>
        /// The object_module type
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "module")]
        Object_moduleType,

        /// <summary>
        /// The object_block voltage
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "block")]
        Object_blockVoltage,

        /// <summary>
        /// The object_average block voltage
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "average")]
        Object_averageBlockVoltage,

        /// <summary>
        /// The object_buzzer
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "buzzer")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_buzzer,

        /// <summary>
        /// The object_input
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "input")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_input,

        /// <summary>
        /// The object_alarm group
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "alarm")]
        Object_alarmGroup,

        /// <summary>
        /// The object_connection
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "connection")]
        Object_connection,

        /// <summary>
        /// The object_modul running
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "modul")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "modul")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_modulRunning,

        /// <summary>
        /// The object_delay
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "delay")]
        Object_delay,

        /// <summary>
        /// The object_batt quality
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "batt")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "batt")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_battQuality,

        /// <summary>
        /// The object_batt test result
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "batt")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "batt")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_battTestResult,

        /// <summary>
        /// The object_ovs lock out
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "ovs")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "ovs")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "LockOut")]
        Object_ovsLockOut,

        /// <summary>
        /// The object_temp level hour
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "temp")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_tempLevelHour,

        /// <summary>
        /// The object_no of sub comm errors
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "no")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "Comm")]
        Object_noOfSubCommErrors,

        /// <summary>
        /// The object_no of sub alarms
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "no")]
        Object_noOfSubAlarms,

        /// <summary>
        /// The object_no of sub warnings
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "no")]
        Object_noOfSubWarnings,

        /// <summary>
        /// The object_batt type
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "batt")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "batt")]
        Object_battType,

        /// <summary>
        /// The object_input voltage
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "input")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_inputVoltage,

        /// <summary>
        /// The object_battery temporary level
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "battery")]
        Object_batteryTempLevel,

        /// <summary>
        /// The object_frequency
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "frequency")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_frequency,

        /// <summary>
        /// The object_logg
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "logg")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "logg")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_logg,

        /// <summary>
        /// The object_attempt
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "attempt")]
        Object_attempt,

        /// <summary>
        /// The object_ bleeder control
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_BleederControl,

        /// <summary>
        /// The object_temp_external
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "temp")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "external")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_temp_external,

        /// <summary>
        /// The object_discharge time left
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "discharge")]
        Object_dischargeTimeLeft,

        /// <summary>
        /// The object_fan failure
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "fan")]
        Object_fanFailure,

        /// <summary>
        /// The object_conductivity
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "conductivity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_conductivity,

        /// <summary>
        /// The object_current share
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "current")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_currentShare,

        /// <summary>
        /// The object_energy log
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "energy")]
        Object_energyLog,

        /// <summary>
        /// The object_plc group
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "plc")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "plc")]
        Object_plcGroup = 72,

        /// <summary>
        /// The object_delta prosent
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "delta")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "Prosent")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_deltaProsent,

        /// <summary>
        /// The object_trip log
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "trip")]
        Object_tripLog = 79,

        /// <summary>
        /// The object_trip counter
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "trip")]
        Object_tripCounter,

        /// <summary>
        /// The object_volume
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "volume")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_volume,

        /// <summary>
        /// The object_resistance
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "resistance")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_resistance,

        /// <summary>
        /// The object_delta temporary
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "delta")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_deltaTemp = 91,

        /// <summary>
        /// The object_ah charged
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "ah")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_ahCharged,

        /// <summary>
        /// The object_ah discharged
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "ah")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        Object_ahDischarged,

        /// <summary>
        /// The object_xy table
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "xy")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "xy")]
        Object_xyTable,

        /// <summary>
        /// The object_last
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "last")]
        Object_last
    }

    /// <summary>
    /// The eNexus_Status class
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1027:MarkEnumsWithFlags", Justification = "eNexusJsonEnum"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "e")]
    public enum eNexus_Status
    {
        /// <summary>
        /// The error
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "error")]
        [Description("Error")]
        error = 0,

        /// <summary>
        /// The normal
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "normal")]
        [Description("Normal")]
        normal = 1,

        /// <summary>
        /// The minor alarm
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "minor")]
        [Description("Minor Alarm")]
        minorAlarm = 2,

        /// <summary>
        /// The major alarm
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "major")]
        [Description("Major Alarm")]
        majorAlarm = 3,

        /// <summary>
        /// The disable
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "disable")]
        [Description("Disable")]
        disable = 4,

        /// <summary>
        /// The disconnect
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "disconnect")]
        [Description("Disconnect")]
        disconnect = 5,

        /// <summary>
        /// The not present
        /// </summary>
        [Description("Not Present")]
        NotPresent = 6,

        /// <summary>
        /// The minor major
        /// </summary>
        [Description("Minor Major")]
        MinorMajor = 7,

        /// <summary>
        /// The major low
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "major")]
        [Description("Major Low")]
        majorLow = 8,

        /// <summary>
        /// The minor low
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "minor")]
        [Description("Minor Low")]
        minorLow = 9,

        /// <summary>
        /// The major high
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "major")]
        [Description("Minor Hight")]
        majorHigh = 10,

        /// <summary>
        /// The minor high
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "minor")]
        [Description("Minor High")]
        minorHigh = 11,

        /// <summary>
        /// The event
        /// </summary>
        [Description("Event")]
        Event = 12,

        /// <summary>
        /// The value volt
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "value")]
        [Description("Value Volt")]
        valueVolt = 13,

        /// <summary>
        /// The value amp
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "value")]
        [Description("Value Amp")]
        valueAmp = 14,

        /// <summary>
        /// The value temporary
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "value")]
        [Description("Value Temp")]
        valueTemp = 15,

        /// <summary>
        /// The value unit
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "value")]
        [Description("Value Unit")]
        valueUnit = 16,

        /// <summary>
        /// The value per cent
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "PerCent")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "value")]
        [Description("Value Percent")]
        valuePerCent = 17,

        /// <summary>
        /// The critical
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "critical")]
        [Description("Critical")]
        critical = 18,

        /// <summary>
        /// The warning
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "warning")]
        [Description("Warning")]
        warning = 19,

        /// <summary>
        /// The start command
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "start")]
        [Description("Start Cmd")]
        startCmd = 21,

        /// <summary>
        /// The batter y_ test
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "BATTERY")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "TEST")]
        [Description("Battery Test")]
        BATTERY_TEST = 22,

        /// <summary>
        /// The boost
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "BOOST")]
        [Description("Boost")]
        BOOST = 23,

        /// <summary>
        /// The tota l_ shutdown
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "SHUTDOWN")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "TOTAL")]
        [Description("Total Shutdown")]
        TOTAL_SHUTDOWN = 24,

        /// <summary>
        /// The alar m_ reset
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "ALARM")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "RESET")]
        [Description("Alarm Reset")]
        ALARM_RESET = 25,

        /// <summary>
        /// The partia l_ shutdown
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "SHUTDOWN")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "PARTIAL")]
        [Description("Partial Shutdown")]
        PARTIAL_SHUTDOWN = 26,

        /// <summary>
        /// The numbe r_ reset
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "NUMBER")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "RESET")]
        [Description("Number Reset")]
        NUMBER_RESET = 27,

        /// <summary>
        /// The i d_ afte r_ seria l_ no
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "ID")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "SERIAL")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "AFTER")]
        [Description("ID After Serial No")]
        ID_AFTER_SERIAL_NO = 28,

        /// <summary>
        /// The appl y_ changes
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "APPLY")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "CHANGES")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [Description("Apply Changes")]
        APPLY_CHANGES = 29,

        /// <summary>
        /// The enabl e_ record t_ curren t_ limit
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "RECT")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "LIMIT")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "ENABLE")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "CURRENT")]
        [Description("Enable Rect Current Limit")]
        ENABLE_RECT_CURRENT_LIMIT = 30,

        /// <summary>
        /// The enabl e_ bat t_ curren t_ limit
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "CURRENT")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "ENABLE")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "LIMIT")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "BATT")]
        [Description("Enable Batt Current Limit")]
        ENABLE_BATT_CURRENT_LIMIT = 31,

        /// <summary>
        /// The enabl e_ tem p_ comp
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "ENABLE")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "TEMP")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "COMP")]
        [Description("Enable Temp Comp")]
        ENABLE_TEMP_COMP = 32,

        /// <summary>
        /// The boos t_ inhibit
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "INHIBIT")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "BOOST")]
        [Description("Boost Inhibit")]
        BOOST_INHIBIT = 33,

        /// <summary>
        /// The syste m_ reset
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "SYSTEM")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "RESET")]
        [Description("System Reset")]
        SYSTEM_RESET = 34,

        /// <summary>
        /// The servic e_ mode
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "MODE")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "SERVICE")]
        [Description("Service Mode")]
        SERVICE_MODE = 35,

        /// <summary>
        /// The cf g_ download
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "CFG")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "DOWNLOAD")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [Description("CFG Download")]
        CFG_DOWNLOAD = 36,

        /// <summary>
        /// The generato r_ command
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "CMD")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "GENERATOR")]
        [Description("Generator Cmd")]
        GENERATOR_CMD = 37,

        /// <summary>
        /// The emergency
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "EMERGENCY")]
        [Description("Emergency")]
        EMERGENCY = 38,

        /// <summary>
        /// The batter y_ tes t_ inhibit
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "INHIBIT")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "BATTERY")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "TEST")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [Description("Battery Test Inhibit")]
        BATTERY_TEST_INHIBIT = 39,

        /// <summary>
        /// The equalize
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "EQUALIZE")]
        [Description("Equalize")]
        EQUALIZE = 40,

        /// <summary>
        /// The equaliz e_ inhibit
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "EQUALIZE")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "INHIBIT")]
        [Description("Equalize Inhibit")]
        EQUALIZE_INHIBIT = 41,

        /// <summary>
        /// The silenc e_ buzzer
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "SILENCE")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "BUZZER")]
        [Description("Silence Buzzer")]
        SILENCE_BUZZER = 42,

        /// <summary>
        /// The earthfaul t_ inhibit
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "INHIBIT")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "EARTHFAULT")]
        [Description("Earth Fault Inhibit")]
        EARTHFAULT_INHIBIT = 43,

        /// <summary>
        /// The DCD c_ shutdown
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "SHUTDOWN")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "DCDC")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [Description("DCDC Shutdown")]
        DCDC_SHUTDOWN = 44,

        /// <summary>
        /// The nt p_ poll
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "NTP")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "POLL")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [Description("Ntp Poll")]
        NTP_POLL = 45,

        /// <summary>
        /// The shu t_ dow n_ inverters
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "DOWN")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "INVERTERS")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "SHUT")]
        [Description("Shutdown Inverters")]
        SHUT_DOWN_INVERTERS = 46
    }

    /// <summary>
    /// The eNexus_SystemType class
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Justification = "eNexusJsonEnum"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "e")]
    public enum eNexus_SystemType
    {
        /// <summary>
        /// The system type_ dc system
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "Dc")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        SystemType_DcSystem = 1,

        /// <summary>
        /// The system type_ battery
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        SystemType_Battery = 2,

        /// <summary>
        /// The system type_ load distribution
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        SystemType_LoadDistribution = 3,

        /// <summary>
        /// The system type_ a c_input
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "input")]
        SystemType_AC_input = 4,

        /// <summary>
        /// The system type_ rectifier
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        SystemType_Rectifier = 5,

        /// <summary>
        /// The system type_ control system
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        SystemType_ControlSystem = 6,

        /// <summary>
        /// The system type_ dc dc module
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "Dc")]
        SystemType_DcDcModule = 7,

        /// <summary>
        /// The system type_ generator
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        SystemType_Generator = 11,

        /// <summary>
        /// The system type_ solar charger
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        SystemType_SolarCharger = 12,

        /// <summary>
        /// The system type_ wind chager
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "Chager")]
        SystemType_WindChager = 13,

        /// <summary>
        /// The system type_ inverter
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        SystemType_Inverter = 15,

        /// <summary>
        /// The system type_ grid inverter
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        SystemType_GridInverter = 16,

        /// <summary>
        /// The system type_ solar inverter
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        SystemType_SolarInverter = 17,

        /// <summary>
        /// The system type_ rectiverter
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "Rectiverter")]
        SystemType_Rectiverter = 21,

        //specific orion system type
        SystemType_UserInterfaceModule = 200,
        SystemType_ModbusModule = 201,
        //Gateway battery module handled by SystemType_Battery = 2,
        SystemType_StaticVoltageRegulator = 202,
        SystemType_HealthyPhaseSelector = 203,
        SystemType_StringSensorModule = 204,
        SystemType_BlockSensorModule = 205,
        SystemType_AirCon = 206,
        SystemType_FanControl = 207,
        SystemType_IO_module = 208,
        SystemType_Lead_Acid_Battery = 209,
        SystemType_Lithium_Battery = 210
        //Rectifier handled by SystemType_Rectifier = 5,
        //DC DC module handled by SystemType_DcDcModule = 7,
        //AC module handled by SystemType_AC_input = 4,
        //PV converter(solar) handled by SystemType_SolarCharger = 12,
        //Generator module handled by SystemType_Generator = 11,
    }

    /// <summary>
    /// type of value used in PowerSuite
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "XML")]
    public enum XMLConfig_TypeOfValue
    {
        /// <summary>
        /// no type specified
        /// </summary>
        None,

        /// <summary>
        /// The volt dc (two digits after comma)
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "volt")]
        voltDC,

        /// <summary>
        /// The volt ac (unsigned interger)
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "volt")]
        voltAC,

        /// <summary>
        /// The current (signed interger)
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "current")]
        current,

        /// <summary>
        /// The temperature (signed interger)
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "temperature")]
        temperature,

        /// <summary>
        /// The status (byte 5)
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "status")]
        status,

        /// <summary>
        /// The boolean
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "boolean")]
        boolean,

        /// <summary>
        /// The integer (unsigned integer 7)
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "integer")]
        integer,

        /// <summary>
        /// The text
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "text")]
        text,

        /// <summary>
        /// The time
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "time")]
        time,

        /// <summary>
        /// The date
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "date")]
        date,

        /// <summary>
        /// The event information
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "event")]
        eventInfo,

        /// <summary>
        /// The test information
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "test")]
        testInfo,

        /// <summary>
        /// The enum event (event is a protected word)
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "enum")]
        enumEvent,

        /// <summary>
        /// The array
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "array")]
        array,

        /// <summary>
        /// The signed integer
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "signed")]
        signedInteger,

        /// <summary>
        /// The rectifier current (one digit after comma ( deciamp ))
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "rectifier")]
        rectifierCurrent,

        /// <summary>
        /// The volt d c2 ( four digits after comma)
        /// </summary>
        VoltDC2,

        /// <summary>
        /// The uint8
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "uint")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "uint")]
        uint8,

        /// <summary>
        /// The int8 s
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "int")]
        int8S,

        /// <summary>
        /// The int32 u
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "int")]
        int32U,

        /// <summary>
        /// The int32 s
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "int")]
        int32S,

        /// <summary>
        /// The bit mask configuration
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "bitMask")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "bit")]
        bitMaskConfig,

        /// <summary>
        /// The bit mask status
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "bit")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "bitMask")]
        bitMaskStatus,

        /// <summary>
        /// The one decimal
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "one")]
        oneDecimal,

        /// <summary>
        /// The two decimals
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "two")]
        twoDecimals,

        /// <summary>
        /// The signed one decimal
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "signed")]
        signedOneDecimal,

        /// <summary>
        /// The signed two decimals
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "signed")]
        signedTwoDecimals,

        /// <summary>
        /// The ip address
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "ip")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "eNexusJsonEnum", MessageId = "ip")]
        ipAddress
    }

    public enum SnmpTargetAddressId
    {
        Id_cfgSnmpAddrName,
        Id_cfgSnmpIPAddress,
        Id_cfgSnmpIPPort,
        Id_cfgSnmpAddrTag,
        Id_cfgSnmpAddrParams,
        Id_notUsed,
        Id_cfgAction,
    }

    public enum SnmpTargetParamsId
    {
        Id_cfgSnmpParamsName,
        Id_cfgSnmpParamsMPModel,
        Id_cfgSnmpSecurityName,
        Id_cfgSnmpSecurityModel,
        Id_cfgAction,
    }

    /// <summary>
    /// The xmlEventReport_ResponseTag class
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "eNexusJsonEnum"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "eNexusJsonEnum", MessageId = "xml")]
    public enum xmlEventReport_ResponseTag
    {
        /// <summary>
        /// The response write
        /// </summary>
        [Description("ResponseWrite")]
        ResponseWrite,

        /// <summary>
        /// The response read
        /// </summary>
        [Description("ResponseRead")]
        ResponseRead
    }

    #endregion Enumerations
}