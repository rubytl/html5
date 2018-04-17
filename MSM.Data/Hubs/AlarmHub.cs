using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;

namespace MSM.Data.Hubs
{
    public class AlarmHub : Hub
    {
        private readonly IAlarmRepository alarmRepo;

        public AlarmHub(IAlarmRepository repository)
        {
            this.alarmRepo = repository;
        }

        public async Task GetAlarms()
        {
            await Clients.All.InvokeAsync("GetAlarms", this.alarmRepo.GetAlarms());
        }
    }
}
