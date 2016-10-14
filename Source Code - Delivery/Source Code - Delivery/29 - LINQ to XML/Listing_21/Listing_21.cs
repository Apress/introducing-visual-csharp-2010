using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Listing_20 {

    static void Main(string[] args) {

        // define the CSV data
        string[] csvData = new string[] {
            "Cherry,Red,500",
            "Apple,Green,230",
            "Plum,Red,300",
            "Banana,Yellow,100",
            "Grape,Green,400"
        };

        IEnumerable<XElement> results = from e in csvData
                                        let elements = e.Split(',')
                                        where elements[1] == "Red"
                                        select new XElement("Fruit",
                                            new XElement("Name", elements[0]),
                                            new XElement("Color", elements[1]),
                                            new XElement("ItemsInStock", elements[2])
                                            );

        // assign the results to a root node
        XElement rootNode = new XElement("Fruits", results);

        // write the XML to the console
        Console.WriteLine(rootNode);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
