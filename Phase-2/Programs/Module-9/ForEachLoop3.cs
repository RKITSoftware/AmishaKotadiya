// foreach loop with List (Collection)

using System;
using System.Collections.Generic;
 
namespace Loop
{
    class ForEachLoop3
    {
        public static void Main(string[] args)
        {
          var numbers = new List<int>() { 5, -8, 3, 14, 9, 17, 0, 4 };
          int sum = 0;
 
          // foreach loop with List
          foreach (int number in numbers) 
          {
            sum += number;
          }
            
          Console.WriteLine("Sum = {0}", sum);
          Console.ReadLine();
        }
    }
}