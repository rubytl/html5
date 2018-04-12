using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSM.Data.Models;

namespace MSM.Data.Repositories.Interfaces
{
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
    }
}
