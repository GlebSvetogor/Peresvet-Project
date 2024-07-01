using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Peresvet_Project.Controllers
{
    public class HelpController : Controller
    {
        // GET: HelpController
        public ActionResult Index()
        {
            return View();
        }

    }
}
