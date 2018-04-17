using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;
using System.Linq;

namespace MSM.Data.Repositories
{
    public class AlarmRepository : EntityBaseRepository<SnmpreceiverHistory>, IAlarmRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMaintenanceRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AlarmRepository(Func<MultisiteDBEntitiesContext> context)
            : base(context)
        { }

        /// <summary>
        /// Gets the filtered SNMP receiver history.
        /// </summary>
        /// <param name="statusCode">The status code.</param>
        /// <param name="fromTime">From time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="maxAlarmID">The maximum alarm identifier.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IQueryable<SnmpreceiverHistory>> GetFilteredSNMPReceiverHistory(List<int> statusCode,
            DateTime? fromTime, DateTime? endTime, long maxAlarmID)
        {
            return await this.FindBy(s => !string.IsNullOrEmpty(s.Ipaddress) &&
             (fromTime.HasValue ? s.ReceiveTime >= fromTime : true) &&
             (endTime.HasValue ? s.ReceiveTime <= endTime : true) &&
             s.SnmptrapId > maxAlarmID &&
             statusCode.Contains(s.EventType));
        }

        public async Task<IQueryable<SnmpreceiverHistory>> GetAlarms()
        {
            return await Task.FromResult(this.Context.SnmpreceiverHistory.Where(s => !string.IsNullOrEmpty(s.Ipaddress)).OrderByDescending(s => s.ReceiveTime).Take(20));
        }

    }
}
