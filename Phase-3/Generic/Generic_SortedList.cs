using System;
using System.Collections.Generic;

namespace collectionsGeneric_SortedList
{
    class Generic_SortedList
    {
        static void Main(string[] args)
        {
            SortedList<int, string> objSortedlist = new SortedList<int, string>()
            {
                {4,"aaa" },
                {3,"bbb" },
                {1,"ccc" }
            };

            objSortedlist.Add(2, "ddd");
            foreach(KeyValuePair<int,string> objkvp in objSortedlist)
            {
                Console.WriteLine("Rank is: "+objkvp.Key+" Student: "+objkvp.Value);
            }
            /*  output-
            Rank is: 1 Student: ccc
            Rank is: 2 Student: ddd
            Rank is: 3 Student: bbb
            Rank is: 4 Student: aaa  */

            Console.WriteLine();
            if (objSortedlist.ContainsKey(3))
            {
                objSortedlist[3] = "bbb";
            }
            Console.WriteLine("Rank is: " + 3 + " Student: " + objSortedlist[3]);
            // Rank is: 3 Student: bbb

            objSortedlist.RemoveAt(1);
            Console.WriteLine();

            foreach (KeyValuePair<int, string> objkvp in objSortedlist)
            {
                Console.WriteLine("Rank is: " + objkvp.Key + " Student: " + objkvp.Value);
            }
            /*  output-
            Rank is: 1 Student: ccc
            Rank is: 3 Student: bbb
            Rank is: 4 Student: aaa */

        }
    }
}