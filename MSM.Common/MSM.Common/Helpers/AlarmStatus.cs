using System;
using System.Collections.Generic;

namespace MSMHelpers
{
    public static class AlarmStatus
    {
        #region Fields

        /// <summary>
        /// The ALL
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "RollingAlarmModels", MessageId = "ALL")]
        public const string ALL = "ALL";

        /// <summary>
        /// The al l_ major
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "RollingAlarmModels")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "RollingAlarmModels", MessageId = "ALL")]
        public const string ALL_Major = "All Major";

        /// <summary>
        /// The al l_ major_ minor
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "RollingAlarmModels")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "RollingAlarmModels", MessageId = "ALL")]
        public const string ALL_Major_Minor = "All Major-Minor";

        /// <summary>
        /// The al l_ minor
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "RollingAlarmModels")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "RollingAlarmModels", MessageId = "ALL")]
        public const string ALL_Minor = "A Minor";

        /// <summary>
        /// The al l_ off
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "RollingAlarmModels")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "RollingAlarmModels", MessageId = "ALL")]
        public const string ALL_Off = "All Offline";

        /// <summary>
        /// The disable
        /// </summary>
        public const string Disable = "Disable";

        /// <summary>
        /// The disconnected
        /// </summary>
        public const string Disconnected = "Disconnected";

        /// <summary>
        /// The error
        /// </summary>
        public const string Error = "Error";

        /// <summary>
        /// The major
        /// </summary>
        public const string Major = "Major";

        /// <summary>
        /// The major_ high
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "RollingAlarmModels")]
        public const string Major_High = "Major high";

        /// <summary>
        /// The major_ low
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "RollingAlarmModels")]
        public const string Major_Low = "Major low";

        /// <summary>
        /// The minor
        /// </summary>
        public const string Minor = "Minor";

        /// <summary>
        /// The minor_ high
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "RollingAlarmModels")]
        public const string Minor_High = "Minor high";

        /// <summary>
        /// The minor_ low
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "RollingAlarmModels")]
        public const string Minor_Low = "Minor low";

        /// <summary>
        /// The normal
        /// </summary>
        public const string Normal = "Normal";

        /// <summary>
        /// The not_ present
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "RollingAlarmModels")]
        public const string Not_Present = "Not present";

        /// <summary>
        /// The off_ status
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "RollingAlarmModels")]
        public const string Off_Status = "Off";

        /// <summary>
        /// The on_ status
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Justification = "RollingAlarmModels")]
        public const string On_Status = "On";

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the status code.
        /// </summary>
        /// <param name="status">The status.</param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Justification = "RollingAlarmModels")]
        public static List<int> GetStatusCode(string status)
        {
            List<int> res = new List<int>();

            /*
            0   Error
            1   Normal
            2   Minor alarm
            3   Major alarm
            4   Disable
            5   Disconnect
            6   Not present
            7   Major alarm
            8   Major low alarm
            9   Minor low alarm
            10  Major high alarm
            11  Minor high alarm
            */

            switch (status)
            {
                case AlarmStatus.Error:
                    res = new List<int>() { 0 };
                    break;
                case AlarmStatus.Disable:
                    res = new List<int>() { 4 };
                    break;
                case AlarmStatus.Not_Present:
                    res = new List<int>() { 6 };
                    break;
                case AlarmStatus.Major_Low:
                    res = new List<int>() { 8 };
                    break;
                case AlarmStatus.Major_High:
                    res = new List<int>() { 10 };
                    break;
                case AlarmStatus.Minor_Low:
                    res = new List<int>() { 9 };
                    break;
                case AlarmStatus.Minor_High:
                    res = new List<int>() { 11 };
                    break;
                case AlarmStatus.Major:
                    res = new List<int>() { 3, 7 };
                    break;
                case AlarmStatus.Minor:
                    res = new List<int>() { 2 };
                    break;
                case AlarmStatus.Normal:
                    res = new List<int>() { 1, 12 };
                    break;
                case AlarmStatus.Disconnected:
                    res = new List<int>() { 5 };
                    break;
                case AlarmStatus.ALL_Major:
                    // Remove the Error code out of the list
                    res = new List<int>() { 3, 7, 8, 10 };
                    break;
                case AlarmStatus.ALL_Minor:
                    res = new List<int>() { 2, 9, 11 };
                    break;
                case AlarmStatus.ALL_Off:
                    res = new List<int>() { 4, 5 };
                    break;
                case AlarmStatus.ALL_Major_Minor:
                    // Remove the Error code out of the list
                    res = new List<int>() { 3, 7, 8, 10, 2, 9, 11 };
                    break;
                case AlarmStatus.ALL:
                    res = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 254 };
                    break;
            }

            return res;
        }

        /// <summary>
        /// Gets the status description.
        /// </summary>
        /// <param name="statusIndex">Index of the status.</param>
        /// <returns></returns>
        public static string GetStatusDescription(int statusIndex)
        {
            /*
            0   Error
            1   Normal
            2   Minor alarm
            3   Major alarm
            4   Disable
            5   Disconnect
            6   Not present
            7   Major alarm
            8   Major low alarm
            9   Minor low alarm
            10  Major high alarm
            11  Minor high alarm
            */

            switch ((int)statusIndex)
            {
                case 0:
                    return AlarmStatus.Error;
                //// major alarm => red icon
                case 3:
                case 7:
                    return AlarmStatus.Major;
                case 8:
                    return AlarmStatus.Major_Low;
                case 10:
                    return AlarmStatus.Major_High;

                //// normal => green
                case 1:
                case 12:
                    return AlarmStatus.Normal;

                //// minor => yellow
                case 2:
                    return AlarmStatus.Minor;
                case 9:
                    return AlarmStatus.Minor_Low;
                case 11:
                    return AlarmStatus.Minor_High;

                //// disable/disconnect => grey
                case 4:
                    return AlarmStatus.Disable;
                case 5:
                    return AlarmStatus.Disconnected;
                case 6:
                    return AlarmStatus.Not_Present;
                default:
                    return string.Empty;
            }
        }

        #endregion Methods
    }
}
