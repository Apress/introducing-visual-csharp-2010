using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Fruit {

    public Fruit(string nameParam, string colorParam, int stockParam) {
        Name = nameParam;
        Color = colorParam;
        ItemsInStock = stockParam;
    }

    public string Name { get; set; }
    public string Color { get; set; }
    public int ItemsInStock { get; set; }
}

class Listing_18 {

    static void Main(string[] args) {

        // load the XML to create an XElement
        XElement rootNode = XElement.Load(@"..\..\data.xml");

        // query the XML 
        IEnumerable<Fruit> results =
                from e in rootNode.Elements()
                select new Fruit(
                    e.Element("Name").Value,
                    e.Element("Color").Value,
                    int.Parse(e.Element("StockLevel").Value)
                );


        // enumerate the results
        foreach (Fruit f in results) {
            Console.WriteLine("Name: {0}, Color: {1}, Stock: {2}",
                f.Name, f.Color, f.ItemsInStock);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
