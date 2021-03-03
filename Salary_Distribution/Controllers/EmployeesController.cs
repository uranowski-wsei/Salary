using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Salary_Distribution.Models;

namespace Salary_Distribution.Controllers
{
    public class EmployeesController : Controller

    {
        public IActionResult Employees()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<EmploeesModel> people = new List<EmploeesModel>();

            people.Add(new EmploeesModel { Name = "Test", Surname = "Test", Salary = 10, Foreman = true });

            return View(people);
        }


    }
}
