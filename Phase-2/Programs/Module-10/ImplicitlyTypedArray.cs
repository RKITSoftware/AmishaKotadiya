// Demonstrate implicitly typed array

using System;

class ImplicitlyTypedArray
{
    static void Main()
    {
        var a = new[] { 1, 10, 100, 1000 }; // int[]
        var b = new[] { "hello", null, "world" }; // string[]

        // single-dimension jagged array
        var c = new[]
        {
            new[]{1,2,3,4},
            new[]{5,6,7,8}
        };

        // jagged array of strings
        var d = new[]
        {
            new[]{"Luca", "Mads", "Luke", "Dinesh"},
            new[]{"Karen", "Suma", "Frances"}
        };

        //Implicitly-typed Arrays in Object Initializers
        var contacts = new[]
        {
            new {
                Name = " Eugene Zabokritski",
                PhoneNumbers = new[] { "206-555-0108", "425-555-0001" }
            },
            new {
                Name = " Hanying Feng",
                PhoneNumbers = new[] { "650-555-0199" }
            }
        };
    }
}
