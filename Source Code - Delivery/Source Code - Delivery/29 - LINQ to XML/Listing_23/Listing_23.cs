using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Listing_23 {

    static void Main(string[] args) {

        // load the XML data
        XElement rootNode = XElement.Load(@"..\..\data.xml");

        XElement newRoot = new XElement("Fruits",
            rootNode.Elements()
            .Where(e => e.Element("Color").Value == "Red")
            .Select(e => {
                XElement duplicateElem = new XElement(e);
                duplicateElem.Element("StockLevel").Name = "ItemCount";
                return duplicateElem;
            }));

        // print out the XML to the console
        Console.WriteLine(newRoot);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
