using System;

namespace EnumeratorExample
{
     class EnumeratorEx
     {
        enum Week
        {
            // the sequence of elements is forced to start from 10 instead of 0
            Sunday=11,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            //get an enum item value using a cast to convert from enum to int.
            int varSun = (int)Week.Sunday;
            int varMon = (int)Week.Monday;
            int varTue = (int)Week.Tuesday;

            //print name of enum
            Console.WriteLine(Week.Sunday);
            Console.WriteLine(Week.Monday);

            // print value of enum
            Console.WriteLine("Sunday: {0}", varSun);
            Console.WriteLine("Monday: {0}", varMon);
            Console.WriteLine("Tuesday: {0}", varTue);

            // GetNames() method is useful to get all item names of the specified enum as an array.
            Console.WriteLine("Week Enumeration names");
            foreach (string varWeek in Enum.GetNames(typeof(Week)))
            {
                Console.WriteLine(varWeek);
            }

            // GetValues() method is useful to get all item values of the specified enum as an array.
            Console.WriteLine("Week Enumeration values");
            foreach (int varWeek in Enum.GetValues(typeof(Week)))
            {
                Console.WriteLine(varWeek);
            }

            Console.ReadLine();
        }
     }
}

/*
Output:
Sunday
Monday
Sunday: 11
Monday: 12
Tuesday: 13
Week Enumeration names
Sunday
Monday
Tuesday
Wednesday
Thursday
Friday
Saturday
Week Enumeration values
11
12
13
14
15
16
17
*/