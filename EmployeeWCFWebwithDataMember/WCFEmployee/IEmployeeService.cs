using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCFEmployee
{
    [ServiceContract]
   public interface IEmployeeService
    {
        [OperationContract]
        void SaveData(Employee e);

        [WebInvoke(Method ="GET" ,RequestFormat =WebMessageFormat.Json ,UriTemplate ="/{Id}" )]
        [OperationContract]
        Employee GetData(string Id);
    }
}
