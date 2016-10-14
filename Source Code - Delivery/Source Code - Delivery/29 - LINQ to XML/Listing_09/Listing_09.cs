using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Listing_09 {

    static void Main(string[] args) {

        // load the XML file using the static Load method
        XElement myRootElement = XElement.Load("fragment.xml");

        // print out the XElement
        Console.WriteLine(myRootElement);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}