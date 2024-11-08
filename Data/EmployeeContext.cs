using Microsoft.EntityFrameworkCore;
using MVCEmployeeWithEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEmployeeWithEF.Data
{
    public class EmployeeContext: DbContext
    {
        
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-8T5HMNLL;Initial Catalog=EmployeeMgmtDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }
    }
}