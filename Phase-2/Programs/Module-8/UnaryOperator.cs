// Unary Operator

using System;
 
namespace Operator
{
	class UnaryOperator
	{
		public static void Main(string[] args)
		{
			int number = 10, result;
			bool flag = true;

			// Unary Plus
			result = +number;
			Console.WriteLine("+number = " + result);

			// Unary Minus
			result = -number;
			Console.WriteLine("-number = " + result);

			// Increment
			result = ++number;
			Console.WriteLine("++number = " + result);

			// Decrement
			result = --number;
			Console.WriteLine("--number = " + result);

			// Logical Negation (Not)
			Console.WriteLine("!flag = " + (!flag));
		}
	}
}
