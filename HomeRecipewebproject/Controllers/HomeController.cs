using HomeRecipewebproject.Models;
using Microsoft.AspNetCore.Mvc;
using HomeRecipewebproject.Data;
using System.Diagnostics;
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

            return View();
        }

    }
}
