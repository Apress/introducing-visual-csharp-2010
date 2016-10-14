using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Listing_25 {

    static void Main(string[] args) {

        // load the XML data
        XElement rootNode = XElement.Load(@"..\..\data.xml");

        // sort the XML data
        IEnumerable<IGrouping<string, XElement>> results =
            from e in rootNode.Elements()
            group e by e.Element("Color").Value;

        // define a new root node
        XElement newRoot = new XElement("Fruits");

        foreach (IGrouping<string, XElement> group in results) {
            newRoot.Add(new XElement(string.Format("{0}Fruits", group.Key), group));
        }

        // print out the XML to the console
        Console.WriteLine(newRoot);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
