using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Entities;
using MongoDB.Bson.Serialization;
using BusinessLogicLayer;

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
            Application.Run(new EmployeeList());*/

            /*
            PartTimeEmployee e = new PartTimeEmployee();
            e.HourlyRate = 666.6;
            e.StartDate = DateTime.Parse("2017-07-16");
            e.Name = "Mengano";
            e.EmployeeId = 2;*/

            BLEmployees b = new BLEmployees();
            Console.WriteLine(b.CalcPartTimeEmployeeSalary(1, 2));

            /*FullTimeEmployee fe = new FullTimeEmployee();
            fe.EmployeeId = 1;
            fe.Name = "John Snow";
            fe.StartDate = DateTime.Parse("2008-6-3");

            c.AddEmployee(fe);*/

            /*
            PartTimeEmployee pepe = new PartTimeEmployee();
            pepe.HourlyRate = 100.22;
            pepe.Name = "Pelado Puto";
            pepe.StartDate = DateTime.Parse("2010-8-5");
            c.AddEmployee(pepe);*/

            /*c.DeleteEmployee(pepe.EmployeeId);*/

        }
    }
}
