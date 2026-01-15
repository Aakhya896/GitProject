using Microsoft.AspNetCore.Mvc;

namespace GitProject.Controllers
{
    public class Items : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
