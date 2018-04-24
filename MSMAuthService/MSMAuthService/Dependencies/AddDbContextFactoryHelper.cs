using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MSMAuthService.Identity;

namespace MSMAuthService.Dependencies
{
    public static class AddDbContextFactoryHelper
    {
        public static void AddDbContextFactory<TDataContext>(this IServiceCollection services, string connectionString) where TDataContext : IdentityDbContext<AppIdentityUser, AppIdentityRole, string>
        {
            services.AddSingleton<Func<TDataContext>>((ctx) =>
            {
                var options = new DbContextOptionsBuilder<TDataContext>()
                    .UseSqlServer(connectionString)
                    .Options;

                return () => (TDataContext)Activator.CreateInstance(typeof(TDataContext), options);
            });
        }
    }
}
