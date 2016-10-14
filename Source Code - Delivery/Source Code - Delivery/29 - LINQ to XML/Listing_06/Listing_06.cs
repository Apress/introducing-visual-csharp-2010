using System;
using System.Xml.Linq;

class Listing_06 {

    static void Main(string[] args) {

        XDeclaration myDeclaration = new XDeclaration("1.0", "utf-8", "yes");
        XDocumentType myDocType = new XDocumentType("FruitList", null, null, null);

        // create XElements
        XElement myNameElement = new XElement("Name", "Orange");
        XElement mySizeElement = new XElement("Size", "Large");

        // create my root element
        XElement myRootElement = new XElement("Fruit", myNameElement, mySizeElement);

        // create the XML document
        XDocument myDoc = new XDocument(
            myDeclaration,
            myDocType,
            myRootElement);

        // print out the XElement object
        Console.WriteLine(myDoc);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}