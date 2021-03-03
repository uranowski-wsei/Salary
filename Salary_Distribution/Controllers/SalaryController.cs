using Microsoft.AspNetCore.Mvc;
using Salary_Distribution.Models;
using System.Collections.Generic;

namespace Salary_Distribution.Controllers
{
    public class SalaryController : Controller
    {
        [HttpGet]
        public IActionResult Description()
        {
            return View("Description");
        }

        [HttpGet]
        public IActionResult Employees()
        {
            return View("Employees");
        }

        public IActionResult ListPeople()
        {
            List<EmploeesModel> people = new List<EmploeesModel>();

            people.Add(new EmploeesModel { Name = "Test", Surname = "Test", Salary = 10, Foreman = true });

            return View(people);
        }

        [HttpGet]
        public IActionResult Salaries ()
        {
            return View("Salaries");
        }
    }
}
