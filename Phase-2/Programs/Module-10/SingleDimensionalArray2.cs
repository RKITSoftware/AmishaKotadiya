// Demonstrates Single Dimensional Array

using System;  

public class SingleDimensionalArray2  
{  
    public static void Main(string[] args)  
    {  
        //creating array  
        int[] arr = new int[5];

        //initializing array  
        arr[0] = 10;
        arr[2] = 20;  
        arr[4] = 30;  
  
        //traversing array  
        for (int i = 0; i < arr.Length; i++)  
        {  
            Console.WriteLine(arr[i]);  
        }  
    }  
}  