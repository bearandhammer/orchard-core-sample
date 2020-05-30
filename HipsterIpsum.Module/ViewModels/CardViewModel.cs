namespace HipsterIpsum.Module.ViewModels
{
    /// <summary>
    /// Represents the data behind a Bootstrap Card within
    /// the HipsterIpsum.Module (Index View).
    /// </summary>
    public class CardViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardViewModel"/> class.
        /// </summary>
        /// <param name="number">The unique number associated with the Card.</param>
        /// <param name="content">The content of the Card.</param>
        public CardViewModel(int number, string content)
        {
            Number = number;
            Content = content;
        }

        /// <summary>
        /// Gets the unique number for the Card.
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// Gets the content of the Card.
        /// </summary>
        public string Content { get; }
    }
}
