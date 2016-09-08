using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTesting
{
    public class HelloService : IHelloService
    {
        public string GetMessage(string s)
        {
            return "Hello " + s;
            //throw new NotImplementedException();
        }
    }
}
