using Microsoft.AspNetCore.Mvc;
using Restor.Models;

namespace Restor.Controllers
{
    public class Order : Controller

    {
        ApplicationContext db;
        public Order(ApplicationContext context)
        {
            db = context;
        }
    
        public async Task<IActionResult> Index(Customer customers )
        {
            db.Customers.Add(customers);
            await db.SaveChangesAsync();
            return View();

        }
    }
}