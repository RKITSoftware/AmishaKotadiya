using System;
using System.Collections;
namespace collectionsNongeneric_Queue
{
    class Nongeneric_Queue
    {
        static void Main(string[] args)
        {
            Queue objQueue = new Queue();
            objQueue.Enqueue("Amisha");
            objQueue.Enqueue("kotadiya");
            objQueue.Enqueue(20);
            objQueue.Enqueue(9.12);

            foreach (var elem in objQueue)
            {
                Console.WriteLine(elem);
            }
          /*Amisha
            kotadiya
            20
            9.12 */

            Console.WriteLine("Element at the top is: " + objQueue.Peek());
            //Element at the top is: Amisha

            Console.WriteLine("Does it contain no. 9.12: " + objQueue.Contains(9.12));
            //Does it contain no. 9.12: True

            objQueue.Dequeue();
            foreach (var elem in objQueue)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("Does it contain word Ami: " + objQueue.Contains("Ami"));
            //Does it contain word Ami: False

        }
    }
}
