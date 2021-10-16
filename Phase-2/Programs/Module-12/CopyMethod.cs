// Example of copy, copyTo method

using System;    
    public class CopyMethod    
    {    
        public static void Main(string[] args)    
        {    
            // copy string
             string str1 = "Hello ";    
             string str2 = string.Copy(str1);  
             Console.WriteLine("Original string : {0}",str1);  
             Console.WriteLine("Copy string  : {0}",str2);  

            //It copies the characters of this string into a char array. 
             string str3 = "Hello C#, How Are You?";    
             char[] chArray = new char[15];
             str3.CopyTo(10,chArray,0,12);     
             Console.WriteLine(chArray);
        }    
    }    