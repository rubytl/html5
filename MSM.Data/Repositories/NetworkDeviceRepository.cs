using System;
using System.Collections.Generic;
using System.Text;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;

namespace MSM.Data.Repositories
{
    public class NetworkDeviceRepository : EntityBaseRepository<NetworkDevice>, INetworkDeviceRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkDeviceRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public NetworkDeviceRepository(Func<MultisiteDBEntitiesContext> context)
            : base(context)
        { }
    }
}
