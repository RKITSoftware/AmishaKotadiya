// Example of Endswith, euals, getType, indexOf, insert, remove method

using System;    
public class StringMethods    
{    
    public static void Main(string[] args)    
    {    
         
         string str1 = "Hello";    
         string str2 = "llo";  
         string str3 = "C#";  
         string str4 = "Hello";
         string str5 = "Hello c#";

         //check whether the specified string matches the end of this string or not.
         Console.WriteLine("\nEndsWith() method : ");
         Console.WriteLine("String {0} endwith {1} : {2}",str1,str2,str1.EndsWith(str2));  
         Console.WriteLine("String {0} endwith {1} : {2}",str1,str3,str1.EndsWith(str3));  

         //compare two strings on the basis of content.
         Console.WriteLine("\nEndsWith() method : ");
         Console.WriteLine("String {0} equals {1} : {2}",str1,str2,str1.Equals(str2));  
         Console.WriteLine("String {0} equals {1} : {2}",str1,str4,str1.Equals(str4));  

         //method is used to get type of current object.
         Console.WriteLine("\nGetType() method : ");
         Console.WriteLine("get type of {0} : {1} ",str1,str1.GetType()); 

         //get index of the specified character present in the string.
         Console.WriteLine("\nIndexOf() method : ");
         int index = str1.IndexOf('e');  
         Console.WriteLine("string: {0}\nIndexOf e : {1}",str1,index);  
         
         //insert the specified string at specified index number
         Console.WriteLine("\nInsert() method : ");
         string str6 = str5.Insert(5," -");  
         Console.WriteLine(str6);  

         //get a new string after removing all the characters from specified beginIndex till given length.
         // If length is not specified, it removes all the characters after beginIndex.
         Console.WriteLine("\nRemove() method : ");
         str2 = str1.Remove(2);  
         Console.WriteLine(str2); 
    }
}    