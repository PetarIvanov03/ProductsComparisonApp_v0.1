using Microsoft.AspNetCore.Mvc;
using ProductComparisonApp.Data;
using ProductComparisonApp.Models;
using ProductComparisonApp.ViewModels;

namespace ProductComparisonApp.Controllers
{
    public class WebcamsController : Controller
    {
        public IActionResult Index(string sortBy = "Name")
        {
            var webcams = ProductDataGenerator.GetWebcams();

            webcams = sortBy switch
            {
                "Brand" => webcams.OrderBy(w => w.Brand).ToList(),
                "Price" => webcams.OrderBy(w => w.Price).ToList(),
                "Resolution" => webcams.OrderBy(w => w.Resolution).ToList(),
                "FPS" => webcams.OrderByDescending(w => w.FrameRateFps).ToList(),
                _ => webcams.OrderBy(w => w.Name).ToList()
            };

            var viewModel = new ProductComparisonViewModel<Webcam>
            {
                CategoryName = "Webcams",
                Products = webcams
            };

            return View(viewModel);
        }
    }

}
