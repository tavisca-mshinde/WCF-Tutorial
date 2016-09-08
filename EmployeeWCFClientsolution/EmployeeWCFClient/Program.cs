using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;

namespace EmployeeWCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeServiceReference.EmployeeServiceClient client = new EmployeeServiceReference.EmployeeServiceClient();
            client.SaveData(new EmployeeServiceReference.Employee { Id = "1", Name = "sam", Date = "23/23/342", gender = EmployeeServiceReference.Gender.Male });
            Console.WriteLine(Serializer.Serialize(client.GetData("2")));
            var data = Serializer.Serialize(client.GetData("3"));
            Console.WriteLine(client.GetData("2"));
        }
    }
    public static class Serializer
    {
        public static string Serialize(Object obj)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                DataContractSerializer ser = new DataContractSerializer(obj.GetType());
                {
                    ser.WriteObject(memory,obj);
                    return Encoding.UTF8.GetString(memory.ToArray());
                }
            }
        }
    }
    public static class Deserializer
    {
        public static T deserialize<T>(string d)
        {
            DataContractSerializer dser = new DataContractSerializer(typeof(T));
            return (T)dser.ReadObject(XmlReader.Create(new StringReader(d)));
        }
    }
}
