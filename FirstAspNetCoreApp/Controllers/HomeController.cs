using Microsoft.AspNetCore.Mvc;

namespace FirstAspNetCoreApp.Controllers
{
    public class HomeController : Controller
    {
        //Action
        public IActionResult Index() 
        { 
            return View(); 
        }
        public IActionResult About() 
        { 
            return  View(); 
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Pricing() 
        {
            return View();
        }
        public IActionResult Faq() 
        {
            return View();
        }
    }
}
