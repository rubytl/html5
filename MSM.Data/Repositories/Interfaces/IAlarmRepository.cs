using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSM.Data.Models;

namespace MSM.Data.Repositories.Interfaces
{
    /// <summary>
    /// The IAlarmRepository
    /// </summary>
    /// <seealso cref="MSM.Data.Repositories.Interfaces.IEntityBaseRepository{MSM.Data.Models.SnmpreceiverHistory}" />
    public interface IAlarmRepository : IEntityBaseRepository<SnmpreceiverHistory>
    {
        /// <summary>
        /// Gets the filtered SNMP receiver history.
        /// </summary>
        /// <param name="statusCode">The status code.</param>
        /// <param name="fromTime">From time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="maxAlarmID">The maximum alarm identifier.</param>
        /// <returns></returns>
        Task<IQueryable<SnmpreceiverHistory>> GetFilteredSNMPReceiverHistory(List<int> statusCode,
            DateTime? fromTime, DateTime? endTime, long maxAlarmID);

        /// <summary>
        /// Gets the alarms.
        /// </summary>
        /// <returns></returns>
        Task<IQueryable<SnmpreceiverHistory>> GetAlarms();
    }
}
