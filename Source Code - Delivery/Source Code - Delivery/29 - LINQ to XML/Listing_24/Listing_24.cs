using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Listing_24 {

    static void Main(string[] args) {

        // load the XML data
        XElement rootNode = XElement.Load(@"..\..\data.xml");

        // sort the XML data
        IEnumerable<XElement> results = from e in rootNode.Elements()
                                        orderby int.Parse(e.Element("StockLevel").Value)
                                        select e;

        // create a new root node
        XElement newRoot = new XElement("Fruits",
            new XAttribute("SortedBy", "StockLevel"),
            results);

        // print out the XML to the console
        Console.WriteLine(newRoot);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
