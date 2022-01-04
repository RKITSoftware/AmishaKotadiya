using System;
using System.Collections.Generic;

namespace collectionsGeneric_Queue
{
    class Generic_Queue
    {
        static void Main(string[] args)
        {
            Queue<int> objQueue = new Queue<int>();
            for (int i = 1; i < 10; i++)
            {
                objQueue.Enqueue(i);

            }

            Console.WriteLine(string.Join(" ",objQueue));
            //123456789

            Console.WriteLine("No. of Elements in queue:" + objQueue.Count);
            //No. of Elements in queue:9

            Console.WriteLine("Does numbers contain 1:" + objQueue.Contains(1));
            //Does numbers contain 1:True

            
            //after popping it will not contain 1 as it was queue's last element
            Console.WriteLine("Element popped:" + objQueue.Dequeue());
            //Element popped:1

            Console.WriteLine("Does numbers contain 1:" + objQueue.Contains(1));
            //Does numbers contain 1:False

            Console.WriteLine("Element at the top is:" + objQueue.Peek());
            //Element at the top is:2

            foreach(object obj in objQueue)
            {
               Console.Write(obj+", "); 
            }


        }
    }
}