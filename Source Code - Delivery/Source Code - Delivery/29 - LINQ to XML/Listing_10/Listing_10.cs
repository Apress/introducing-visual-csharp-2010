using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Listing_10 {

    static void Main(string[] args) {

        // load the XML file using the static Load method
        XElement myRootElement = XElement.Load(@"..\..\fragment.xml");

        // print out the name of the root node
        Console.WriteLine("Root node name: {0}", myRootElement.Name);

        // get the child elements
        IEnumerable<XElement> elementsEnum = myRootElement.Elements();

        foreach (XElement elem in elementsEnum) {
            Console.WriteLine("Name: {0}, Value: {1}",
                elem.Name, elem.Value);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}