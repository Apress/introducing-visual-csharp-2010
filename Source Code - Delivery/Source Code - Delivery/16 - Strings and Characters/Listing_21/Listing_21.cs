using System;
using System.Text;

class Listing_21 {

    static void Main(string[] args) {

        // define a string with format items
        string formatString = "My name is: {0}";

        // use the static string.Format method
        string outputString = string.Format(formatString, "Adam");
        Console.WriteLine("String.Format: {0}", outputString);

        // create an empty StringBuilder 
        StringBuilder myBuilder = new StringBuilder();
        
        // append and format the string in one step
        myBuilder.AppendFormat(formatString, "Jane");
        Console.WriteLine("StringBuilder.AppendFormat: {0}", myBuilder);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}