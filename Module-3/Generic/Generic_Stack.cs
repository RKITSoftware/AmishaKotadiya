using System;
using System.Collections.Generic;

namespace collectionsGeneric_Stack
{
    class Generic_Stack
    {
        static void Main(string[] args)
        {
            Stack<int> objStack = new Stack<int>();
            for (int i=0;i<10;i++)
            {
                objStack.Push(i);
            }
            Console.WriteLine("No. of Elements in stack:"+objStack.Count);
            //No. of Elements in stack:10

            Console.WriteLine("Does numbers contain 9:"+objStack.Contains(9));
            //Does numbers contain 9:True

            objStack.Pop();
            //after popping it will not contain 9 as it was stack's last element

            Console.WriteLine("Does numbers contain 9:" + objStack.Contains(9));
            //Does numbers contain 9:False

            Console.WriteLine("Element at the top is:"+ objStack.Peek());
            //Element at the top is:8

            foreach(object obj in objStack)
            {
               Console.Write(obj+", "); 
            }


        }
    }
}