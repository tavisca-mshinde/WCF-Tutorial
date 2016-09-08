using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WCFService
{
    public class HelloService : IHelloService
    {
        public string HelloMessage(string s)
        {
            return "hello "+s;
            //throw new NotImplementedException();
        }
    }
}
