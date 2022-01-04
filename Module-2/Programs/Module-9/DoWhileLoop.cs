// Multiplication table using dowhile llop

using System;

namespace Loop
{
	class DoWhileLoop
	{
		public static void Main(string[] args)
		{
			int number = 1, tableNumber = 5, product;
			
			// DoWhile Loop
			do
			{
				product = tableNumber * number;
				Console.WriteLine("{0} * {1} = {2}", tableNumber, number, product);
				number++;
			} while (number <= 10);
		}
	}
}