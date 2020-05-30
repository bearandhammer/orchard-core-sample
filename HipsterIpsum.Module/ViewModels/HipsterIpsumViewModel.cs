using System.Collections.Generic;
using System.Linq;

namespace HipsterIpsum.Module.ViewModels
{
    /// <summary>
    /// Represents a type that feeds the Index View for this module.
    /// </summary>
    public class HipsterIpsumViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HipsterIpsumViewModel"/> class.
        /// </summary>
        /// <param name="hipsterIpsumParagraphs">The paragraphs of Lorem Ipsum content in scope.</param>
        public HipsterIpsumViewModel(List<string> hipsterIpsumParagraphs)
        {
            // Configures 'CardViewModels' based on the provided paragraphs
            Cards = hipsterIpsumParagraphs.Select((paragraph, index) => new CardViewModel(index + 1, paragraph)).ToList();
        }

        /// <summary>
        /// Gets the 'Card' content for rendering in the View.
        /// </summary>
        public List<CardViewModel> Cards { get; }
    }
}
