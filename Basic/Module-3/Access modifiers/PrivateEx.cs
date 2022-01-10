using System;

namespace PrivateAccessModifier
{
    class Parent
    {
        // Member is declared as private  
        private string name;
        // value is Accessible only inside the class 
        public void setValue(string nm)
        {
            name = nm;
        }
        public string getValue()
        {
            return name;
        }
    }
    class Child : Parent
    {
        public void showValue()
        {
            // Trying to access value Inside a derived class 
            // Console.WriteLine( "Value = " + value ); 
            // Gives an error 
        }
    }

    class PrivateEx
    {
        //Main method
        static void Main(string[] args)
        {
            Parent objParent = new Parent();
            // objp.value = 15; 
            // Also gives an error 
            // Use public functions to assign and use value of the member 'value' 
            objParent.setValue("Amisha Kotadiya");
            Console.WriteLine("Name = " + objParent.getValue());
            Console.Read();

        }
    }
}