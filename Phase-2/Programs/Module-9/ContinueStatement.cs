// C# continue with for loop

using System;

namespace ContinueStatement
{
  class Program 
  {
    static void Main(string[] args)
    {

      // continue with for loop
      for (int number = 1; number <= 5; ++number){
                
        if (number == 3) 
        {
          continue;
        }

        Console.WriteLine(number);
      }
    }
  }
}