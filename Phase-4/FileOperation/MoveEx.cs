using System;  
using System.IO;  
class MoveEx
{  
    public static void Main()   
    {  
        string path1 = @"C:\Users\SSC\Desktop\RKIT\Phase-4\FileOperation\Sample1.txt";  
        string path2 = @"C:\Users\SSC\Desktop\RKIT\Phase-4\FileOperation\Sample2.txt";
        try   
        {  
            if (!File.Exists(path1))   
            {  
                // This statement ensures that the file is created,  
                // but the handle is not kept.  
                using (FileStream fs = File.Create(path1)) {}  
            } 

            // Ensure that the target does not exist.  
            if (File.Exists(path2))
            {   
                File.Delete(path2);  
            }
            
            // Move the file.  
            File.Move(path1, path2);  
            Console.WriteLine("{0} was moved to {1}.", path1, path2);  
  
            // See if the original exists now.  
            if (File.Exists(path1))   
            {  
                Console.WriteLine("The original file still exists, which is unexpected.");  
            }   
            else   
            {  
                Console.WriteLine("The original file no longer exists, which is expected.");  
            }             
        }   
        catch (Exception e)   
        {  
            Console.WriteLine("The process failed: {0}", e.ToString());  
        }  
    }   
} 

/*
Output:
C:\Users\SSC\Desktop\RKIT\Phase-4\FileOperation\Sample1.txt was moved to C:\Users\SSC\Desktop\RKIT\Phase-4\FileOperation\Sample2.txt.
The original file no longer exists, which is expected.
*/