using Microsoft.AspNetCore.Mvc;
using ProductComparisonApp.Data;
using ProductComparisonApp.Models;
using ProductComparisonApp.ViewModels;

namespace ProductComparisonApp.Controllers
{
    public class MicrophonesController : Controller
    {
        public IActionResult Index(string sortBy = "Name")
        {
            var mics = ProductDataGenerator.GetMicrophones();

            mics = sortBy switch
            {
                "Brand" => mics.OrderBy(m => m.Brand).ToList(),
                "Price" => mics.OrderBy(m => m.Price).ToList(),
                "Type" => mics.OrderBy(m => m.MicrophoneType).ToList(),
                "Wireless" => mics.OrderByDescending(m => m.IsWireless).ToList(),
                _ => mics.OrderBy(m => m.Name).ToList()
            };

            var viewModel = new ProductComparisonViewModel<Microphone>
            {
                CategoryName = "Microphones",
                Products = mics
            };

            return View(viewModel);
        }
    }

}
