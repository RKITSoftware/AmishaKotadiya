// example of Value Parameters 

using System;

namespace Method1 
{
   class ValueParameters 
   {
      static void swap(int x, int y) 
      {
         int temp;
         
         temp = x; /* save the value of x */
         x = y;    /* put y into x */
         y = temp; /* put temp into y */

         Console.WriteLine("value of x : {0}", x);
         Console.WriteLine("value of y : {0}", y);
      }
      static void Main(string[] args) 
      {         
         /* local variable definition */
         int number1 = 15;
         int number2 = 20;
         
         Console.WriteLine("Before swap, value of number1 : {0}", number1);
         Console.WriteLine("Before swap, value of number2 : {0}", number2);
         
         /* calling a function to swap the values */
         swap(number1, number2);
         
         Console.WriteLine("After swap, value of number1 : {0}", number1);
         Console.WriteLine("After swap, value of number2 : {0}", number2);
         
         Console.ReadLine();
      }
   }
}