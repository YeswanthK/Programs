using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFClient1.HelloServiceReference;

namespace WCFClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldServiceClient x = new HelloWorldServiceClient();
            Console.WriteLine(x.SayHello("Yashwant"));
            Console.ReadKey();
        }
    }
}
