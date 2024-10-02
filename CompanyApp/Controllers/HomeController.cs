using Microsoft.AspNetCore.Mvc;
using CompanyApp.Models;
using System;

namespace CompanyApp.Controllers
{
    public class HomeController : Controller
    {
        // Метод для відображення інформації про компанію
        public IActionResult Index()
        {
            var company = new Company
            {
                Name = "Tech Innovations",          // Назва компанії
                Address = "1234 Innovation Way",    // Адреса
                EmployeeCount = 500,                // Кількість працівників
                Industry = "Software Development"   // Галузь
            };

            return View(company);  // Передаємо компанію у вигляд
        }
        public IActionResult RandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 101); // Число від 0 до 100

            return Content($"Random number: {randomNumber}"); // Повертаємо число у вигляді тексту
        }
    }
}
