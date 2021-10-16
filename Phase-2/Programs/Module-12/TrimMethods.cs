// Example of trimStart, trimEnd, strUpper method

using System;   
          
    public class TrimMethods   
    {    
        public static void Main(string[] args)    
        {    

         //TrimStart Method
         Console.WriteLine("\nTrimStart() method : ");
         string str1 = "Hello C#";  
         char[] chStart = {'H'};  
         string str2 = str1.TrimStart(chStart);  
         Console.WriteLine(str2);  

         //TrimEnd method
         Console.WriteLine("\nTrimEnd() method : ");
         char[] chEnd = {'#'};  
         str2 = str1.TrimEnd(chEnd);  
         Console.WriteLine(str2); 
  
         //convert string into uppercase. 
         Console.WriteLine("\nstrUpper() method : ");
         string strUpper = "Hello C#";  
         string str3 = strUpper.ToUpper();  
         Console.WriteLine(str3);  

         }    
    }    