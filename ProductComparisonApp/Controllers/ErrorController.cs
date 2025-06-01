using Microsoft.AspNetCore.Mvc;

namespace ProductComparisonApp.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            ViewBag.StatusCode = statusCode;
            return View("ErrorPage");
        }

        [Route("Error")]
        public IActionResult GeneralError()
        {
            return View("ErrorPage");
        }
    }
}
