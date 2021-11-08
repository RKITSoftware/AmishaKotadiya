using System;

namespace InterfaceExample
{
    // define interface for name
    interface IName
    {
        // interface method 
        void GetName(string x);
    }

    // define interface for location
    interface ILocation
    {
        // interface method
        void GetLocation(string x);
    }

    // define interface for age
    interface IAge
    {
        // interface method
        void GetAge(int x);
    }

    // implement all interface
    class User: IName, ILocation, IAge
    {
        // implement all interface methods
        public void GetName(string a)
        {
           Console.WriteLine("Name: {0}", a);
        }
        public void GetLocation(string a)
        {
           Console.WriteLine("Location: {0}", a);
        }
        public void GetAge(int a)
        {
           Console.WriteLine("Age: {0}", a);
        }
    }

    class MultipleInheritance
    {
       static void Main(string[] args)
       {
           User objU = new User();
           objU.GetName("Amisha Koatdiya");
           objU.GetLocation("Lalpur");
           objU.GetAge(21);
           Console.ReadLine();
       }
    }
}

/*
Output:
Name: Amisha Koatdiya
Location: Lalpur
Age: 21
*/