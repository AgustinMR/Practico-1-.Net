﻿using BusinessLogicLayer;
using DataAccessLayer;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class Helper
    {
        /*
        public static void RegisterTypes(UnityContainer container)
        {
            //register the concrete implementation for interfaces
            container.RegisterType<IDALEmployees, DALEmployeesEF>();
            container.RegisterType<IBLEmployees, BLEmployees>();

            //register a singleton for DAL
            DALEmployeesMongo dalEmployeesEF = new DALEmployeesMongo();
            container.RegisterInstance(dalEmployeesEF);

            //register a singleton for BL
            BLEmployees blEmployees = new BLEmployees(container.Resolve<IDALEmployees>());
            container.RegisterInstance(blEmployees);
        }
        */
    }
}
