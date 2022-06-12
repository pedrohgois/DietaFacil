using Microsoft.AspNetCore.Mvc;

namespace DietaFacil.Controllers
{
    public class DietaFacilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
