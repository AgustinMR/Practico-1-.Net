using System;
using Shared.Entities;
using BusinessLogicLayer;
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

            /*BLEmployees obj = new BLEmployees();
            FullTimeEmployee emp = new FullTimeEmployee();
            emp.Name = "Bruno2";
            emp.StartDate = new DateTime(1967, 1, 9);
            emp.Salary = 5;
            obj.AddEmployee(emp);
            //obj.UpdateEmployee(emp);
            //obj.DeleteEmployee(1);
            */
            
        }
    }
}
