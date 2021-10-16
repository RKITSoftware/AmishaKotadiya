// example of Optional Parameters

using System;

namespace Method3
{
   class OptionalParameters 
   {
      static void getValues(out int x, out int y ) 
      {
          Console.WriteLine("Enter the first value: ");
          x = Convert.ToInt32(Console.ReadLine());
          
          Console.WriteLine("Enter the second value: ");
          y = Convert.ToInt32(Console.ReadLine());
      }

      static void Main(string[] args) 
      {         
         /* local variable definition */
         int number1, number2;
         
         /* calling a function to get the values */
         getValues(out number1, out number2);
         
         Console.WriteLine("After method call, value of number1 : {0}", number1);
         Console.WriteLine("After method call, value of number2 : {0}", number2);
         Console.ReadLine();
      }
   }
}