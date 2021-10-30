using System;
    
using System.Collections.Generic;

namespace collectionsGeneric_List
{
    class Generic_List
    {
        static void Main(string[] args)
        {
            List<int> objList1 = new List<int>();

            Console.WriteLine("*********List1 Elements********");        
            int[] array = { 1, 2, 3, 4, 5};
            int[] newarray = { 6, 7, 8 };
            objList1.AddRange(array);
            objList1.Remove(5);           
            foreach (int integer in objList1)
            {
                Console.Write(integer + ",");
            }
            //output - 1,2,3,4,

            Console.WriteLine();
            Console.WriteLine("Does arraylist contains 2:" + objList1.Contains(2));
            //Does arraylist contains 4:True

            objList1.InsertRange(4, newarray);
            
            // Removing 2 elements starting from index 3
            objList1.RemoveRange(3,2);
            foreach (int integer in objList1)
            {
                Console.Write(integer + ",");
            }
            //output - 1,2,3,4,6,7,8,
            objList1.RemoveRange(3,2);
            Console.WriteLine();

            Console.WriteLine("\n*********List2 Elements********");
            List<string> objList2 = new List<string>();
            objList2.Add("Hi");
            objList2.Add("Welcome");
            
            foreach (var item in objList2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List2 Elements Count: " + objList2.Count);
        }
    }
}
