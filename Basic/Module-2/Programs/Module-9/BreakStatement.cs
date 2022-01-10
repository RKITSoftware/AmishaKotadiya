// C# break statement with for loop

using System;

namespace BreakStatement 
{
  class Program 
  {
    static void Main(string[] args) 
    {
      for (int number = 1; number <= 4; ++number) 
      {
        
        // terminates the loop
        if (number == 3) 
        {
          break; 
        }
            	
        Console.WriteLine(number);
      }
      	 
      Console.ReadKey();
    }
  }
}