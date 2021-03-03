using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Salary_Distribution.Entities;
using Salary_Distribution.Models;

namespace Salary_Distribution.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesAsyncController : Controller

    {
        private readonly EmployeesDbContext _dbContext;

        public EmployeesAsyncController(EmployeesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("add")]
        public ResponseModel AddEmployee(EmployeesModel newEmployee)
        {
            Employees employeeEntity = new Employees
            {
                Name = newEmployee.Name,
                Surname = newEmployee.Surname,
                Foreman = newEmployee.Foreman,
                Salary = newEmployee.Salary
            };

            _dbContext.Employees.Add(employeeEntity);
            _dbContext.SaveChanges();

            return new ResponseModel
            {
                Message = "Pracownik został dodany"
            };
        }

        [HttpGet("get")]
        public List<EmployeesModel> GetEmployees()
        {
            List<Employees> employeesEntities = _dbContext.Employees.ToList<Employees>();
            List<EmployeesModel> employees = new List<EmployeesModel>();

            foreach(Employees employeeEntity in employeesEntities)
            {
                employees.Add(new EmployeesModel
                {
                    Name = employeeEntity.Name,
                    Surname = employeeEntity.Surname,
                    Foreman = employeeEntity.Foreman,
                    Salary = employeeEntity.Salary
                });
            }

            return employees;
        }
    }
}
