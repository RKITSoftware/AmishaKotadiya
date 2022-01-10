// Compound Assignment Operator

using System;
 
namespace Operator
{
	class CompoundAssignmentOperator
	{
		public static void Main(string[] args)
		{
			int number1, number2, number3, number4, number5, number6, number7, number8, number9, number10;
			number1=number2=number3=number4=number5=number6=number7=number8=number9=number10=10;
			// Addition Assignment
			number1 += 5;
			Console.WriteLine(number1);

			// Subtraction Assignment
			number2 -= 3;
			Console.WriteLine(number2);

			// Multiplication Assignment
			number3 *= 2;
			Console.WriteLine(number3);

			// Division Assignment
			number4 /= 3;
			Console.WriteLine(number4);

			// Modulo Assignment
			number5 %= 3;
			Console.WriteLine(number5);

			// Bitwise AND Assignment
			number6 &= 10;
			Console.WriteLine(number6);

			// Bitwise OR Assignment
			number7 |= 14;
			Console.WriteLine(number7);

			// Bitwise XOR Assignment
			number8 ^= 12;
			Console.WriteLine(number8);

			// Left Shift Assignment
			number9 <<= 2;
			Console.WriteLine(number9);

			// Right Shift Assignment
			number10 >>= 3;
			Console.WriteLine(number10);
		}
	}
}
