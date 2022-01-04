// Demonstrates Jagged Array 

using System;

class JaggedArray
{
    static void Main()
    {
        // Declare the array of two elements.
        int[][] myArray = new int[2][];

        // Initialize the elements.
        myArray[0] = new int[7] { 1, 3, 5, 7, 9 ,5,7};
        myArray[1] = new int[4] { 2, 4, 6, 8 };

        // Display the array elements.
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("Element({0}): ", i);

            for (int j = 0; j < myArray[i].Length; j++)
            {
                Console.Write("{0}{1}", myArray[i][j], j == (myArray[i].Length - 1) ? "" : " ");
            }
            
            Console.WriteLine();
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}