namespace JeffSum.Module.ViewModels
{
    /// <summary>
    /// A View Model for wrapping Jeff Goldblum Ipsum
    /// content rendered in the designated View/s.
    /// </summary>
    public class JeffIpsumViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JeffIpsumViewModel"/> class. Wraps
        /// Jeff Goldblum Ipsum content for general consumption.
        /// </summary>
        /// <param name="jeffIpsumContent">The paragraph content to render.</param>
        public JeffIpsumViewModel(string jeffIpsumContent) => JeffString = jeffIpsumContent;

        /// <summary>
        /// Gets access to the Jeff Goldblum Ipsum paragraph content.
        /// </summary>
        public string JeffString { get; }
    }
}
