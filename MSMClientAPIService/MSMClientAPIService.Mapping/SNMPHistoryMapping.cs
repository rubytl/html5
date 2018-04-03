using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSMClientAPIService.Data.Models;
using MSMClientAPIService.Mapping.Models;
using MSMHelpers;

namespace MSMClientAPIService.Mapping
{
    public class SNMPHistoryMapping
    {
        public static async Task<IEnumerable<SNMPHistoryResponse>> DoMapping(IQueryable<Site> siteList,
            IQueryable<SnmpreceiverHistory> snmpReceiverList, int priority,
            int pageIndex, int pageSize, string trap,
            string sortField, string sortDirection)
        {
            if (siteList == null || snmpReceiverList == null)
            {
                return null;
            }

            var data = (from s in siteList
                        join rh in snmpReceiverList on s.Address equals rh.Ipaddress
                        where priority > 0 ? s.SitePriority == priority : true
                        && !string.IsNullOrEmpty(trap) ? rh.AlarmDescription.Contains(trap) : true
                        select new SNMPHistoryResponse()
                        {
                            AlarmDescription = rh.AlarmDescription,
                            EventType = rh.EventType,
                            OnOffStatus = rh.OnOffStatus,
                            ParentSiteName = TraceFullParentDescription(s.Parent),
                            ReceiveTime = rh.ReceiveTime,
                            RepeatCount = rh.RepeatCount,
                            SiteName = s.Description,
                            SitePriority = s.SitePriority,
                            Status = AlarmStatus.GetStatusDescription(rh.EventType),
                            Value = rh.Value
                        });

            dynamic result = null;
            if (sortDirection == "asc")
            {
                switch (sortField)
                {
                    case "Trap":
                        result = data.OrderBy(s => s.AlarmDescription).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    case "Value":
                        result = data.OrderBy(s => s.Value).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    case "Status":
                        result = data.OrderBy(s => s.Status).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    case "Site":
                        result = data.OrderBy(s => s.SiteName).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    case "ParentSiteName":
                        result = data.OrderBy(s => s.ParentSiteName).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    case "OnOffStatus":
                        result = data.OrderBy(s => s.OnOffStatus).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    case "RepeatCount":
                        result = data.OrderBy(s => s.RepeatCount).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    default:
                        result = data.OrderBy(s => s.ReceiveTime).Skip(pageIndex * pageSize).Take(pageSize);
                        break;
                }
            }
            else
            {
                switch (sortField)
                {
                    case "Trap":
                        result = data.OrderByDescending(s => s.AlarmDescription).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    case "Value":
                        result = data.OrderByDescending(s => s.Value).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    case "Status":
                        result = data.OrderByDescending(s => s.Status).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    case "Site":
                        result = data.OrderByDescending(s => s.SiteName).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    case "ParentSiteName":
                        result = data.OrderByDescending(s => s.ParentSiteName).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    case "OnOffStatus":
                        result = data.OrderByDescending(s => s.OnOffStatus).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    case "RepeatCount":
                        result = data.OrderByDescending(s => s.RepeatCount).Skip(pageIndex * pageSize).Take(pageSize);
                        break;

                    default:
                        result = data.OrderByDescending(s => s.ReceiveTime).Skip(pageIndex * pageSize).Take(pageSize);
                        break;
                }
            }

            return await Task.FromResult(result);
        }

        public static string TraceFullParentDescription(Site parentSite)
        {
            if (parentSite != null && parentSite.Id > 0)
            {
                var siteObj = parentSite;
                var fullDescOfSite = new StringBuilder(parentSite.Description);
                while (siteObj.Parent != null && siteObj.ParentId != null && siteObj.ParentId > 0)
                {
                    fullDescOfSite.Insert(0, string.Format("{0}/", siteObj.Parent.Description).ToString());
                    siteObj = siteObj.Parent;
                }

                return fullDescOfSite.ToString();
            }

            return string.Empty;
        }
    }
}
