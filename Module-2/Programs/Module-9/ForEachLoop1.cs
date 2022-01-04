// Printing array using foreach loop

using System;
 
namespace Loop
{
    class ForEachLoop1
    {
        public static void Main(string[] args)
        {
            char[] myArray = {'H','e','l','l','o'};
 
            // ForEach Loop 
            foreach(char ch in myArray)
            {
                Console.WriteLine(ch);
            }
        }
    }
}