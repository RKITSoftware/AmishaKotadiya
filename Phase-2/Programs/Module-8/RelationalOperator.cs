// Relational Operator

using System;
 
namespace Operator
{
	class RelationalOperator
	{
		public static void Main(string[] args)
		{
			bool result;
			int firstNumber = 10, secondNumber = 20;

			// Equal to operator
			result = (firstNumber==secondNumber);
			Console.WriteLine("{0} == {1} returns {2}",firstNumber, secondNumber, result);

			// Greater than Operator
			result = (firstNumber > secondNumber);
			Console.WriteLine("{0} > {1} returns {2}",firstNumber, secondNumber, result);

			// Less than Operator
			result = (firstNumber < secondNumber);
			Console.WriteLine("{0} < {1} returns {2}",firstNumber, secondNumber, result);

			// Greater than or equal to
			result = (firstNumber >= secondNumber);
			Console.WriteLine("{0} >= {1} returns {2}",firstNumber, secondNumber, result);

			// Less than or equal to
			result = (firstNumber <= secondNumber);
			Console.WriteLine("{0} <= {1} returns {2}",firstNumber, secondNumber, result);

			// Not equal to
			result = (firstNumber != secondNumber);
			Console.WriteLine("{0} != {1} returns {2}",firstNumber, secondNumber, result);
		}
	}
}
