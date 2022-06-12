using Microsoft.AspNetCore.Mvc;

namespace DietaFacil.Controllers
{
    public class MeusAlimentosController : Controller
    {
        public IActionResult CadastrarAlimento()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
