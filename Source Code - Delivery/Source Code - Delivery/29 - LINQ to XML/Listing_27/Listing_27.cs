using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Listing_27 {

    static void Main(string[] args) {

        // load the XML data
        XElement rootNode = XElement.Load(@"..\..\data.xml");

        // process the XML elements
        rootNode.Elements()
            .AsParallel()
            .Where(e => e.Element("Color").Value == "Red")
            .ForAll(e => {
                // remove the StockLevel element
                e.Element("StockLevel").Remove();
                // move the Color element to be an attribute
                XElement colorElem = e.Element("Color");
                e.Element("Name").Add(new XAttribute("Color", colorElem.Value));
                colorElem.Remove();
            });

        // print out the XML to the console
        Console.WriteLine(rootNode);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
