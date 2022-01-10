// pass single dimensional array as an argument

using System;

class PassMultiDimArrayasArgument
{
    static void Print2DArray(int[,] myArray)
    {
        // Display the array elements.
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.WriteLine("Element({0},{1})={2}", i, j, myArray[i, j]);
            }
        }
    }
    static void Main()
    {
        // Pass the array as an argument.
        Print2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });
    }
}
