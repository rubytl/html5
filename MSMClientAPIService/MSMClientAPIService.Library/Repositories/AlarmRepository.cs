using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MSMClientAPIService.Data.Models;
using MSMClientAPIService.Data.Repositories.Interfaces;
using System.Linq;

namespace MSMClientAPIService.Data.Repositories
{
    public class AlarmRepository : EntityBaseRepository<SnmpreceiverHistory>, IAlarmRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMaintenanceRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AlarmRepository(MultisiteDBEntitiesContext context)
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

        private object GetDynamicSortProperty(object item, string propName)
        {
            //Use reflection to get order type
            return item.GetType().GetProperty(propName).GetValue(item, null);
        }
    }
}
