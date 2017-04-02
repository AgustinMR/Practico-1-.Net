using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Entities;
using DataAccessLayer;

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
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeList());
            
            var op = new DALEmployeesMongo();
            var emp = (PartTimeEmployee) op.GetEmployee(3);
            Console.WriteLine(emp.Name);*/

            conexion c = new conexion();

        }
    }
}
