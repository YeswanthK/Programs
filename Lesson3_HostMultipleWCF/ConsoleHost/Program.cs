using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomerServceLibrary;
using TimeServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ConsoleHost
{
    class Program
    {
        static ServiceHost customerHost = null;
        static ServiceHost timeHost = null;

        static void Main(string[] args)
        {
            try
            {
                HostCustomerService();
                HostTimeService();

                Console.WriteLine();
                Console.WriteLine("Press any key to stop the service");
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                customerHost.Close();
                timeHost.Close();
            }
        }
        static void HostCustomerService()
        {
            customerHost = new ServiceHost(typeof(CustomerService));

            ServiceEndpoint tcpEndPoint = customerHost.AddServiceEndpoint(typeof(CustomerService), 
                new NetTcpBinding(), 
                "net.tcp://localhost:9000/CustomerService");
            customerHost.Open();
            Console.WriteLine("The customer service is running on and listening to:");
            foreach(ServiceEndpoint endpoint in customerHost.Description.Endpoints)
            {
                Console.WriteLine("{0} ({1})",endpoint.Address.ToString(),endpoint.Binding.Name);
            }
            Console.WriteLine();
        }
        static void HostTimeService()
        {
            timeHost = new ServiceHost(typeof(TimeService));

            ServiceEndpoint tcpEndPoint = timeHost.AddServiceEndpoint(typeof(TimeService), 
                new NetTcpBinding(), 
                "net.tcp://localhost:9010/TimeService");
            timeHost.Open();
            Console.WriteLine("The time service is running on and listening to:");
            foreach (ServiceEndpoint endpoint in timeHost.Description.Endpoints)
            {
                Console.WriteLine("{0} ({1})", endpoint.Address.ToString(), endpoint.Binding.Name);
            }
            Console.WriteLine();
        }
    }
}
