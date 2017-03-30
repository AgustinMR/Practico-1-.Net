using System;
using Shared.Entities;
using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerWinform
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeList());

            DALEmployeesEF obj = new DALEmployeesEF();
            FullTimeEmployee emp = new FullTimeEmployee();
            emp.EmployeeId = 1;
            emp.Name = "Bruno";
            emp.StartDate = new DateTime(1997, 1, 9);
            emp.Salary = 1000000;
            obj.AddEmployee(emp);
        }
    }
}
