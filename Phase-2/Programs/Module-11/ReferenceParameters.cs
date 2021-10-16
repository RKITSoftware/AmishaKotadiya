// example of Reference Parameters 

using System;

namespace Method2
{
   class ReferenceParameters
   {
      static void swap(ref int x, ref int y) 
      {
         int temp;

         temp = x; /* save the value of x */
         x = y;    /* put y into x */
         y = temp; /* put temp into y */
      }
      static void Main(string[] args) 
      {         
         /* local variable definition */
         int number1 = 100;
         int number2 = 200;

         Console.WriteLine("Before swap, value of number1 : {0}", number1);
         Console.WriteLine("Before swap, value of number2 : {0}", number2);

         /* calling a function to swap the values */
         swap(ref number1, ref number2);

         Console.WriteLine("After swap, value of number1 : {0}", number1);
         Console.WriteLine("After swap, value of number2 : {0}", number2);
 
         Console.ReadLine();
      }
   }
}