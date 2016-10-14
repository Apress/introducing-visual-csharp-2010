using System;
using System.Xml.Linq;

class Listing_02 {

    static void Main(string[] args) {

        // create XElements
        XElement myNameElement = new XElement("Name", "Orange");
        XElement mySizeElement = new XElement("Size", "Large");

        // create a hierarchy of XElements
        XElement myFruit = new XElement("Fruit", myNameElement, mySizeElement);

        // print out the XElement object
        Console.WriteLine(myFruit);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}