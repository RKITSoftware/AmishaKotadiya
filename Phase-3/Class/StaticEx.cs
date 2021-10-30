using System;

namespace staticExample
{
    // Static class
     static class User
     {
         // Static Variables
         public static string name;
         public static string location;
         public static int age;
         // Static Method
         public static void Details()
         {
            Console.WriteLine("Static Method called");
         }
     }
     class StaticEx
     {
        static void Main(string[] args)
        {
            User.name = "Amisha";
            User.location = "Lalpur";
            User.age = 21;
            Console.WriteLine("Name: {0}", User.name);
            Console.WriteLine("Location: {0}", User.location);
            Console.WriteLine("Age: {0}", User.age);
            User.Details();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
     }
}

/*
Name: Amisha
Location: Lalpur
Age: 21
Static Method called
*/