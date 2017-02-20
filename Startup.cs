using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PlanMySave.Repository;
using PlanMySave.Service;
using Microsoft.EntityFrameworkCore;

namespace PlanMySave
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            services.AddApiVersioning();
            services.AddDbContext<PlanMySaveContext>(optionsAction => optionsAction.UseInMemoryDatabase());

            this.ConfigureRepository(services);
            this.ConfigureService(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }

        #region DataAccess configuration

        /// <summary>
        /// Add repositories to the container
        /// </summary>
        /// <param name="services"></param>
        private void ConfigureRepository(IServiceCollection services)
        {
            services.AddScoped<IRevenuRepository, RevenuRepository>();
        }

        #endregion

        #region Services configuration

        /// <summary>
        /// Is used to add services to the container
        /// </summary>
        private void ConfigureService(IServiceCollection services)
        {
            services.AddTransient<IRevenuService, RevenuService>();
        }
        #endregion
    }
}
