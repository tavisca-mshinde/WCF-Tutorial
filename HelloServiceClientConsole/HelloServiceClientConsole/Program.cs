using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloServiceClientConsole;

namespace HelloServiceClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelloServiceReference.HelloServiceClient obj = new HelloServiceReference.HelloServiceClient();
            ServiceReference1.HelloServiceClient obj = new ServiceReference1.HelloServiceClient("BasicHttpBinding_IHelloService");
            Console.WriteLine(obj.HelloMessage("manoj"));
            Console.ReadLine();
             
        }
    }
}
