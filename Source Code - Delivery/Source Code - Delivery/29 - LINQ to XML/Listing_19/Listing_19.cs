using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class WeightInformation {

    public WeightInformation(string nameParam, float weightParam) {
        FruitName = nameParam; WeightInOunces = weightParam;
    }
    public string FruitName { get; set; }
    public float WeightInOunces { get; set; }
}

class Listing_19 {

    static void Main(string[] args) {

        // load the XML data
        XElement rootNode = XElement.Load(@"..\..\data.xml");

        // create a data source
        List<WeightInformation> weightList = new List<WeightInformation>() {
            new WeightInformation("Plum", 2.3f),
            new WeightInformation("Cherry", 0.3f)
        };

        IEnumerable<XElement> results = rootNode.Elements().Join(
            // define the second data source
            weightList,
            // select the key from the XML data
            e => e.Element("Name").Value,
            // select the key from the object data
            e => e.FruitName,
            // project a result
            (e, f) => {
                // duplicate the XElement so we don't modify the source data
                XElement duplicateElement = new XElement(e);
                // add an attribute for the weight
                duplicateElement.Add(new XAttribute("Weight", f.WeightInOunces));
                // return the duplicated and modified element
                return duplicateElement;
            });

        // create a structure around the query results
        XElement newRootNode = new XElement("Fruits", results);

        // print out the new XML
        Console.WriteLine(newRootNode);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
