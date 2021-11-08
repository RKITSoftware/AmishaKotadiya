using System;

namespace exception_handling
{
    class DivideByZeroException
    {
        static void Main(string[] args)
        {
            int[] arr = { 200, 0, 20, 10 };

            try
            {

                // Try to generate an exception
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }

            // Catch block for attempt to divide by zero
            catch (DivideByZeroException e)
            {

                Console.WriteLine("Exception:"+e.Message);
            }

            // Finally block
            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
        }
    }
}

/*
Output:
Exception:Attempted to divide by zero.
200 0 20 10
*/