using System;
namespace sealedExample
{
    // sealed class concept
    // Base Class
    sealed class Users
    {
       string name="Amisha";
       string location="Lalpur";
       public void GetInfo()
       {
          Console.WriteLine("This sealed class which can not be inherited\n");
          Console.WriteLine("Name: {0}", name);
          Console.WriteLine("Location: {0}", location);
       }
    }
    /*

    // Derived Class
    public class Details : Users
    {
    }
    */

    // sealed method concept
    public class A
    {
       public virtual void Info()
       {
          Console.WriteLine("Base Class A Method");
       }
       public virtual void Test()
       {
          Console.WriteLine("Base Class A Test Method");
       }
    }
    public class B: A
    {
       public sealed override void Info()
       {
           Console.WriteLine("\nDerived Class B sealed Method can not be override");
       }
       public override void Test()
       {
           Console.WriteLine("Derived Class B Test Method");
       }
    }
    public class C: B
    {
       // Compile time error
      /* public override void Info()
       { 
           Console.WriteLine("Derived Class C Method");
       } */
       public override void Test()
       {
           Console.WriteLine("Derived Class C Test Method");
       }
    }
    class SealedEx
    {
       static void Main(string[] args)
       {
          Users objuser = new Users();
          objuser.GetInfo();

          C objC = new C();
           objC.Info();
           objC.Test();

          Console.WriteLine("\nPress Enter Key to Exit..");
          Console.ReadLine();
       }
    }
}

/*
This sealed class which can not be inherited

Name: Amisha
Location: Lalpur

Derived Class B sealed Method can not be override
Derived Class C Test Method
*/