using Microsoft.AspNetCore.Mvc;
using CompanyApp.Models;
using System;

namespace CompanyApp.Controllers
{
    public class HomeController : Controller
    {
        // ����� ��� ����������� ���������� ��� �������
        public IActionResult Index()
        {
            var company = new Company
            {
                Name = "Tech Innovations",          // ����� ������
                Address = "1234 Innovation Way",    // ������
                EmployeeCount = 500,                // ʳ������ ����������
                Industry = "Software Development"   // ������
            };

            return View(company);  // �������� ������� � ������
        }
        public IActionResult RandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 101); // ����� �� 0 �� 100

            return Content($"Random number: {randomNumber}"); // ��������� ����� � ������ ������
        }
    }
}
