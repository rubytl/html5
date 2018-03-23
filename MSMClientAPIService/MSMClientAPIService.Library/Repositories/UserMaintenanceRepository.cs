using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MSMClientAPIService.Data.Models;
using System.Threading.Tasks;
using MSMClientAPIService.Data.Repositories.Interfaces;

namespace MSMClientAPIService.Data.Repositories
{
    /// <summary>
    /// The UserMaintenanceRepository class
    /// </summary>
    /// <seealso cref="MSMClientAPIService.Data.EntityBaseRepository{MSMClientAPIService.Data.Models.Msmuser}" />
    /// <seealso cref="MSMClientAPIService.Data.Repositories.Interfaces.IUserMaintenanceRepository" />
    public class UserMaintenanceRepository : EntityBaseRepository<Msmuser>, IUserMaintenanceRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMaintenanceRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UserMaintenanceRepository(MultisiteDBEntitiesContext context)
            : base(context)
        { }     
    }
}
