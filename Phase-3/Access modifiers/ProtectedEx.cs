using System;

namespace ProtectedAccessModifier
{
    class User
    {
        protected string Name;
        protected string Location;
        protected int Age;
        protected void GetUserDetails()
        {
           Console.WriteLine("Name: {0}", Name);
           Console.WriteLine("Location: {0}", Location);
           Console.WriteLine("Age: {0}", Age);
        }
    }
    class ProtectedEx: User
    {
        static void Main(string[] args)
        {
           User objUser = new User();
           ProtectedEx objProtected = new ProtectedEx();
           // Complier Error
           // protected members can only accessible with derived classes
           //u.Name = "Suresh Dasari";
           objProtected.Name = "Amisha Kotadiya";
           objProtected.Location = "Lalpur";
           objProtected.Age = 21;
           objProtected.GetUserDetails();
           Console.WriteLine("\nPress Enter Key to Exit..");
           Console.ReadLine();
        }
    }
}