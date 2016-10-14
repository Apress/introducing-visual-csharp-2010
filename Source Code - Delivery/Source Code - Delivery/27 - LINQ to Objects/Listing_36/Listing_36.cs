using System;
using System.Collections.Generic;
using System.Linq;

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

class Listing_36 {

    static void Main(string[] args) {

        // create a data source containing Fruit objects
        List<Fruit> myFruitList = new List<Fruit>() {
            new Fruit("Cherry", "Red", 500),
            new Fruit("Apple", "Green", 230),
            new Fruit("Plum", "Red", 300),
            new Fruit("Banana", "Yellow", 100),
            new Fruit("Grape", "Green", 400)
        };

        // perform the query
        IEnumerable<string> results = from e in myFruitList
                                      let nameLength = e.Name.Length
                                      let lowStock = e.ItemsInStock < 200
                                      where nameLength > 4 && lowStock
                                      select e.Name;

        // enumerate the results
        foreach (string str in results) {
            Console.WriteLine("Result: {0}", str);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}