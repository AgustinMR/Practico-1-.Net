using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DataAccessLayer
{

    public class EmployeeDbContext : DbContext {
        Type providerService = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        public EmployeeDbContext() : base("name=EmployeesConnectionString") { }
        public DbSet<Employee> Employees { get; set; }
    }

    public class DALEmployeesEF : IDALEmployees {

        public void AddEmployee(Employee emp)
        {
            EmployeeDbContext context = new EmployeeDbContext();
            context.Employees.Add(emp);
            context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            EmployeeDbContext context = new EmployeeDbContext();
            Employee emp = (from d in context.Employees where d.EmployeeId == id select d).Single();
            context.Employees.Remove(emp);
            context.SaveChanges();
        }

        public void UpdateEmployee(Employee emp)
        {
            EmployeeDbContext context = new EmployeeDbContext();
            Employee empBD = (from d in context.Employees where d.EmployeeId == emp.EmployeeId select d).Single();
            empBD.Name = emp.Name;
            empBD.StartDate = emp.StartDate;
            context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            EmployeeDbContext context = new EmployeeDbContext();
            return context.Employees.ToList();
        }

        public Employee GetEmployee(int id)
        {
            EmployeeDbContext context = new EmployeeDbContext();
            Employee empBD = (from d in context.Employees where d.EmployeeId == id select d).Single();
            context.SaveChanges();
            return empBD;
        }
    }

}
