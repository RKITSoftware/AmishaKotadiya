// Example of replace, startWith, subString method

using System;   
    public class ReplaceMethod    
    {    
        public static void Main(string[] args)    
        {  
           //replace method
           Console.WriteLine("\n\n**** Replace() method ****");  
           string str1 = "Hello F#";  
           string str2 = str1.Replace('F','C');  
           Console.WriteLine("string = {0} \nF replace with C : {1}",str1,str2);  

           //to check whether the beginning of this string instance matches the specified string.
           Console.WriteLine("\n\n**** Startswith() method ****");  
           bool bool1 = str1.StartsWith("h");  
           bool bool2 = str1.StartsWith("H");  
           Console.WriteLine("String = {0} \nStarts with h : {1}",str1,bool1);  
           Console.WriteLine("String = {0} \nStarts with H : {1}",str1,bool2);  

           //to get a substring from a String. 
           //The substring starts at a specified character position and continues to the end of the string.
           Console.WriteLine("\n\n**** substring() method ****");  
           string str3 = "Hello C#";  
           string str4 = str3.Substring(5);  
           Console.WriteLine("substring = {0}",str4);
        }    
    }    