using Nancy.Json;
using System;

namespace JsonSerializeEX
{
    class Program
    {
        class Employee
        {
            public string EmpName { get; set; }
            public int EmpPhone { get; set; }
        }
        static void Main(string[] args)
        {
            // Creating an Employee object
            Employee objemployee = new Employee()
            {
                EmpName = "abc",
                EmpPhone = 1234567890
            };

            //Nancy.Serialization.JsonNet - Use Serialize method to convert the object to JSON
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            string jsonString = jsSerializer.Serialize(objemployee);
            Console.WriteLine(jsonString);
            //Use Deserialize() method to convert JSON to Object
            JavaScriptSerializer jsSerializer2 = new JavaScriptSerializer();
            Employee empobj = jsSerializer2.Deserialize<Employee>(jsonString);
            string name = empobj.EmpName;
            int phone = empobj.EmpPhone;
            Console.WriteLine("Name is:" + name);
            Console.WriteLine("Phone is:" + phone);
            Console.ReadLine();
        }
    }
}
