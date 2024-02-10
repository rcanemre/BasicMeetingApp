using BasicMeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace BasicMeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(Userinfo model)
        {
            Repository.CreateUser(model);
            ViewBag.UserCount = Repository.Users.Where(i=> i.WillAttend == true).Count();
            return View("Thanks", model);
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
