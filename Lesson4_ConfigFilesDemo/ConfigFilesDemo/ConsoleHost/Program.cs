using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using CustomerServiceLibrary;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(CustomerService)))
            {
                host.Open();

                Console.WriteLine("The service is rnning and is listening on:");
                foreach (ServiceEndpoint endPoint in host.Description.Endpoints)
                {
                    Console.WriteLine("{0} ({1})", endPoint.Address.ToString(), endPoint.Binding.Name);
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to stop the service");
                Console.ReadKey();

                host.Close();
            }
        }
    }
}
