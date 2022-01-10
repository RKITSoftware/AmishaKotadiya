using System;

namespace SingleInheritanceExample
{
    // base class
    public class User
    {
       public string Name;
       private string Location;

       // base class constructor
       public User()
       {
          Console.WriteLine("Base Class Constructor");
       }

       // base class method
       public void GetUserInfo(string loc)
       {
          Location = loc;
          Console.WriteLine("Name: {0}", Name);
          Console.WriteLine("Location: {0}", Location);
       }
    }

    // child class 
    public class Details: User
    {
       public int Age;

       // child class constructor
       public Details()
       {
          Console.WriteLine("Child Class Constructor");
       }

       // child class method
       public void GetAge()
       {
          Console.WriteLine("Age: {0}", Age);
       }
    }

    class SingleInheritance
    {
       static void Main(string[] args)
       {
          Details objDetail = new Details();
          objDetail.Name = "Amisha Kotadiya";
          // Compile Time Error
          //d.Location = "Lalpur";
          objDetail.Age = 21;
          objDetail.GetUserInfo("Lalpur");
          objDetail.GetAge();
          Console.ReadLine();
       }
    }
}

/*
Output:
Base Class Constructor
Child Class Constructor
Name: Amisha Kotadiya
Location: Lalpur
Age: 21
*/