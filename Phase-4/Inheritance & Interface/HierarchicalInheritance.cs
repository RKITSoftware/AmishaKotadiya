using System;
  
namespace HierarchicalInheritanceExample
{
    // Base Class
    public class Father 
    {
        public string FatherName() 
        { 
            return "aaa"; 
        }
    }
    
    // Derived Class
    public class ChildFirst : Father 
    {
        public string ChildDName() 
        { 
            return "bbb"; 
        }
    }
    
    // Derived Class
    public class ChildSecond : Father 
    {
        public string ChildDName() 
        { 
            return "ccc"; 
        }
    }
    
    class HierarchicalInheritance
    { 
        static public void Main()
        {
            ChildFirst objFirst = new ChildFirst();
            // Displaying Child Name and Father Name for
            // ChildFirst
            Console.WriteLine("My name is " + objFirst.ChildDName() +". My father name is " + objFirst.FatherName() + ".");
            
            ChildSecond objSecond = new ChildSecond();
            // Displaying Child Name and Father Name for
            // ChildSecond
            Console.WriteLine("My name is " + objSecond.ChildDName() +". My father name is " +objSecond.FatherName() + ".");
        }
    }
}

/*
Output:
My name is bbb. My father name is aaa.
My name is ccc. My father name is aaa.
*/