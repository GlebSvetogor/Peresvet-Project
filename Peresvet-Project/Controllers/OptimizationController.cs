using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Peresvet_Project.Controllers
{
    public class OptimizationController : Controller
    {
        // GET: OptimizationController
       public ActionResult Design()
       {
            return View();
       }

        public ActionResult Installation()
        {
            return View();
        }

        public ActionResult Systems()
        {
            return View(); 
        }
    }
}
