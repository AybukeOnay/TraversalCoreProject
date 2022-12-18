using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
