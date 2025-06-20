using HandMadeCakes.Services;
using HandMadeCakes.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HandMadeCakes.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ICheckoutService _checkoutService;

        public CheckoutController(ICheckoutService checkoutService)
        {
            _checkoutService = checkoutService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new CheckoutViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(CheckoutViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            bool success = await _checkoutService.ProcessOrderAsync(model);

            if (success)
                return RedirectToAction("Success");
            else
            {
                ModelState.AddModelError("", "Failed to process your order. Your cart may be empty.");
                return View(model);
            }
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}