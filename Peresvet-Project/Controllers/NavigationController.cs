using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Peresvet_Project.Controllers
{
    public class NavigationController : Controller
    {
        // GET: NavigationController

        public IActionResult MakeRequest()
        {
            return View();
        }

        public IActionResult PaidConsultation()
        {
            return View();
        }

        public IActionResult Price()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }


    }
}
