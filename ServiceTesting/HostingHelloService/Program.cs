using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceTesting;

namespace HostingHelloService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(HelloService)))
            {
                serviceHost.Open();
                Console.WriteLine("service started at " + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
