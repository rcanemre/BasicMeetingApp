using BasicMeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.selamlama = saat > 12 ? "İyi Günler" : "Günaydın";

            int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();

            var MeetingInfo = new Meetinginfo()
            {
                Id = 1,
                Location = "Istanbul, Abc Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount,
            };

            return View(MeetingInfo);
        }
    }
}
