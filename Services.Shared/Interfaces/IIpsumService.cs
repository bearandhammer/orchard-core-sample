using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Shared.Interfaces
{
    /// <summary>
    /// Represents a standard interface for al Ipsum-type services.
    /// </summary>
    public interface IIpsumService
    {
        /// <summary>
        /// Returns a set of Ipsum-based paragraphs
        /// from the service in scope.
        /// </summary>
        /// <param name="paragraphCount">The desired amount of paragraphs.</param>
        /// <returns>A string of Ipsum content.</returns>
        Task<List<string>> GetIpsumParagraphsAsync(int paragraphCount);
    }
}
