using System;

namespace UserDefinedException 
{
   class UserDefineExceptionEx
   {
      static void Main(string[] args) 
      {
         Temperature objTemp = new Temperature();
         
         // Try to generate an exception
         try 
         {
            objTemp.showTemp();
         } 

         // Catch block
         catch(TempIsZeroException e) 
         {
            Console.WriteLine("TempIsZeroException: {0}", e.Message);
         }
         Console.ReadKey();
      }
   }
}

// UserDefine exception
public class TempIsZeroException: Exception 
{
   public TempIsZeroException(string message): base(message) 
   {}
}

public class Temperature 
{
   int temperature = 0;
   
   public void showTemp() 
   {      
      if(temperature == 0) 
      {
        // throw Exception
        throw (new TempIsZeroException("Zero Temperature found"));
      } 
      else 
      {
        Console.WriteLine("Temperature: {0}", temperature);
      }
   }
}

/*
Output:
TempIsZeroException: Zero Temperature found
*/