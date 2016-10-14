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

class Listing_16 {

    static void Main(string[] args) {

        // create a data source containing Fruit objects
        List<Fruit> myFruitList = new List<Fruit>() {
            new Fruit("Cherry", "Red", 500),
            new Fruit("Apple", "Green", 230),
            new Fruit("Plum", "Red", 300),
            new Fruit("Banana", "Yellow", 100),
            new Fruit("Grape", "Green", 400)
        };

        // perform a query to generate XElements 
        IEnumerable<XElement> elements = from e in myFruitList
                                         select new XElement("Fruit",
                                             new XAttribute("Name", e.Name),
                                             new XAttribute("Color", e.Color),
                                             new XAttribute("StockLevel", e.ItemsInStock)
                                         );

        // create a root node to contain the query results
        XElement rootNode = new XElement("Fruits", elements);

        // print out the XML data
        Console.WriteLine(rootNode);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
