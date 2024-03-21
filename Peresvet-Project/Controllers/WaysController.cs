using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Peresvet_Project.Controllers
{
    public class WaysController : Controller
    {
        // GET: WaysController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Designing()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Designing(string[] content)
        {
            string result = "";
            foreach (string name in content)
            {
                result = $"{result} {name}";
            }
            ViewBag.SuccessMessage = "Данные успешно отправлены!" + result;
            return View();
        }

        // GET: WaysController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WaysController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WaysController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WaysController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WaysController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WaysController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WaysController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
