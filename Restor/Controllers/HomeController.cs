using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restor.Models;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace Restor.Controllers
{
    public class HomeController : Controller
    {
        

        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;

            if (!db.Meals.Any())
            {
                Meal meal1 = new Meal { Name = "Чізбургер",Type="Бургери", Description = "Біфштекс із натуральної яловичини, " +
                "шматочок сиру “Чеддер”, шматочок маринованого огірка та цибуля, заправлені гірчицею і кетчупом, " +
                "у булочці з пшеничного борошна.", Srcimg = "/Cheaseburger.png", Cost ="80 грн." };
            Meal meal2 = new Meal {  Name = "Біг тесті",Type="Бургери", Description = "Натуральна яловичина у поєднанні зі" +
                " свіжими овочами та плавленим сиром “Емменталь”", Srcimg = "/BigTesti.png", Cost = "120 грн."};
                 Meal meal3 = new Meal {  Name = "Нагетси", Type="Снеки", Description = "Апетитні шматочки ніжного курячого філе, засмажені у хрумкій паніровці",
                     Srcimg = "/Nagets.png", Cost = "200 грн."};
                 Meal meal4 = new Meal {  Name = "Борщ", Type="Перші страви", Description = "Основними інгредієнтами  є буряк, картопля, морква, цибуля, капуста і м'ясо",
                     Srcimg = "/Borshpng.png", Cost = "110 грн."};
                Meal meal5 = new Meal {  Name = "Картопля фрі", Type="Другі страви", Description = "Добірна картопля, засмажена в натуральній олії і трохи підсолена",
                     Srcimg = "/Kartoshka.png", Cost = "90 грн."};
                Meal meal6 = new Meal {  Name = "Морозиво ріжок", Type="Десерти", Description = "Морозиво, приготоване з добірної молочної суміші, у хрусткому стаканчику.",
                     Srcimg = "/Morozivo.png", Cost = "50 грн."};
                db.Meals.AddRange(meal1,meal2,meal3, meal4, meal5, meal6);
                db.SaveChanges();
            }
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Index()
        {
            
            var data = db.Meals.Take(2).ToList();  
            return View(data);
        }
    }
}