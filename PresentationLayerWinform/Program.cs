using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Entities;
using DataAccessLayer;
using MongoDB.Bson.Serialization;

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

            BsonClassMap.RegisterClassMap<Employee>(cm => {
                cm.AutoMap();
            });

            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeList());
            
            var op = new DALEmployeesMongo();
            var emp = (PartTimeEmployee) op.GetEmployee(3);
            Console.WriteLine(emp.Name);

            PartTimeEmployee e = new PartTimeEmployee();
            e.HourlyRate = 666.6;
            e.StartDate = DateTime.Parse("2017-07-16");
            e.Name = "Mengano";
            e.EmployeeId = 2;*/

            DALEmployeesMongo c = new DALEmployeesMongo();

            /*FullTimeEmployee fe = new FullTimeEmployee();
            fe.EmployeeId = 1;
            fe.Name = "John Snow";
            fe.StartDate = DateTime.Parse("2008-6-3");

            c.AddEmployee(fe);*/

            FullTimeEmployee pepe = (FullTimeEmployee) c.GetEmployee(1);
            pepe.Salary = 100;
            pepe.Name = "Ochoa";
            pepe.StartDate = DateTime.Parse("2010-8-5");
            c.UpdateEmployee(pepe);

            c.DeleteEmployee(pepe.EmployeeId);

        }
    }
}
