using Microsoft.AspNetCore.Mvc;
using ProductComparisonApp.Data;
using ProductComparisonApp.Models;
using ProductComparisonApp.ViewModels;

namespace ProductComparisonApp.Controllers
{
    public class KeyboardsController : Controller
    {
        public IActionResult Index(string sortBy = "Name")
        {
            var keyboards = ProductDataGenerator.GetKeyboards();

            keyboards = sortBy switch
            {
                "Brand" => keyboards.OrderBy(k => k.Brand).ToList(),
                "Price" => keyboards.OrderBy(k => k.Price).ToList(),
                "Wireless" => keyboards.OrderByDescending(k => k.IsWireless).ToList(),
                "Layout" => keyboards.OrderBy(k => k.Layout).ToList(),
                "Switch" => keyboards.OrderBy(k => k.SwitchType).ToList(),
                "Weight" => keyboards.OrderBy(k => k.WeightGrams).ToList(),
                _ => keyboards.OrderBy(k => k.Name).ToList()
            };

            var viewModel = new ProductComparisonViewModel<Keyboard>
            {
                CategoryName = "Keyboards",
                Products = keyboards
            };

            return View(viewModel);
        }
    }

}
