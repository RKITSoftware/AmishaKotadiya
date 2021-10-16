// Post Increment and Pre Increment

using System;
 
namespace Operator
{
	class PostandPreIncrement
	{
		public static void Main(string[] args)
		{
			int number = 10;

			// Post Increment
			Console.WriteLine((number++));
			Console.WriteLine((number));

			// Pre Increment
			Console.WriteLine((++number));
			Console.WriteLine((number));
		}
	}
}
