using System;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerializeEx
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        [XmlElement("EmpAddress")]
        public string Address { get; set; }
        [XmlIgnore]
        public double Salary { get; set; }
        public Employee()
        {
            EmpID = 0;
            EmpName = "N/A";
            Address = "N/A";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            static void SerializeData(Employee emp)
            {
                // create file to save the data
                FileStream fs = new FileStream(@"C:\Users\SSC\Desktop\RKIT Training\Module-5\test1.txt", FileMode.Create);

                //XmlSerializer object will perform the serialization
                XmlSerializer xmlobj = new XmlSerializer(typeof(Employee));

                //Serialize method serialize the data to the file
                xmlobj.Serialize(fs, emp);

                // close the file
                fs.Close();
            }
            static void DeSerializeData()
            {
                // open file to read the data
                FileStream fs = new FileStream(@"C:\Users\SSC\Desktop\RKIT Training\Module-5\test1.txt", FileMode.Open);
                //XmlSerializer object to perform the deserialization
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                //Use the XmlSerializer object to deserialize the data from the file
                Employee emp = (Employee)xs.Deserialize(fs);
                //close the file
                fs.Close();
                //Display the deserialized data
                Console.WriteLine("Employee ID =" + emp.EmpID);
                Console.WriteLine("Employee Name =" + emp.EmpName);
                Console.WriteLine("Employee Address =" + emp.Address);
            }
            static void Main(string[] args)
            {
                Employee objemployee = new Employee();
                objemployee.EmpID = 1;
                objemployee.EmpName = "abc";
                objemployee.Address = "xyz";
                SerializeData(objemployee);
                DeSerializeData();

                Console.ReadLine();
            }
        }
    }
}