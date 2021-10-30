using System;
using System.Collections.Generic;

namespace collectionsGeneric_Dictionary
{
    class Generic_Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> objDictionary = new Dictionary<int, string>()
            {
                {4,"aaa" },
                {3,"bbb" },
                {1,"ccc" }
            };

            objDictionary.Add(2, "ddd");
            foreach(KeyValuePair<int,string> objkvp in objDictionary)
            {
                Console.WriteLine("Rank is: "+objkvp.Key+" Student: "+objkvp.Value);
            }
            /*  output-
            Rank is: 4 Student: aaa
            Rank is: 3 Student: bbb
            Rank is: 1 Student: ccc
            Rank is: 2 Student: ddd  */

            Console.WriteLine();
            if (objDictionary.ContainsKey(3))
            {
                objDictionary[3] = "bbb";
            }
            Console.WriteLine("Rank is: " + 3 + " Student: " + objDictionary[3]);
            // Rank is: 3 Student: bbb

            // Remove element with key (not index)
            objDictionary.Remove(1);
            Console.WriteLine();

            foreach (KeyValuePair<int, string> objkvp in objDictionary)
            {
                Console.WriteLine("Rank is: " + objkvp.Key + " Student: " + objkvp.Value);
            }
            /*  output-
            Rank is: 4 Student: aaa
            Rank is: 3 Student: bbb
            Rank is: 2 Student: ddd  */

        }
    }
}