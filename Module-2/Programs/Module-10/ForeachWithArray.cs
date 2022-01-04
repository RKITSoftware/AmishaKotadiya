// demonstrates foreach with SingleDimensionalArray and MultiDimensionalArray

using system;

class ForeachWithArray
{
    public static void main(String Args[])
    {
        // foreach with Single DimensionalArray
        int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
        foreach (int i in numbers)
        {
            Console.Write("{0} ", i);
        }
        
        //foreach with Multi DimensionalArray
        int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };

        foreach (int i in numbers2D)
        {
            System.Console.Write("{0}{1} ", i);
        }
    }
}