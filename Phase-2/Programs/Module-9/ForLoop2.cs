// for loop with multiple initialization and iterator expressions

using System;

namespace Loop
{
	class ForLoop2
	{
		public static void Main(string[] args)
		{
			// Multiple expressions inside a for loop
			for (int firstNumber=0, secondNumber=0; firstNumber+secondNumber<=5; firstNumber++, secondNumber++)
			{
				Console.WriteLine("i = {0} and j = {1}", firstNumber,secondNumber);
			}         
		}
	}
}