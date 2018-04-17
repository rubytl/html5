using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using MSM.Data.Dependencies;
using Microsoft.Extensions.DependencyInjection;

namespace MSMAuthService.Dependencies
{
    public static class UseSqlTableDependencyHelpers
    {
        public static void UseSqlTableDependency<T>(this IApplicationBuilder services, string connectionString) where T : IDatabaseSubscription
        {
            var serviceProvider = services.ApplicationServices;
            var subscription = serviceProvider.GetService<T>();
            subscription.Configure(connectionString);
        }
    }
}
