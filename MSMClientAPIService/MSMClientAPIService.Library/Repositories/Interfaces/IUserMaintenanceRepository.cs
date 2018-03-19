﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MSMClientAPIService.Data.Models;

namespace MSMClientAPIService.Data.Repositories.Interfaces
{
    public interface IUserMaintenanceRepository:IEntityBaseRepository<Msmuser>
    {
        Task<CheckLoginResponse> CheckLogin(string userName, string password);
        Task<bool> GetUser(string userName);
    }
}