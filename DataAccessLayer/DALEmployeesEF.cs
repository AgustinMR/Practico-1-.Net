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
            /*EmployeeDbContext context = new EmployeeDbContext();
            context.Employees.Find
            context.Employees.Remove(id2);
            context.SaveChanges();*/

        }

        public void UpdateEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }

}
