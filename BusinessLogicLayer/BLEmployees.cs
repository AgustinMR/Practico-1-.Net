using DataAccessLayer;
using Shared.Entities;
using System;
using System.Collections.Generic;
using Shared;

namespace BusinessLogicLayer
{
    public class BLEmployees : IBLEmployees
    {
       private IDALEmployees _dal;

        public BLEmployees(IDALEmployees dal)
        {
            _dal = dal;
        }

        public BLEmployees()
        {

        }

        public void AddEmployee(Employee emp)
        {
            new DALEmployeesMongo().AddEmployee(emp);
        }

        public void DeleteEmployee(int id)
        {
            new DALEmployeesMongo().DeleteEmployee(id);
        }

        public void UpdateEmployee(Employee emp)
        {
            new DALEmployeesMongo().UpdateEmployee(emp);
        }

        public List<Employee> GetAllEmployees()
        {
            return new DALEmployeesMongo().GetAllEmployees();
        }

        public Employee GetEmployee(int id)
        {
            return new DALEmployeesMongo().GetEmployee(id);
        }

        public double CalcPartTimeEmployeeSalary(int idEmployee, int hours)
        {
            Employee e = GetEmployee(idEmployee);
            if (e == null) throw new Shared.Exception.NotAnExistingEmployee(idEmployee);
            if (e.GetType() == typeof(FullTimeEmployee)) throw new Shared.Exception.NotPartTimeEmployeeException(idEmployee);
            return (hours * ((PartTimeEmployee)e).HourlyRate);
        }
    }
}
