using Microsoft.AspNetCore.Mvc;

namespace AttendanceSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
