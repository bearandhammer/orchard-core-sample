using HipsterIpsum.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Modules.Shared.Configuration;
using Services.Shared.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HipsterIpsum.Services
{
    /// <summary>
    /// An implementation of the <see cref="IHipsterIpsumService"/> interface for
    /// retrieving hipster-related Lorem Ipsum content.
    /// </summary>
    public class HipsterIpsumService : BaseApiService, IHipsterIpsumService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HipsterIpsumService"/> class.
        /// Chains in relevant services as needed.
        /// </summary>
        /// <param name="configProvider">An <see cref="IConfiguration"/> type allowing access to application settings - passed to the base class.</param>
        public HipsterIpsumService(IConfiguration configProvider)
            : base(configProvider)
        {
        }

        /// <summary>
        /// Gets the desired amount of paragraphs of hipster-related
        /// Lorem Ipsum content from the API specified.
        /// </summary>
        /// <param name="paragraphCount">The amount of paragraphs of content to generate.</param>
        /// <returns>A <see cref="List{string}"/> holding the generated Lorem Ipsum content.</returns>
        public async Task<List<string>> GetIpsumParagraphsAsync(int paragraphCount)
        {
            string apiUrl = string.Format(ConfigurationProvider.GetSection(ConfigurationKeys.ApiConfig).Get<ApiConfiguration>().HipsterIpsumApiUrl, paragraphCount);

            return await GetApiResultAsync<List<string>>(apiUrl);
        }
    }
}
