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
            if(ModelState.IsValid)
            {
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
                return View("Thanks", model);
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult List()
        {
            var users = Repository.Users;
            return View(users);
        }

        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}
