using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Listing_22 {

    static void Main(string[] args) {

        // load the XML data
        XElement rootNode = XElement.Load(@"..\..\data.xml");

        IEnumerable<XElement> results = from e in rootNode.Elements()
                    select new XElement(e.Name,
                        new XAttribute("Name", e.Element("Name").Value),
                        new XAttribute("Color", e.Element("Color").Value),
                        new XAttribute("StockLevel", e.Element("StockLevel").Value));

        // assign to a root node and print out the XML to the console
        Console.WriteLine(new XElement("Fruits", results));

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
