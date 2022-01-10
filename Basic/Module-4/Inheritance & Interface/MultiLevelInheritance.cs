using System;

namespace MultiLevelInheritanceExample
{
    // class A
    public class A
    {
       public string Name;

       // A Class Constructor
       public A()
       {
          Console.WriteLine("A Class Constructor"); 
       }

       // A Class Method
       public void GetName()
       {
          Console.WriteLine("Name: {0}", Name);
       }
    }

    // class B
    public class B: A
    {
       public string Location;
       
       // B Class Constructor
       public B()
       {
          Console.WriteLine("B Class Constructor"); 
       }

       // B Class Method
       public void GetLocation()
       {
          Console.WriteLine("Location: {0}", Location);
       }
    }

    // class C
    public class C: B
    {
       public int Age;
       
       // C Class Constructor
       public C()
       {
          Console.WriteLine("C Class Constructor"); 
       }

       // C Class Method
       public void GetAge()
       {
          Console.WriteLine("Age: {0}", Age);
       }
    }

    class MultiLevelInheritance
    {
       static void Main(string[] args)
       {
          C objC = new C();
          objC.Name = "Amisha Kotadiya";
          objC.Location = "Lalpur";
          objC.Age = 21;
          objC.GetName();
          objC.GetLocation();
          objC.GetAge();
          Console.ReadLine();
       }
    }
}

/*
Output:
A Class Constructor
B Class Constructor
C Class Constructor
Name: Amisha Kotadiya
Location: Lalpur
Age: 21
*/