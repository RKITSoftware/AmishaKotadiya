// Example of compare, compareTo, compareOrdinal method

using System;

    public class CompareMethod   
    {    
        public static void Main(string[] args)    
        {    
            string str1 = "hello";    
            string str2 = "hello";    
            string str3 = "csharp";  
            string str4 = "mello";  
        
            //Compare methods
            Console.WriteLine("Compare {0} and {1} : {2}",str1,str2,string.Compare(str1,str2));   
            Console.WriteLine("Compare {0} and {1} : {2}",str2,str3,string.Compare(str2,str3));   
            Console.WriteLine("Compare {0} and {1} : {2}",str3,str4,string.Compare(str3,str4));   

            //s1==s2 returns 0  
            //s1>s2 returns positive number in difference  
            //s1<s2 returns negative number in difference  
            Console.WriteLine("CompareOrdinal {0} and {1} : {2}",str1,str2,string.CompareOrdinal(str1,str2));   
            Console.WriteLine("CompareOrdinal {0} and {1} : {2}",str1,str3,string.CompareOrdinal(str1,str3));   
            Console.WriteLine("CompareOrdinal {0} and {1} : {2}",str1,str4,string.CompareOrdinal(str1,str4));   

            //CompareTo methods
            Console.WriteLine("Compare {0} and {1} : {2}",str1,str2,str1.CompareTo(str2));   
            Console.WriteLine("Compare {0} and {1} : {2}",str2,str3,str2.CompareTo(str3));   
            Console.WriteLine("Compare {0} and {1} : {2}",str1,str4,str1.CompareTo(str4));   
        }    
    }    