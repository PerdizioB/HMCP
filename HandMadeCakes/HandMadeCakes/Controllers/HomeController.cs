using HandMadeCakes.Models;
using HandMadeCakes.Services.Cake;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Diagnostics;

namespace HandMadeCakes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICakeInterface _CakeInterface;
        private readonly ILogger<HomeController> _logger;

        //construtor
        public HomeController(ILogger<HomeController> logger,ICakeInterface CakeInterface)
        {
            
          _CakeInterface = CakeInterface;
            _logger = logger;

        }

        public async Task<IActionResult> Index(string? pesquisar)
        {
            if (pesquisar == null)
            {
                var cakes = await _CakeInterface.GetCakes();
                return View(cakes);
            }
            else
            {
                var cakes = await _CakeInterface.GetCakesFiltro(pesquisar);
                return View(cakes);
            }

        }

        





        public IActionResult Login()
        {
          
            return View();
        }

        




        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }


}