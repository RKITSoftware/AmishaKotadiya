using System;
using System.Collections.Generic;

namespace ListExceptionExample
{
    class ListException
    {
        static void Main(string[] args)
        {
            List<string> objList = new List<string>(){"John", "Cena"};

                try
                {
                    // Try to generate an exception
                    for(var i=0; i<=objList.Count; i++)
                    {
                        Console.WriteLine(objList[i]);
                    }
                }

                // Catch block for value being out of range
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Exception:"+e.Message);

                    // throw exception
                    throw(new ArgumentOutOfRangeException("List Out of range"));
                }

                // Finally block
                finally
                {
                    Console.WriteLine("Final block");
                }
        }
    }
}

/*
Output:
John
Cena
Exception:Index was out of range. Must be non-negative and less than the size of the collection.
Parameter name: index

Unhandled Exception: System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
Parameter name: List Out of range
   at ListExceptionExample.ListException.Main(String[] args)
Final block
*/