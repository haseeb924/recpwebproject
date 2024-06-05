using Microsoft.AspNetCore.Mvc;

namespace HomeRecipewebproject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Recipes()
        {
            return View();
        }
    }
}
