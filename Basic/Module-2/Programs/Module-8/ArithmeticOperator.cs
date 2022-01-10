// Basic Arithmetic Operator

using System;
 
namespace Operator
{
	class ArithmeticOperator
	{
		public static void Main(string[] args)
		{
			double firstNumber = 14.40, secondNumber = 4.60, result;
			int number1 = 26, number2 = 4, rem;

			// Addition operator
			result = firstNumber + secondNumber;
			Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

			// Subtraction operator
			result = firstNumber - secondNumber;
			Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);

			// Multiplication operator
			result = firstNumber * secondNumber;
			Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);

			// Division operator
			result = firstNumber / secondNumber;
			Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);

			// Modulo operator
			rem = number1 % number2;
			Console.WriteLine("{0} % {1} = {2}", number1, number2, rem);
		}
	}
}
