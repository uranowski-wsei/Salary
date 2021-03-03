using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Salary_Distribution.Entities
{
    public class EmployeesDbContext : DbContext
    {
        private string _connectionString = "Server=(localdb)\\SalaryDB;Database=SalaryDb;Trusted_Connection=True;";
        public DbSet<Employees> Employees { get; set; }
        public DbSet<SalaryPlan> SalaryPlans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
