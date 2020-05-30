using DinoIpsum.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Modules.Shared.Configuration;
using Services.Shared.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinoIpsum.Services
{
    /// <summary>
    /// An implementation of the <see cref="IDinoIpsumService"/> interface for
    /// retrieving dino-related Lorem Ipsum content.
    /// </summary>
    public class DinoIpsumService : BaseApiService, IDinoIpsumService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DinoIpsumService"/> class.
        /// Chains in relevant services as needed.
        /// </summary>
        /// <param name="configProvider">An <see cref="IConfiguration"/> type allowing access to application settings - passed to the base class.</param>
        public DinoIpsumService(IConfiguration configProvider)
            : base(configProvider)
        {
        }

        /// <summary>
        /// Gets the desired amount of paragraphs of dino-related
        /// Lorem Ipsum content from the API specified.
        /// </summary>
        /// <param name="paragraphCount">The amount of paragraphs of content to generate.</param>
        /// <returns>A <see cref="List{string}"/> holding the generated Lorem Ipsum content.</returns>
        public async Task<List<string>> GetIpsumParagraphsAsync(int paragraphCount)
        {
            string apiUrl = string.Format(ConfigurationProvider.GetSection(ConfigurationKeys.ApiConfig).Get<ApiConfiguration>().DinoIpsumApiUrl, paragraphCount);

            List<List<string>> generatedParagraphs = await GetApiResultAsync<List<List<string>>>(apiUrl);

            // Here, content comes from the API as an array of arrays, so carefully manipulate the content using string.Join for flat lists
            return generatedParagraphs.Select(gp => string.Join(" ", gp)).ToList();
        }
    }
}
