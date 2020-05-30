using Jeffsum;
using JeffSum.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeffSum.Services
{
    /// <summary>
    /// Represents a service that provides Jeff Goldlum
    /// style Ipsum content.
    /// </summary>
    public class JeffIpsumService : IJeffIpsumService
    {
        /// <summary>
        /// Gets the desired amount of paragraphs of Jeff-related
        /// Lorem Ipsum content from 'JeffSum' library.
        /// </summary>
        /// <param name="paragraphCount">The amount of paragraphs of content to generate.</param>
        /// <returns>A <see cref="List{string}"/> holding the generated Lorem Ipsum content.</returns>
        public async Task<List<string>> GetIpsumParagraphsAsync(int paragraphCount) => await Task.Run(() => Goldblum.ReceiveTheJeff(paragraphCount).ToList());
    }
}
