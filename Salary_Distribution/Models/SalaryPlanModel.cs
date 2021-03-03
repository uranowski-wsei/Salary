using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Salary_Distribution.Models.SalariesModel;

namespace Salary_Distribution.Models
{
    public class SalaryPlanModel
    {
        public WorkTime WorkTime { get; set; }
        public int Budget { get; set; }
    }
}
