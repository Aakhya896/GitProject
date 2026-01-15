using Microsoft.AspNetCore.Mvc;

namespace GitProject.Models.Newfolder
{
    public class Model : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
