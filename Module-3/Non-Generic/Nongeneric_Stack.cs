using System;
using System.Collections;
namespace collectionsNongeneric_Stack
{
    class Nongeneric_Stack
    {
        static void Main(string[] args)
        {
            Stack objStack = new Stack();
            objStack.Push("Amisha");
            objStack.Push("kotadiya");  
            objStack.Push(20);
            objStack.Push(9.12);

            foreach (var ele in objStack)
            {
                Console.WriteLine(ele);
            }
          /*9.12
            20
            kotadiya
            Amisha */

            Console.WriteLine("Element at the top is: "+objStack.Peek());
            //Element at the top is: 9.12

            Console.WriteLine("Does it contain no. 10: "+objStack.Contains(10));
            //Does it contain no. 10: False

            objStack.Pop();
            foreach (var ele in objStack)
            {
                Console.WriteLine(ele);
            }
          /*20
            kotadiya
            Amisha */
        
            Console.WriteLine("Does it contain double 9.12: "+objStack.Contains(9.12));
            //Does it contain double 9.12: False

        }
    }
}