using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerializeEx
{
    class Program
    {
        [Serializable]
        class Customer
        {
            public int CustomerID { get; set; }
            public string CustomerName { get; set; }
        }
        static void Main(string[] args)
        {
            // step - 1
            Customer objcustomer = new Customer();
            objcustomer.CustomerID = 1;
            objcustomer.CustomerName = "abcd";

            //step-2
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\SSC\Desktop\RKIT Training\Module-5\test.txt", FileMode.Create, FileAccess.Write);

            //step-3 serialize
            formatter.Serialize(stream, objcustomer);
            stream.Close();

            //step-4 deserialize
            stream = new FileStream(@"C:\Users\SSC\Desktop\RKIT Training\Module-5\test.txt", FileMode.Open, FileAccess.Read);
            Customer objcustomernew = (Customer)formatter.Deserialize(stream);

            Console.WriteLine("After Deserialize Object:" + objcustomernew.CustomerID);
            Console.WriteLine("After Deserialize Object:" + objcustomernew.CustomerName);

            Console.ReadLine();
        }
    }
}
