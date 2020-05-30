using HipsterIpsum.Module.ViewModels;
using HipsterIpsum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HipsterIpsum.Module.Controllers
{
    /// <summary>
    /// A controller to feed any hipster-related Lorem Ipsum Views.
    /// </summary>
    [Route("GiveMeHipster")]
    public class HipsterController : Controller
    {
        /// <summary>
        /// Returns an <see cref="IActionResult"/> for rendering
        /// hipster-related Lorem Ipsum content to the appropriate View.
        /// </summary>
        /// <param name="dinoIpsumService">A service calling the relevant API to generate Lorem Ipsum content.</param>
        /// <returns>Hipster-related Lorem Ipsum content to the designated View (fixed to 3 paragraphs, in this instance).</returns>
        public async Task<IActionResult> Index([FromServices] IHipsterIpsumService hipsterIpsumService) =>
            View(new HipsterIpsumViewModel(await hipsterIpsumService.GetIpsumParagraphsAsync(3)));
    }
}
