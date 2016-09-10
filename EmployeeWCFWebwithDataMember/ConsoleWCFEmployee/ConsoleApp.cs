using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFEmployee;


namespace ConsoleWCFEmployee
{
    public class ConsoleApp
    {
        public static void Main(string[] args)
        {
            using (ServiceHost serviceHost =new ServiceHost(typeof(EmployeeService)))
            {
                serviceHost.Open();
                Console.WriteLine("started" + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
