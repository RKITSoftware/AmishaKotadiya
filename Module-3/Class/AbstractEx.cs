using System;

namespace abstractExample
{
    // abstract class
    abstract class Info
    {
       // abstract method
       abstract public void GetDetails(string x, string y, int z);
    }
    class User: Info
    {
       // implementation of abstract method
       public override void GetDetails(string a, string b, int c)
       {
           Console.WriteLine("Name: {0}", a);
           Console.WriteLine("Location: {0}", b);
           Console.WriteLine("Age: {0}", c);
       }
    }
    class AbstractEx
    {
       static void Main(string[] args)
       {
           User objuser = new User();
           Console.WriteLine("Abstract Class Example\n");
           objuser.GetDetails("Amisha Kotadiya", "Lalpur", 21);
           Console.ReadLine();
       }
    }
}

/*
Abstract Class Example

Name: Amisha Kotadiya
Location: Lalpur
Age: 21
*/