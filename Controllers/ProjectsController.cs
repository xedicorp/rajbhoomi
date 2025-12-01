using Microsoft.AspNetCore.Mvc;

namespace Rajbhoomi.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Project1()
        {
            return View();
        }
    }
}
