// TimeSpan Exapmle

using System;   
  
namespace DateTimeEx  
{  
    class TimeSpanEx  
    {  
        static void Main(string[] args)  
        { 

            //6 days, 8 hours, 12 minutes, and 35 seconds
            TimeSpan objTimeSpan = new TimeSpan(6, 8, 12, 35);
            Console.WriteLine("\nTimeSapn(6,8,12,35) : {0}",objTimeSpan); //6.08:12:35

            //Calculations with DateTime and TimeSpan
            DateTime objStartDate = new DateTime(2020, 11, 10, 9, 35, 0);
            Console.WriteLine("\nStart Date and Time : {0}",objstartDate);

            DateTime objEndDate = new DateTime(2020, 11, 14, 15, 10, 20);
            Console.WriteLine("End Date and Time : {0}",objEndDate);

            TimeSpan duration = endDate - startDate;
            Console.WriteLine("\nCalculations with DateTime and TimeSpan : {0}",duration); //4.05:35:20

        }  
    }  
}  