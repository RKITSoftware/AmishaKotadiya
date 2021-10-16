// Basic Bit And Bitwise Operator

using System;
 
namespace Operator
{
	class BitOperator
	{
		public static void Main(string[] args)
		{
			int firstNumber = 5;
			int secondNumber = 20;
			int result;

			// Bitwise Complement
			result = ~firstNumber;
			Console.WriteLine("~{0} = {1}", firstNumber, result);

			// Bitwise AND
			result = firstNumber & secondNumber;
			Console.WriteLine("{0} & {1} = {2}", firstNumber,secondNumber, result);

			// Bitwise OR
			result = firstNumber | secondNumber;
			Console.WriteLine("{0} | {1} = {2}", firstNumber,secondNumber, result);

			// Bitwise Exclusive OR
			result = firstNumber ^ secondNumber;
			Console.WriteLine("{0} ^ {1} = {2}", firstNumber,secondNumber, result);

			// Bitwise Left Shift
			result = firstNumber << 2;
			Console.WriteLine("{0} << 2 = {1}", firstNumber, result);

			// Bitwise Right Shift
			result = firstNumber >> 2;
			Console.WriteLine("{0} >> 2 = {1}", firstNumber, result);
		}
	}
}
