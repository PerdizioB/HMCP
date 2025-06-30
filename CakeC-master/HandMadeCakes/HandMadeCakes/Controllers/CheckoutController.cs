using HandMadeCakes.Services;
using HandMadeCakes.Services.Checkout;
using HandMadeCakes.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CheckoutViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var success = await _checkoutService.ProcessOrderAsync(model);
            if (success)
                return RedirectToAction("Confirmation");

            ModelState.AddModelError("", "Order failed. Try again.");
            return View(model);
        }

        public IActionResult Confirmation()
        {
            return View();
        }
    }
}