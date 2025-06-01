using Microsoft.AspNetCore.Mvc;
using ProductComparisonApp.Data;
using ProductComparisonApp.Models;
using ProductComparisonApp.ViewModels;

namespace ProductComparisonApp.Controllers
{
    public class MiceController : Controller
    {
        public IActionResult Index(string sortBy = "Name")
        {
            var mice = ProductDataGenerator.GetMice();

            mice = sortBy switch
            {
                "Brand" => mice.OrderBy(m => m.Brand).ToList(),
                "Price" => mice.OrderBy(m => m.Price).ToList(),
                "Wireless" => mice.OrderByDescending(m => m.IsWireless).ToList(),
                "Connection" => mice.OrderBy(m => m.ConnectionType).ToList(),
                "DPI" => mice.OrderByDescending(m => m.DPI).ToList(),
                "Buttons" => mice.OrderByDescending(m => m.ButtonCount).ToList(),
                "Weight" => mice.OrderBy(m => m.WeightGrams).ToList(),
                _ => mice.OrderBy(m => m.Name).ToList()
            };

            var viewModel = new ProductComparisonViewModel<Mouse>
            {
                CategoryName = "Mice",
                Products = mice
            };

            return View(viewModel);
        }
    }

}
