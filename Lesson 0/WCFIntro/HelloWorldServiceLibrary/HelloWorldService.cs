using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloWorldServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class HelloWorldService : IHelloWorldService
    {
        public string SayHello(string str)
        {
            return ("Hello " + str);
        }
    }
}
