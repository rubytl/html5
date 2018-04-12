using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSM.Data.Repositories.Interfaces;
using MSMClientAPIService.Helpers;
using MSMClientAPIService.Mapping;
using MSMClientAPIService.Models;
using MSMHelpers;

namespace MSMClientAPIService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class AlarmController : Controller
    {
        private readonly IAlarmRepository alarmRepo;
        private readonly ISiteRepository siteRepo;
        public AlarmController(IAlarmRepository alarmRepo, ISiteRepository siteRepo)
        {
            this.alarmRepo = alarmRepo;
            this.siteRepo = siteRepo;
        }

        [HttpPost("filter")]
        public async Task<IActionResult> FilterAlarm([FromBody] AlarmRequest alarmRequest)
        {
            var snmpReciverList = await this.alarmRepo.GetFilteredSNMPReceiverHistory(AlarmStatus.GetStatusCode(alarmRequest.StatusCode), alarmRequest.FromDate, alarmRequest.ToDate, alarmRequest.MaxAlarmID);
            var siteList = await this.siteRepo.GetSiteListFiltered(int.Parse(alarmRequest.Filter), alarmRequest.SiteName);

            int priority = alarmRequest.Priority.Equals("All", StringComparison.InvariantCultureIgnoreCase) ? 0 : int.Parse(alarmRequest.Priority);
            return Ok(await SNMPHistoryMapping.DoMapping(siteList, snmpReciverList,
                priority, alarmRequest.PageIndex, alarmRequest.PageSize, alarmRequest.Trap,
                alarmRequest.SortField, alarmRequest.SortDirection));
        }
    }
}