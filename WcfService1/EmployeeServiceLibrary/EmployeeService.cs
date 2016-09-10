using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServiceLibrary
{
    public class EmployeeService : IEmployeeService
    {
        static List<Employee> employees;
        public EmployeeService()
        {
            if (employees == null)
            {
                employees = new List<Employee>();
                employees.Add(new Employee { Id = "1", Name = "Ranbeer", Date = "34/34/233" });//gender = Gender.Male
                employees.Add(new Employee { Id = "2", Name = "Salman", Date = "4/2/1233" });
                employees.Add(new Employee { Id = "3", Name = "katrina", Date = "3/4/233" });
            }
        }
        public Employee GetData(string Id)
        {

            return employees.Find(x => x.Id == Id);
            //throw new NotImplementedException();
        }

        public void SaveData(Employee e)
        {
            employees.Add(e);
            //throw new NotImplementedException();
        }
    }
}
