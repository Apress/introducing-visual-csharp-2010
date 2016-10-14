using System;

class Product {
    public string Name { get; set; }
    public int ItemsInStock { get; set; }
    public double PricePerItem { get; set; }


    public static Product operator +(Product p1, Product p2) {
        return new Product() {
            Name = p1.Name,
            ItemsInStock = p1.ItemsInStock + p2.ItemsInStock,
            PricePerItem = p1.PricePerItem
        };
    }
}

class Listing_18_Test {

    static void Main(string[] args) {

        // create a new product
        Product p1 = new Product() {
            Name = "oranges",
            ItemsInStock = 10,
            PricePerItem = 20
        };

        // create a second product instance
        Product p2 = new Product() {
            Name = "oranges",
            ItemsInStock = 5,
            PricePerItem = 20
        };

        // use the postfix increment operator
        Product sum = p1 + p2;

        // print out the number of items in stock
        Console.WriteLine("Items in stock: {0}", sum.ItemsInStock);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

