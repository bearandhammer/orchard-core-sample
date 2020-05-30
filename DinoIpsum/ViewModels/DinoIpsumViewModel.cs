using System.Collections.Generic;

namespace DinoIpsum.Module.ViewModels
{
    /// <summary>
    /// Represents a type that feeds the Index View for this module.
    /// </summary>
    public class DinoIpsumViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DinoIpsumViewModel"/> class.
        /// </summary>
        /// <param name="dinoIpsumParagraphs">The paragraphs of Lorem Ipsum content in scope.</param>
        public DinoIpsumViewModel(List<string> dinoIpsumParagraphs)
        {
            DinoParagraphs = dinoIpsumParagraphs;
        }

        /// <summary>
        /// Gets the Lorem Ipsum content
        /// in scope to render in the View.
        /// </summary>
        public List<string> DinoParagraphs { get; }
    }
}
