// pass single dimensional array as an argument

using System;

class PassArrayasArgument
{
    static void DisplayArray(string[] myArray)
    {
        Console.WriteLine(string.Join(" ", myArray));
    }
    // Change the array by reversing its elements.
    static void ChangeArray(string[] myArray) 
    {
        Array.Reverse(myArray);
    }
    static void ChangeArrayElements(string[] myArray)
    {
        // Change the value of the first three array elements.
        myArray[0] = "Mon";
        myArray[1] = "Wed";
        myArray[2] = "Fri";
    }

    static void Main()
    {
        // Declare and initialize an array.
        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        // Display the array elements.
        DisplayArray(weekDays);
        Console.WriteLine();

        // Reverse the array.
        ChangeArray(weekDays);
        // Display the array again to verify that it stays reversed.
        Console.WriteLine("Array weekDays after the call to ChangeArray:");
        DisplayArray(weekDays);
        Console.WriteLine();

        // Assign new values to individual array elements.
        ChangeArrayElements(weekDays);
        // Display the array again to verify that it has changed.
        Console.WriteLine("Array weekDays after the call to ChangeArrayElements:");
        DisplayArray(weekDays);
    }
}

/* output:
         Sun Mon Tue Wed Thu Fri Sat

        Array weekDays after the call to ChangeArray:
        Sat Fri Thu Wed Tue Mon Sun

        Array weekDays after the call to ChangeArrayElements:
        Mon Wed Fri Wed Tue Mon Sun
*/