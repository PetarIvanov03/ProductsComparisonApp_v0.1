using Microsoft.AspNetCore.Mvc;
using ProductComparisonApp.Data;
using ProductComparisonApp.Models;
using ProductComparisonApp.ViewModels;

namespace ProductComparisonApp.Controllers
{
    public class MonitorsController : Controller
    {
        public IActionResult Index(string sortBy = "Name")
        {
            var monitors = ProductDataGenerator.GetMonitors();

            monitors = sortBy switch
            {
                "Brand" => monitors.OrderBy(m => m.Brand).ToList(),
                "Price" => monitors.OrderBy(m => m.Price).ToList(),
                "Size" => monitors.OrderByDescending(m => m.ScreenSizeInches).ToList(),
                "Resolution" => monitors.OrderBy(m => m.Resolution).ToList(),
                "Refresh" => monitors.OrderByDescending(m => m.RefreshRateHz).ToList(),
                _ => monitors.OrderBy(m => m.Name).ToList()
            };

            var viewModel = new ProductComparisonViewModel<Models.Monitor>
            {
                CategoryName = "Monitors",
                Products = monitors
            };

            return View(viewModel);
        }
    }

}
