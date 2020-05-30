using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Ipsum.Generator.Web
{
    /// <summary>
    /// Stock configuration, out of the box, for a Startup
    /// file for a general web application.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// Represents the out of the box configuration.
        /// </summary>
        /// <param name="configuration">An <see cref="IConfiguration"/> type for accessing application settings.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Gets access to applications settings, as needed.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">An <see cref="IServiceCollection"/> type ready to gather up registered dependencies.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            // Add the MVC 'flavour' of Orchard Core
            services.AddOrchardCore().AddMvc();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">Allows alterations to the application's request pipeline.</param>
        /// <param name="env">Allows access to the web hosting environment the application is running on.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            // Configure the application to be a modular, Orchard application
            app.UseOrchardCore();
        }
    }
}
