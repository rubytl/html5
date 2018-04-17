using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.SignalR;
using MSM.Data.Hubs;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;
using TableDependency.Enums;
using TableDependency.EventArgs;
using TableDependency.SqlClient;

namespace MSM.Data.Dependencies
{
    public class MultisiteDBSubscription : IDatabaseSubscription
    {
        private bool disposedValue;
        private readonly IAlarmRepository alarmRepo;
        private readonly IHubContext<AlarmHub> hubContext;
        private SqlTableDependency<SnmpreceiverHistory> tableDependency;

        public MultisiteDBSubscription(IAlarmRepository repository, IHubContext<AlarmHub> hubContext)
        {
            alarmRepo = repository;
            this.hubContext = hubContext;
        }

        public void Configure(string connectionString)
        {
            tableDependency = new SqlTableDependency<SnmpreceiverHistory>(connectionString);
            tableDependency.OnChanged += Changed;
            tableDependency.OnError += TableDependency_OnError;
            tableDependency.Start();

            Console.WriteLine("Waiting for receiving notifications...");
        }

        private void TableDependency_OnError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine($"SqlTableDependency error: {e.Error.Message}");
        }

        private void Changed(object sender, RecordChangedEventArgs<SnmpreceiverHistory> e)
        {
            if (e.ChangeType != ChangeType.None)
            {
                hubContext.Clients.All.InvokeAsync("AlarmChanged", true);
            }
        }

        #region IDisposable

        ~MultisiteDBSubscription()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    tableDependency.Stop();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
