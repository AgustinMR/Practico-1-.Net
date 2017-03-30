using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using Shared.Entities;
>>>>>>> origin
using DataAccessLayer;


namespace PresentationLayerWinform {
    static class Program{
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
<<<<<<< HEAD
        //[STAThread]
        static void Main(string[] args){
            conexion cn = new conexion();

           /// Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new EmployeeList());
=======
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeList());

            var e = new FullTimeEmployee();
            e.EmployeeId = 1;
            e.Name = "Fulano";
            e.StartDate = DateTime.Parse("2017-3-30");
            e.Salary = -35000;

            var op = new DALEmployeesMongo();
            op.AddEmployee(e);
>>>>>>> origin
        }
    }
}
