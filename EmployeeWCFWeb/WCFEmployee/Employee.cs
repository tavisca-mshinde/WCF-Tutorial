using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFEmployee
{
    public class Employee
    {
       public string Id { set; get; }
       public string Name { set; get; }
       public string Date { set; get; }
       public Gender gender { set; get; }

    }
    public enum Gender
    {
        Male=1,
        Female=2
    }
}
