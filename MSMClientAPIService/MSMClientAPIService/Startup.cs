using System;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using MSM.Data.Dependencies;
using MSM.Data.Hubs;
using MSM.Data.Models;
using MSM.Data.Repositories;
using MSM.Data.Repositories.Interfaces;
using MSMClientAPIService.Dependencies;
using MSMClientAPIService.Extensions;
using MSMClientAPIService.Helpers;
using MSMClientAPIService.Services;

namespace MSMClientAPIService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private string connectionString;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            this.connectionString = Configuration.GetConnectionString("MultisiteDBEntities");

            // add framework services
            services.AddDbContextFactory<MultisiteDBEntitiesContext>(this.connectionString);

            // config jwtfactory and authenticatioin
            this.ConfigAuthentication(services);

            //// add identity
            //var builder = services.AddIdentityCore<Msmuser>(o =>
            //{
            //    // configure identity options
            //    o.Password.RequireDigit = false;
            //    o.Password.RequireLowercase = false;
            //    o.Password.RequireUppercase = false;
            //    o.Password.RequireNonAlphanumeric = false;
            //    o.Password.RequiredLength = 6;
            //});

            //builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), builder.Services);
            //builder.AddEntityFrameworkStores<MultisiteDBEntitiesContext>().AddDefaultTokenProviders();

            services.AddLogging();
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            services.AddMvc();
            services.AddSignalR();

            // add repositories
            this.AddDependencyInjection(services);
            this.AddTableDependencies(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddDebug().AddConsole();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<ErrorHandlerMiddleware>();
            app.UseAuthentication();
            app.UseCors("CorsPolicy");
            app.UseSignalR(routes =>
            {
                routes.MapHub<AlarmHub>("alarms");
            });

            app.UseMvc();

            app.UseSqlTableDependency<IDatabaseSubscription>(this.connectionString);
        }

        private void ConfigAuthentication(IServiceCollection services)
        {
            services.AddSingleton<IJwtFactory, JwtFactory>();

            // Get options from app settings
            var jwtAppSettingOptions = this.Configuration.GetSection(nameof(JwtIssuerOptions));

            string validFor = jwtAppSettingOptions[nameof(JwtIssuerOptions.ValidFor)];
            double dbValidFor;
            double.TryParse(validFor, out dbValidFor);

            // Configure JwtIssuerOptions
            services.Configure<JwtIssuerOptions>(options =>
            {
                options.Issuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                options.Audience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)];
                options.ValidFor = TimeSpan.FromMinutes(dbValidFor);
                options.SigningKey = jwtAppSettingOptions[nameof(JwtIssuerOptions.SigningKey)];
            });

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)],

                ValidateAudience = true,
                ValidAudience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)],

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtAppSettingOptions[nameof(JwtIssuerOptions.SigningKey)])),

                RequireExpirationTime = true,
                ValidateLifetime = true,
                //ClockSkew = TimeSpan.Zero
            };

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(configureOptions =>
                {
                    configureOptions.ClaimsIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                    configureOptions.TokenValidationParameters = tokenValidationParameters;
                    configureOptions.SaveToken = true;
                });
        }

        private void AddTableDependencies(IServiceCollection services)
        {
            // dependency injection
            services.AddSingleton<IDatabaseSubscription, MultisiteDBSubscription>();
            services.AddSingleton<IHubContext<AlarmHub>, HubContext<AlarmHub>>();
        }

        private void AddDependencyInjection(IServiceCollection services)
        {
            (new LoginHelper(this.Configuration)).RegisterTørkService();

            // services helper
            services.AddScoped<ISiteService, SiteService>();
            services.AddScoped<IAuthService, AuthService>();

            // repositories
            services.AddScoped<ISiteRepository, SiteRepository>();
            services.AddScoped<IUserMaintenanceRepository, UserMaintenanceRepository>();
            services.AddSingleton<IAlarmRepository, AlarmRepository>();
            services.AddScoped<ITemplateRepository, TemplateRepository>();
            services.AddScoped<ISnmpDataTemplateRepository, SnmpDataTemplateRepository>();
            services.AddScoped<ISnmpConfigTemplateRepository, SnmpConfigTemplateRepository>();
            services.AddScoped<INetworkDeviceRepository, NetworkDeviceRepository>();
            services.AddScoped<ISiteNotificationRepository, SiteNotificationRepository>();
        }
    }
}
