using System;
using System.Xml.Linq;

class Listing_01 {

    static void Main(string[] args) {

        // create XElements
        XElement myNameElement = new XElement("Name", "Orange");
        XElement mySizeElement = new XElement("Size", "Large");

        // print out the XElement objects
        Console.WriteLine(myNameElement);
        Console.WriteLine(mySizeElement);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}