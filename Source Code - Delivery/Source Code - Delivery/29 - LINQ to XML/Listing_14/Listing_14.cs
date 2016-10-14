using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Listing_14 {

    static void Main(string[] args) {

        // load the XML data
        XElement rootNode = XElement.Load(@"..\..\data.xml");

        // get all of the nodes called StockLevel anywhere in the XML
        IEnumerable<XElement> stockElements = rootNode.Descendants("StockLevel");
        
        // enumerate the elements and change the name of each
        foreach (XElement elem in stockElements) {
            elem.Name = "ItemCount";
        }

        // print out the XML to the Console
        Console.WriteLine(rootNode);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}