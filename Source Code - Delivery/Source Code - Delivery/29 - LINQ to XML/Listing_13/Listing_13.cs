using System;
using System.Xml.Linq;

class Listing_13 {

    static void Main(string[] args) {

        // load the XML data
        XElement rootNode = XElement.Load(@"..\..\data.xml");

        // define the name of the elements we are going to make into attributes
        string[] elementNames = new string[] { "Name", "Color", "StockLevel" };

        // enumerate each element that belongs to the child node
        foreach (XElement elem in rootNode.Elements()) {
            // process each of the defined element names in turn
            foreach (string name in elementNames) {
                // get the element by name
                XElement subElement = elem.Element(name);
                // add an attribute to the parent element
                elem.Add(new XAttribute(subElement.Name, subElement.Value));
                // remove the sub element
                subElement.Remove();
            }
        }

        // print out the XML to the Console
        Console.WriteLine(rootNode);
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}