// Display Date and Time

using System;   
  
namespace DateTimeEx  
{  
    class DateTimeDisplay  
    {  
        static void Main(string[] args)  
        {  
  
            DateTime objDateTimeProperty = new DateTime(1974, 7, 10, 7, 10, 24);  
            
            // Display All date and time
            Console.WriteLine("all Date and Time:{0}", objDateTimeProperty);

            // Display Day
            Console.WriteLine("\nDay:{0}",objDateTimeProperty.Day);  

            // Display Month
            Console.WriteLine("Month:{0}", objDateTimeProperty.Month); 

            // Display Year 
            Console.WriteLine("Year:{0}", objDateTimeProperty.Year);  

            // Display Hour
            Console.WriteLine("Hour:{0}", objDateTimeProperty.Hour);  

            // Display Minute
            Console.WriteLine("Minute:{0}", objDateTimeProperty.Minute);  

            // Display Second
            Console.WriteLine("Second:{0}", objDateTimeProperty.Second);  

            // Display Millisecond
            Console.WriteLine("Millisecond:{0}", objDateTimeProperty.Millisecond);  

            // Display Day of Week
            Console.WriteLine("Day of Week:{0}", objDateTimeProperty.DayOfWeek);  

            // Display Day of Year
            Console.WriteLine("Day of Year: {0}", objDateTimeProperty.DayOfYear);  

            // Display Time of Day
            Console.WriteLine("Time of Day:{0}", objDateTimeProperty.TimeOfDay);  

            // Display Tick
            Console.WriteLine("Tick:{0}", objDateTimeProperty.Ticks);  

            // Display Kind
            Console.WriteLine("Kind:{0}", objDateTimeProperty.Kind);  

            // Display Short Date
            var display = DateTime.Now.ToShortDateString();
            Console.WriteLine(display); //15-Oct-21

            // Display Short Time
            var displayTime = DateTime.Now.ToShortTimeString();
            Console.WriteLine(displayTime); //11:04 AM

            // Display Long Date
            var longDisplay = DateTime.Now.ToLongDateString();
            Console.WriteLine(longDisplay); //Friday, 15 October, 2021

            // Display Long Time
            var longDisplayTime = DateTime.Now.ToLongTimeString();
            Console.WriteLine(longDisplayTime); //11:04:10 AM

        }  
    }  
}  




