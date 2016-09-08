using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHttpBindingExample
{
    public class HelloService : IHelloService
    {
        public string GetMessage(string msg)
        {
            return "hello, "+msg;
            //throw new NotImplementedException();
        }
    }
}
