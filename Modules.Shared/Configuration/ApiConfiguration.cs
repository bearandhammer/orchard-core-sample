namespace Modules.Shared.Configuration
{
    /// <summary>
    /// Utility class housing properties relating to application configuration.
    /// </summary>
    public class ApiConfiguration
    {
        /// <summary>
        /// Gets or sets the 'Hipster Ipsum' API URL.
        /// </summary>
        public string HipsterIpsumApiUrl { get; set; }

        /// <summary>
        /// Gets or sets the 'Dino Ipsum' API URL.
        /// </summary>
        public string DinoIpsumApiUrl { get; set; }
    }
}
