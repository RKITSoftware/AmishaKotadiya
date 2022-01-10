// Example of concate method

using System;    
    
public class ConcateMethod    
{    
    public static void Main(string[] args)    
    {    
        string str1 = "Hello ";    
        string str2 = "C#";    
        Console.WriteLine("Concate {0}and {1} : {2}",str1,str2,string.Concat(str1,str2));    
    }    
}    