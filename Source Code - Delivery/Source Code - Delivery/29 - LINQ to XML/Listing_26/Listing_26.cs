using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Listing_26 {

    static void Main(string[] args) {

        // load the XML data
        XElement rootNode = XElement.Load(@"..\..\data.xml");

        // change the name of the StockLevel element to ItemsInStock
        rootNode.Descendants("StockLevel")
            .AsParallel()
            .ForAll(e => e.Name = "ItemsInStock");

        // print out the XML to the console
        Console.WriteLine(rootNode);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
