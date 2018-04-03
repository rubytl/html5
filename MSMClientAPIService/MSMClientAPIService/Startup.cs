using System;
using System.Net;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using MSMClientAPIService.Data.Models;
using MSMClientAPIService.Data.Repositories;
using MSMClientAPIService.Data.Repositories.Interfaces;
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

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // add framework services
            services.AddDbContext<MultisiteDBEntitiesContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MultisiteDBEntities")));

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

            // add repositories
            this.AddRepositories(services);
            services.AddLogging();
            services.AddCors();
            services.AddMvc();
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
            app.UseCors(builder =>
                            builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod());
            app.UseMvc();
        }

        private void ConfigAuthentication(IServiceCollection services)
        {
            services.AddSingleton<IJwtFactory, JwtFactory>();

            services.AddScoped<IAuthService, AuthService>();

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

            services.AddAutoMapper();
        }

        private void AddRepositories(IServiceCollection services)
        {
            (new LoginHelper(this.Configuration)).RegisterTørkService();
            services.AddScoped<ISiteRepository, SiteRepository>();
            services.AddScoped<IUserMaintenanceRepository, UserMaintenanceRepository>();
            services.AddScoped<IAlarmRepository, AlarmRepository>();
        }
    }
}
