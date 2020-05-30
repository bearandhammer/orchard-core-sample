using JeffSum.Module.ViewModels;
using JeffSum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JeffSum.Module.Controllers
{
    /// <summary>
    /// A controller that exposes Jeff Goldblum
    /// style Ipsum content.
    /// </summary>
    [Route("GiveMeJeff")]
    public class JeffController : Controller
    {
        /// <summary>
        /// Returns an <see cref="IActionResult"/> for rendering
        /// Jeff Goldblum style Ipsum content to the appropriate View.
        /// </summary>
        /// <param name="jeffIpsumService">A service for 'receiving the Jeff'.</param>
        /// <returns>Jeff Goldblum Ipsum content to the designated View (fixed to 5 paragraphs, for example purposes).</returns>
        public async Task<IActionResult> Index([FromServices] IJeffIpsumService jeffIpsumService)
        {
            // Split paragraph content with new lines before passing into the View Model (for the View to consume)
            List<string> rawIpsumParagraphs = await jeffIpsumService.GetIpsumParagraphsAsync(5);
            string formattedIpsumParagraphContent = string.Join($"{ Environment.NewLine }{ Environment.NewLine }", rawIpsumParagraphs);

            return View(new JeffIpsumViewModel(formattedIpsumParagraphContent));
        }
    }
}
