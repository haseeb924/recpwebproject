using HomeRecipewebproject.Models;
using Microsoft.AspNetCore.Mvc;
using HomeRecipewebproject.Data;
using System.Diagnostics;
namespace HomeRecipewebproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbcontext _appDbcontext;
        public HomeController(ILogger<HomeController> logger, AppDbcontext appDbcontext)
        {
            _logger = logger;
            _appDbcontext = appDbcontext;
        }

        public IActionResult Index()
        {
            ViewBag.Dis = "DISCOVER HOME NEW FLAVORS";
            return View();
        }
        public IActionResult About()
        {
           
            return View();
        }
        public IActionResult Ingredients()
        {
            
            return View();
        }
        public IActionResult Contact()
        {

            return View();
        }
        
        public IActionResult Addingproduct(Add add)
        {
            if (ModelState.IsValid)
            {
                _appDbcontext.Adding.Add(add);
                _appDbcontext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(add);
        }

    }
}
