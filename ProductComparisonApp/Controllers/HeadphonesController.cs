using Microsoft.AspNetCore.Mvc;
using ProductComparisonApp.Data;
using ProductComparisonApp.Models;
using ProductComparisonApp.ViewModels;

namespace ProductComparisonApp.Controllers
{
    public class HeadphonesController : Controller
    {
        public IActionResult Index(string sortBy = "Name")
        {
            var headphones = ProductDataGenerator.GetHeadphones();

            headphones = sortBy switch
            {
                "Brand" => headphones.OrderBy(h => h.Brand).ToList(),
                "Price" => headphones.OrderBy(h => h.Price).ToList(),
                "Wireless" => headphones.OrderByDescending(h => h.IsWireless).ToList(),
                "Connection" => headphones.OrderBy(h => h.ConnectionType).ToList(),
                "Battery" => headphones.OrderByDescending(h => h.BatteryLifeHours).ToList(),
                "Noise" => headphones.OrderByDescending(h => h.HasNoiseCancelling).ToList(),
                "Microphone" => headphones.OrderByDescending(h => h.HasMicrophone).ToList(),
                "Driver" => headphones.OrderBy(h => h.DriverSize).ToList(),
                "Impedance" => headphones.OrderBy(h => h.Impedance).ToList(),
                "Weight" => headphones.OrderBy(h => h.WeightGrams).ToList(),
                _ => headphones.OrderBy(h => h.Name).ToList(),
            };

            var viewModel = new ProductComparisonViewModel<Headphones>
            {
                CategoryName = "Headphones",
                Products = headphones
            };

            return View(viewModel);
        }

    }
}
