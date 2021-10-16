// while loop to compute sum of first 5 natural numbers

using System;

namespace Loop
{
	class WhileLoop
	{
		public static void Main(string[] args)
		{
			int number=1, sum=0;

			// sum of five number using while Loop 
			while (number<=5)
			{
				sum += number;
				number++;
			}
			Console.WriteLine("Sum = {0}", sum);
		}
	}
}