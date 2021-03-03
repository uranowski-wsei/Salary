using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salary_Distribution.Entities
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public bool Foreman { get; set; }

        public int Salary { get; set; }
    }
}
