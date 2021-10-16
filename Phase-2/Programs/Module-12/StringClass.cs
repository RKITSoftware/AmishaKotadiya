// Example of string variable and String class

using System;  
public class StringClass 
{  
    public static void Main(string[] args)  
    {  
        string str1 = "hello";  
  
        char[] chArray = { 'c', 's', 'h', 'a', 'r', 'p' };  
        string str2 = new string(chArray);  
         
        Console.WriteLine("String Variable : {0} ",str1);  
        Console.WriteLine("String Class    : {0} ",str2);  
    }  
}  