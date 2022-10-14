using Microsoft.AspNetCore.Mvc;

namespace TigerStaplers.Controllers
{
    public class StaplersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
