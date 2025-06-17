using HandMadeCakes.Dto;
using HandMadeCakes.Models;
using HandMadeCakes.Services.Cake;
using Microsoft.AspNetCore.Mvc;

namespace Cakeria1000Video.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeInterface _cakeInterface;

        public CakeController(ICakeInterface cakeInterface)
        {
            _cakeInterface = cakeInterface;
        }

        public async Task<IActionResult> Index()
        {
            var cakes = await _cakeInterface.GetCakes();
            return View(cakes);
        }

        public IActionResult Register()
        {
            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            var cake = await _cakeInterface.GetCakePorId(id);
            return View(cake);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var cake = await _cakeInterface.GetCakePorId(id);

            return View(cake);
        }

        public async Task<IActionResult> Remover(int id)
        {
            var Cake = await _cakeInterface.RemoverCake(id);
            return RedirectToAction("Index", "Cake");
        }


        [HttpPost]
        public async Task<IActionResult> Register(CakeCreateDto CakeCreateDto, IFormFile foto)
        {
            if (ModelState.IsValid)
            {
                var Cake = await _cakeInterface.CriarCake(CakeCreateDto, foto);
                return RedirectToAction("Index", "Cake");
            }
            else
            {
                return View(CakeCreateDto);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Editar(CakeModel CakeModel, IFormFile? foto)
        {
            if (ModelState.IsValid)
            {
                var Cake = await _cakeInterface.EditarCake(CakeModel, foto);
                return RedirectToAction("Index", "Cake");
            }
            else
            {
                return View(CakeModel);
            }
        }



    }
}