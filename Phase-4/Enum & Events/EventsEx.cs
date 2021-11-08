using System;

namespace EventExample
{
    class Maths
    {
       // Declare the delegate
       public delegate void SampleDelegate();
       //Declare an event
       public event SampleDelegate SampleEvent;
       public void Add(int a, int b)
       {
          // Calling event delegate to check subscription
          if (SampleEvent != null)
          {
             // Raise the event by using () operator
             SampleEvent();
             Console.WriteLine("Add Result: {0}", a + b);
          }
          else
          {
             Console.WriteLine("Not Subscribed to Event");
          }
       }
       public void Subtract(int x, int y)
       {
          // Calling event delegate to check subscription
          if (SampleEvent != null)
          {
              // Raise the event by using () operator
              SampleEvent();
              Console.WriteLine("Subtract Result: {0}", x - y);
          }
          else
          {
              Console.WriteLine("Not Subscribed to Event");
          }
       }
    }
    class Operations
    {
       Maths objMaths;
       public int a { get; set; }
       public int b { get; set; }
       public Operations(int x, int y)
       {
          objMaths = new Maths();
          // Subscribe to SampleEvent event
          objMaths.SampleEvent += SampleEventHandler;
          a = x;
          b = y;
       }
       // SampleEvent Handler
       public void SampleEventHandler()
       {
          Console.WriteLine("SampleEvent Handler: Calling Method");
       }
       public void AddOperation()
       {
          objMaths.Add(a, b);
       }
       public void SubOperation()
       {
          objMaths.Subtract(a, b);
       }
    }
    class EventEx
    {
       static void Main(string[] args)
       {
          Console.WriteLine("****Events Example****");
          Operations objOp = new Operations(10, 20);
          objOp.AddOperation();
          objOp.SubOperation();
          Console.ReadLine();
       }
    }
}

/*
Output:
****Events Example****
SampleEvent Handler: Calling Method
Add Result: 30
SampleEvent Handler: Calling Method
Subtract Result: -10
*/