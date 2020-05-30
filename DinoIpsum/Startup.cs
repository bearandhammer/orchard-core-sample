using DinoIpsum.Services;
using DinoIpsum.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DinoIpsum
{
    /// <summary>
    /// Core class that sets up the module for use.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Configures dependencies (such as services) for use throughout the module, as
        /// injected entities, for example.
        /// </summary>
        /// <param name="services">An <see cref="IServiceCollection"/> type ready to gather up registered dependencies.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDinoIpsumService, DinoIpsumService>();
        }
    }
}
