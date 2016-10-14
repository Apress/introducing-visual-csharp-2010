using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Listing_07 {

    static void Main(string[] args) {

        // create an array of XElements
        List<XElement> myElements = new List<XElement>() {
            new XElement("Name", "Orange"),
            new XElement("Size", "Large"),
            new XElement("ItemsInStock", 250),
        };

        // create an element using the array
        XElement myFruit = new XElement("Fruit", myElements);

        // print out the XElement object
        Console.WriteLine(myFruit);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}