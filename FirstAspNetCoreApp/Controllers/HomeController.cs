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
    }
}
