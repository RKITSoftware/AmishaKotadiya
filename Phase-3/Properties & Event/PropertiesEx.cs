using System;

namespace PropertiesExample
{
     class User
     {
        private string location;
        private string name = "Amisha Kotadiya";
        public int Age { get; set; }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Name
        {
           get
           {
               return name.ToUpper();
           }
           set
           {
               if (value == "Amisha")
                  name = value;
           }
        }
     }
     class PropertiesEx
     {
        static void Main(string[] args)
        {
            User objUser = new User();
            // set accessor will invoke
            objUser.Name = "Ami";
            // set accessor will invoke
            objUser.Location = "Lalpur";
            // set accessor will invoke
            objUser.Age=21;
            // get accessor will invoke
            Console.WriteLine("Name: " + objUser.Name);
            // get accessor will invoke
            Console.WriteLine("Location: " + objUser.Location);
            // get accessor will invoke
            Console.WriteLine("Age: " + objUser.Age);
            
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
     }
}

/*
Name: AMISHA KOTADIYA
Location: Lalpur
Age: 21
*/