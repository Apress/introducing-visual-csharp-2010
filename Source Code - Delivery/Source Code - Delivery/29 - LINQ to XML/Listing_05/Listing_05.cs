using System;
using System.Xml.Linq;

class Listing_05 {

    static void Main(string[] args) {

        // create an XElement
        XElement myElement = new XElement("ElementName", "ElementValue");

        // create an attribute
        XAttribute myAttribute = new XAttribute("AttributeName", "AttributeValue");

        // create a comment
        XComment myComment = new XComment("This is a comment");

        // add the nodes to a parent element
        XElement myParentElement = new XElement("ParentElement",
            myElement, myAttribute, myComment);

        // write out the contents of the parent element
        Console.WriteLine(myParentElement);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
