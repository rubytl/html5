using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MSM.Data.Models;
using System.Threading.Tasks;
using MSM.Data.Repositories.Interfaces;

namespace MSM.Data.Repositories
{
    /// <summary>
    /// The UserMaintenanceRepository class
    /// </summary>
    /// <seealso cref="MSM.Data.EntityBaseRepository{MSM.Data.Models.Msmuser}" />
    /// <seealso cref="MSM.Data.Repositories.Interfaces.IUserMaintenanceRepository" />
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
