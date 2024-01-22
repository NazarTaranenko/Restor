using Microsoft.AspNetCore.Mvc;
using Restor.Models;

namespace Restor.Controllers
{
    public class Work : Controller

    {
        ApplicationContext db;
        public Work(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index(Employe employes)
        {
            db.Employees.Add(employes);
            await db.SaveChangesAsync();
            return View();

        }

    }
}
