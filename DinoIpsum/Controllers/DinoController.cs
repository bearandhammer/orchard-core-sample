using DinoIpsum.Module.ViewModels;
using DinoIpsum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DinoIpsum.Module.Controllers
{
    /// <summary>
    /// A controller to feed any dino-related Lorem Ipsum Views.
    /// </summary>
    [Route("GiveMeDino")]
    public class DinoController : Controller
    {
        /// <summary>
        /// Returns an <see cref="IActionResult"/> for rendering
        /// dino-related Lorem Ipsum content to the appropriate View.
        /// </summary>
        /// <param name="dinoIpsumService">A service calling the relevant API to generate Lorem Ipsum content.</param>
        /// <returns>Dino-related Lorem Ipsum content to the designated View (fixed to 3 paragraphs, in this instance).</returns>
        public async Task<IActionResult> Index([FromServices] IDinoIpsumService dinoIpsumService) =>
            View(new DinoIpsumViewModel(await dinoIpsumService.GetIpsumParagraphsAsync(3)));
    }
}
