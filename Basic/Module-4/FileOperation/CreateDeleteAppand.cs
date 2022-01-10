using System.IO;
using System;

namespace TutlaneExamples
{
    class CreateDeleteAppand
    {
       static void Main(string[] args)
       {
          string filePath = @"C:\Users\SSC\Desktop\RKIT\Phase-4\FileOperation\Test1.txt";
          string duplicateFilePath = @"C:\Users\SSC\Desktop\RKIT\Phase-4\FileOperation\Test2.txt";
          // Check file if exists
          if (File.Exists(filePath))
          {

            //To copy one file into another and it also creates itself at other path given
            File.Copy(filePath, duplicateFilePath);
            Console.WriteLine("Test1 to Test2 File Copied ");

            //To append text in the duplicated file 
            using(StreamWriter objWriter = File.AppendText(duplicateFilePath))
            {
                objWriter.WriteLine();
                objWriter.WriteLine("This is Appended text");
                objWriter.WriteLine("Amisha");
            }
            Console.WriteLine("Test2 File Appended");

            //To read all the text from the duplicated file
            Console.WriteLine("\nTest2 File Read");
            using(StreamReader objReader = new StreamReader(duplicateFilePath))
            {
                string str = "";
                while((str=objReader.ReadLine())!=null)
                {
                    Console.WriteLine(str);
                }
            }    

            //Delete Test1.txt file
            //File.Delete(filePath);
            //Console.WriteLine("Test1 File Deleted"); 
          }
          else
          {
            // File 'Test' is created if file was not created.
            File.Create(filePath);
            Console.WriteLine("File 'Test1' is created");
            
          }        
       }
    }
}

/*
Output:
Test1 to Test2 File Copied
Test2 File Appended

Test2 File Read
abcd

This is Appended text
Amisha
*/