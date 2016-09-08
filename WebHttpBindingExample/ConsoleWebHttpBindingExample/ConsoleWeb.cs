using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHttpBindingExample;
using System.ServiceModel;

namespace ConsoleWebHttpBindingExample
{
    class ConsoleWeb
    {
        static void Main(string[] args)
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(HelloService)))
            {
                serviceHost.Open();
                Console.WriteLine("service started at :{0}", DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
