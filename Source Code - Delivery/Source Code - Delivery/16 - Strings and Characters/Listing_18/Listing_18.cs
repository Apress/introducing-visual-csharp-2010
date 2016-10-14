using System;
using System.Text;

class Listing_18 {

    static void Main(string[] args) {

        // create an empty StringBuilder object
        StringBuilder myBuilder = new StringBuilder();

        // append a string to the StringBuilder
        myBuilder.Append(" to C#");

        // insert a string into the StringBuilder
        myBuilder.Insert(0, "Introduction");

        // write out the StringBuilder
        Console.WriteLine("Contents: {0}", myBuilder);


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
