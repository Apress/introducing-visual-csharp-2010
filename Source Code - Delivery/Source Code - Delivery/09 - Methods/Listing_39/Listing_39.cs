using System;

class Listing_39 {
    private string message { get; set; }

    static void Main(string[] args) {

        // in order to be able to read and write the 
        // message property, we need to create a new
        // instance of this class and access the property
        // using the reference and the dot operator
        Listing_39 l39 = new Listing_39();
        l39.message = "Hello";

        // print out the value of the property
        Console.WriteLine("Instance Property: {0}", l39.message);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}