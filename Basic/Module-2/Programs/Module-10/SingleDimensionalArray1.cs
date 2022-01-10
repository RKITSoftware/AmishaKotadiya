// demonstrates the declaration, assignment, and accessing arrays 

using System;

namespace ArrayExample 
{
   class SingleDimensionalArray1 
   {
      static void Main(string[] args) 
      {
      
         // myArray is an array of 10 integers 
         int[]  myArray = new int[10]; 
         int i;

         // initialize elements of array myArray 
         for ( i = 0; i < 10; i++ ) {
            myArray[ i ] = i + 100;
         }
         
         // output each array element's value 
         for (i = 0; i < 10; i++ ) {
            Console.WriteLine("Element[{0}] = {1}", i, myArray[i]);
         }
         Console.ReadKey();
      }
   }
}