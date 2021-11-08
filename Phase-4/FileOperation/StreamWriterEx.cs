using System.IO;
using System;
class StreamWriterEx
{
       static void Main(string[] args)
       {
          string filePath = @"C:\Users\SSC\Desktop\RKIT\Phase-4\FileOperation\Test1.txt";

            // Write into Test1 file
            StreamWriter objWriter = new StreamWriter(filePath);

            Console.WriteLine("\nEnter text to write in Test1 file:");
            //this takes user input in string variable
            string str = Console.ReadLine();
            //Then we write the text to take in the buffer
            objWriter.WriteLine(str);
            //writes the stream into file and clears buffer
            objWriter.Flush();
            //closes the stream and stream object
            objWriter.Close();
        }
}

/*
Output:
Enter text to write in Test1 file:
abcd
*/
