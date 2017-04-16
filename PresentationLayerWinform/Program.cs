using System;
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

            ServiceEmployeesClient client = new ServiceEmployeesClient();

            Shared.Entities.PartTimeEmployee emp = new Shared.Entities.PartTimeEmployee();
            emp.Name = "Pedro3";
            emp.StartDate = new DateTime(1800, 5, 19);
            emp.HourlyRate = 43;
            //client.AddEmployee(emp);
            client.Close();


            //obj.UpdateEmployee(emp);
            //obj.DeleteEmployee(1);

        }
    }
}
