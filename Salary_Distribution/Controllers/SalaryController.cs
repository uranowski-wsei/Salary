using Microsoft.AspNetCore.Mvc;
using Salary_Distribution.Entities;
using Salary_Distribution.Models;
using System.Collections.Generic;
using System.Linq;

namespace Salary_Distribution.Controllers
{
    public class SalaryController : Controller
    {
        private readonly EmployeesDbContext _dbContext;

        public SalaryController(EmployeesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Description()
        {
            return View("Description");
        }

        public IActionResult Employees()
        {
            List<Employees> employeesEntities = _dbContext.Employees.ToList<Employees>();
            List<EmployeesModel> employees = new List<EmployeesModel>();

            foreach (Employees employeeEntity in employeesEntities)
            {
                employees.Add(new EmployeesModel
                {
                    Name = employeeEntity.Name,
                    Surname = employeeEntity.Surname,
                    Foreman = employeeEntity.Foreman,
                    Salary = employeeEntity.Salary
                });
            }

            return View(employees);
        }

        public IActionResult Salaries ()
        {
            return View("Salaries");
        }
    }
}
