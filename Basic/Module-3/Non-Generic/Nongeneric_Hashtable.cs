using System;
using System.Collections;

namespace collectionsNongeneric_Hashtable
{
    class Nongeneric_Hashtable
    {
        static void Main(string[] args)
        {
            var names = new Hashtable()
            {
                {"India","aaa,bbb,ccc" },
                {"Australia","ddd,eee,fff" }                
            };
            names.Add("England", "hhh,iii,jjj");

            foreach(DictionaryEntry de in names)
            {
                Console.WriteLine("Key: " + de.Key + " Value: " + de.Value);
            }

            /* 
            Key: Australia Value: ddd,eee,fff
            Key: India Value: aaa,bbb,ccc
            Key: England Value: hhh,iii,jjj 
            */

            Console.WriteLine();
            if(names.ContainsKey("Australia"))
            {
                names.Remove("Australia");
            }
            foreach (DictionaryEntry de in names)
            {
                Console.WriteLine("Key: " + de.Key + " Value: " + de.Value);
            }
            
            /*
            Key: India Value: aaa,bbb,ccc
            Key: England Value: hhh,iii,jjj 
            */
        }
    }
}