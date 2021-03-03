using Microsoft.AspNetCore.Mvc;
using Salary_Distribution.Entities;
using Salary_Distribution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Salary_Distribution.Models.SalariesModel;

namespace Salary_Distribution.Controllers
{
    [ApiController]
    [Route("api/salary")]
    public class SalaryAsyncController : Controller
    {
        private readonly EmployeesDbContext _dbContext;

        public SalaryAsyncController(EmployeesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("getWorkingTime")]
        public WorkingTimeResponseModel GetWorkingTime([FromQuery(Name = "workTime")] WorkTime workTime)
        {
            int workTimeNumber;

            switch (workTime)
            {
                case WorkTime.Styczen:
                case WorkTime.Maj:
                    workTimeNumber = 152;
                    break;

                case WorkTime.Luty:
                case WorkTime.Listopad:
                    workTimeNumber = 160;
                    break;

                case WorkTime.Kwiecien:
                case WorkTime.Czerwiec:
                case WorkTime.Pazdziernik:
                    workTimeNumber = 168;
                    break;

                case WorkTime.Lipiec:
                case WorkTime.Sierpien:
                case WorkTime.Wrzesien:
                case WorkTime.Grudzien:
                    workTimeNumber = 176;
                    break;

                case WorkTime.Marzec:
                    workTimeNumber = 184;
                    break;

                default:
                    workTimeNumber = 0;
                    break;
            }

            return new WorkingTimeResponseModel
            {
                WorkingTime = workTimeNumber
            };
        }

        [HttpPost("savePlan")]
        public ResponseModel SaveSalaryPlan(SalaryPlanModel salaryPlanModel)
        {
            try
            {
                SalaryPlan salaryPlan = _dbContext.SalaryPlans.First(plan => plan.MonthIndex == (int)salaryPlanModel.WorkTime);
                salaryPlan.Budget = salaryPlanModel.Budget;

                _dbContext.SaveChanges();

                return new ResponseModel
                {
                    Message = "Edytowano plan wypłat na ten miesiąc!"
                };
            }
            catch (InvalidOperationException exception)
            {
                _dbContext.SalaryPlans.Add(new SalaryPlan
                {
                    Budget = salaryPlanModel.Budget,
                    MonthIndex = (int)salaryPlanModel.WorkTime
                });
                _dbContext.SaveChanges();

                return new ResponseModel
                {
                    Message = "Dodano plan wypłat na ten miesiąc!"
                };
            }
        }

        [HttpGet("getPlan")]
        public SalaryPlanModel GetSalaryPlan([FromQuery(Name = "workTime")] WorkTime workTime)
        {
            try
            {
                SalaryPlan salaryPlan = _dbContext.SalaryPlans.First(plan => plan.MonthIndex == (int)workTime);

                return new SalaryPlanModel
                {
                    WorkTime = (WorkTime)salaryPlan.MonthIndex,
                    Budget = salaryPlan.Budget
                };
            } 
            catch(InvalidOperationException exception)
            {
                return new SalaryPlanModel
                {
                    WorkTime = workTime,
                    Budget = 0
                };
            }
        }
    }
}
