// Example of contains method

using System;    
    public class ContainsMethod    
    {    
        public static void Main(string[] args)    
        {    
             string str1 = "Hello ";    
             string str2 = "He";  
             string str3 = "Hi";  
             Console.WriteLine("Contains {0} and {1} : {2}",str1,str2,str1.Contains(str2));  
             Console.WriteLine("Contains {0} and {1} : {2}",str1,str3,str1.Contains(str3));    
        }    
    }    