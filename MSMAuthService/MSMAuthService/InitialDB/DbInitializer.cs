namespace MSMAuthService.InitialDB
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    using MSMAuthService.Identity;

    /// <summary>
    /// DbInitializer class
    /// </summary>
    public static class DbInitializer
    {
        #region Methods

        /// <summary>
        /// Seeds the specified application builder.
        /// </summary>
        /// <param name="applicationBuilder">The application builder.</param>
        /// <param name="roleManager">The role manager.</param>
        /// <param name="userManager">The user manager.</param>
        public static void Seed(IApplicationBuilder app, RoleManager<AppIdentityRole> roleManager, UserManager<AppIdentityUser> userManager)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                AppIdentityDbContext context = serviceScope.ServiceProvider.GetService<AppIdentityDbContext>();
                context.SaveChanges();
                SeedRoles(roleManager);
                SeedUser(userManager);
            }
        }

        /// <summary>
        /// Seeds the roles.
        /// </summary>
        /// <param name="roleManager">The role manager.</param>
        public static void SeedRoles(RoleManager<AppIdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                AppIdentityRole role = new AppIdentityRole();
                role.Name = "Admin";
                role.Description = "Perform all the operations.";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Super User").Result)
            {
                AppIdentityRole role = new AppIdentityRole();
                role.Name = "Super User";
                role.Description = "Perform super user operations.";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("User").Result)
            {
                AppIdentityRole role = new AppIdentityRole();
                role.Name = "User";
                role.Description = "Perform user operations.";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Email").Result)
            {
                AppIdentityRole role = new AppIdentityRole();
                role.Name = "Email";
                role.Description = "Perform email role operations.";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }

        /// <summary>
        /// Seeds the user.
        /// </summary>
        /// <param name="userManager">The user manager.</param>
        public static void SeedUser(UserManager<AppIdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("admin").Result == null)
            {
                AppIdentityUser user = new AppIdentityUser();
                user.UserName = "admin";
                user.Email = "pham.thingoc@eltek.com";
                user.FriendlyName = "admin";
                user.CreatedDate = DateTime.Now;
                IdentityResult result = userManager.CreateAsync(user, "Admin123").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.Design.IDesignTimeDbContextFactory{MSMAuthService.Identity.AppIdentityDbContext}" />
    public class AppIdentityDbContextFactory : IDesignTimeDbContextFactory<AppIdentityDbContext>
    {
        /// <summary>
        /// Creates a new instance of a derived context.
        /// </summary>
        /// <param name="args">Arguments provided by the design-time service.</param>
        /// <returns>
        /// An instance of <typeparamref name="TContext" />.
        /// </returns>
        public AppIdentityDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppIdentityDbContext>();
            string connectionString = @"Data Source=.\\SQLEXPRESS;Initial Catalog=MSMMembership;integrated security=True;MultipleActiveResultSets=true";
            builder.UseSqlServer(connectionString);
            return new AppIdentityDbContext(builder.Options);
        }
    }
}