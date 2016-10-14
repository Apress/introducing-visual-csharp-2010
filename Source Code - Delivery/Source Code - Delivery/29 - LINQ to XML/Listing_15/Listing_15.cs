using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Listing_15 {

    static void Main(string[] args) {

        // load the XML data
        XElement rootNode = XElement.Load(@"..\..\data.xml");

        // perform a query on the XML
        var results = from fruit in rootNode.Elements()
                      let stockLevel = int.Parse(fruit.Element("StockLevel").Value)
                      where stockLevel < 250
                      select new {
                          Name = fruit.Element("Name").Value,
                          Count = stockLevel
                      };

        // write out the results
        Console.WriteLine("Fruits that are low on stock:");
        foreach (var item in results) {
            Console.WriteLine("Name: {0}, Current Stock: {1}", 
                item.Name, item.Count);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
