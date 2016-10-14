using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Fruit {

    public Fruit(string nameParam, int codeParam) {
        Name = nameParam;
        StockCode = codeParam;
    }

    public string Name { get; set; }
    public int StockCode { get; set; }
}

class StockRecord {

    public StockRecord(int codeParam, int stockParam) {
        StockCode = codeParam;
        ItemsInStock = stockParam;
    }

    public int StockCode { get; set; }
    public int ItemsInStock { get; set; }
}

class Listing_33 {

    static void Main(string[] args) {

        // create an array of Fruit objects
        Fruit[] fruitArray = new Fruit[] {
            new Fruit("apple", 100), new Fruit("plum", 101), new Fruit("cherry", 102)};

        // create an array of StockRecords
        StockRecord[] stockRecords = new StockRecord[] {
            new StockRecord(100, 50), new StockRecord(101, 10), new StockRecord(102, 500)};
        
        // define the query
        var results = from fruit in fruitArray
                     join stock in stockRecords on fruit.StockCode equals stock.StockCode
                     select new {
                         Name = fruit.Name,
                         StockCode = fruit.StockCode,
                         ItemsInStock = stock.ItemsInStock
                     };

        // enumerate the results
        foreach (var item in results) {
            Console.WriteLine("Name: {0}, Code: {1} Stock Level: {2}",
                item.Name, item.StockCode, item.ItemsInStock);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}