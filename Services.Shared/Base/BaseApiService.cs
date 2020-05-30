using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Services.Shared.Base
{
    /// <summary>
    /// Abstract base class for all API-based services.
    /// </summary>
    public abstract class BaseApiService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApiService"/> class.
        /// Chains in relevant services as needed.
        /// </summary>
        /// <param name="configProvider">An <see cref="IConfiguration"/> type allowing access to application settings.</param>
        public BaseApiService(IConfiguration configProvider)
        {
            ConfigurationProvider = configProvider;
        }

        /// <summary>
        /// Gets access to application settings, as required by this
        /// class (future support) or any derived types.
        /// </summary>
        protected IConfiguration ConfigurationProvider { get; }

        /// <summary>
        /// Overridable method for making a simple API request (GET).
        /// </summary>
        /// <typeparam name="T">The type requested as a result of deserialization of response data.</typeparam>
        /// <param name="apiUrl">The API URL to call.</param>
        /// <returns>Deserialized response data as the requested type.</returns>
        protected virtual async Task<T> GetApiResultAsync<T>(string apiUrl)
        {
            T requestedReturnValue;

            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync(apiUrl);
                requestedReturnValue = JsonConvert.DeserializeObject<T>(response);
            }

            return requestedReturnValue;
        }
    }
}
