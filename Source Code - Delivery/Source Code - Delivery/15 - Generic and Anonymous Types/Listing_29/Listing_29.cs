using System;

class Listing_29 {

    static void Main(string[] args) {

        // create a new anonymous type
        var myObject = new {
            Name = "Adam Freeman",
            Age = 38,
            City = "London"
        };

        // access the properties of the anonymous type
        Console.WriteLine("Name: {0}", myObject.Name);
        Console.WriteLine("Age: {0}", myObject.Age);
        Console.WriteLine("City: {0}", myObject.City);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
