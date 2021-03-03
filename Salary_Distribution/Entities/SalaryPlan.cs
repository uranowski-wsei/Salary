using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salary_Distribution.Entities
{
    public class SalaryPlan
    {
        public int Id { get; set; }
        public int MonthIndex { get; set; }
        public int Budget { get; set; }
    }
}
