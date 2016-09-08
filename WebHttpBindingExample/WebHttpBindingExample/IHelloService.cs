using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WebHttpBindingExample
{
    [ServiceContract]
    public interface IHelloService
    {
        [WebInvoke (Method = "GET" , RequestFormat =WebMessageFormat.Json , UriTemplate ="/{msg}")]
        [OperationContract]
        string GetMessage(string msg);
    }
}
