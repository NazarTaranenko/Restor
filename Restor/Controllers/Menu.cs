using Microsoft.AspNetCore.Mvc;
using Restor.Models;

namespace Restor.Controllers
{
    public class Menu : Controller

    {
        ApplicationContext db;
        public Menu(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = db.Meals;
            return View(data);
            
        }
        public ActionResult AddCust(Meal meals) {

            return RedirectToAction("Index", "Work", meals.Id);
        }

    }
}
