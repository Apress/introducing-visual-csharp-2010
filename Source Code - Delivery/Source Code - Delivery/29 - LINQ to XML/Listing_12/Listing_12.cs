using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Listing_11 {

    static void Main(string[] args) {

        // load the XML file using the static Load method
        XElement myRootElement = XElement.Load(@"..\..\fragment.xml");

        // get the child elements
        IEnumerable<XElement> elementsEnum = myRootElement.Elements();

        foreach (XElement elem in elementsEnum) {
            Console.WriteLine("Element - Name: {0}, Value: {1}",
                elem.Name, elem.Value);
        }

        // get the descendant elements
        IEnumerable<XElement> descendantEnum = myRootElement.Descendants();

        foreach (XElement elem in descendantEnum) {
            Console.WriteLine("Descendant - Name: {0}, Value: {1}",
                elem.Name, elem.Value);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}