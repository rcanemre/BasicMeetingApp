using Microsoft.AspNetCore.Mvc;

namespace BasicMeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
