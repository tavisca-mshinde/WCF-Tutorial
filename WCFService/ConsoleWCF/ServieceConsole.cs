using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ConsoleWCF
{
    class ServieceConsole
    {
        static void Main(string[] args)
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(WCFService.HelloService)))
            {
                serviceHost.Open();
                Console.WriteLine("today service started at " + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
