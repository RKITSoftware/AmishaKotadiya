// Example of clone method

using System;

    public class CloneMethod   
    {    
        public static void Main(string[] args)    
        {    
             string str1 = "Hello ";    
             string str2 = (String)str1.Clone();    
             Console.WriteLine("Original String1 : {0}",str1);  
             Console.WriteLine("Clone string2    : {0}",str2); 

             Console.ReadKey();
        }    
    }    