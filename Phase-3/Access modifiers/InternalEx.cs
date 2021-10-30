using System;

namespace InternalAccessModifier
{
     class User
     {
        internal string Name;
        internal string Location;
        internal int Age;
        internal void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
     }
     class InternalEx
     {
        static void Main(string[] args)
        {
            User objUser = new User();
            objUser.Name = "Amisha Kotadiya";
            objUser.Location = "Lalpur";
            objUser.Age = 21;
            objUser.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
     }
}