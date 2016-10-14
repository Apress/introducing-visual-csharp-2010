using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Listing_20 {

    static void Main(string[] args) {

        // load the XML data
        XElement rootNode = XElement.Load(@"..\..\data.xml");

        IEnumerable<string> results = from e in rootNode.Elements()
                                      select string.Format("{0},{1},{2}",
                                            e.Element("Name").Value,
                                            e.Element("Color").Value,
                                            e.Element("StockLevel").Value);

        // enumerate the strings
        foreach (string str in results) {
            Console.WriteLine(str);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
