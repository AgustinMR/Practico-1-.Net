using BusinessLogicLayer;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    class Program
    {
        public static IBLEmployees blHandler;

        static void Main(string[] args)
        {
            SetupDependencies();
            SetupService();
        }

        private static void SetupDependencies()
        {
            blHandler = new BLEmployees(new DataAccessLayer.DALEmployeesMongo());
            /*using( UnityContainer container = new UnityContainer ())
            {
                Helper.RegisterTypes(container);
                blHandler = container.Resolve<IBLEmployees>();
            }*/
        }

        private static void SetupService()
        {
            Uri serviceAddress = new Uri("http://localhost:8834/tsi1");
            ServiceHost service = null;
            try
            {
                service = new ServiceHost(typeof(ServiceEmployees), serviceAddress);
                service.AddServiceEndpoint(typeof(IServiceEmployees), new WSHttpBinding(), "EmployeeService");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                service.Description.Behaviors.Add(smb);
                service.Open();
                Console.WriteLine("Employee WFC Service is runing...");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();
            }
            catch (CommunicationException e)
            {
                Console.WriteLine("An Exception has Ocurred. {0}", e.Message);
            }
            finally
            {
                if(service != null) service.Abort();
            }
            
        }
    }
}
