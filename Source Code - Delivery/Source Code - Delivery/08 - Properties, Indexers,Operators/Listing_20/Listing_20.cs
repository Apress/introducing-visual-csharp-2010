using System;

class Product {
    public string Name { get; set; }
    public int ItemsInStock { get; set; }
    public double PricePerItem { get; set; }


    public static int operator +(Product p1, string str) {
        return p1.ItemsInStock + int.Parse(str);
    }
}

class Listing_20_Test {

    static void Main(string[] args) {

        // create a new product
        Product p1 = new Product() {
            Name = "oranges",
            ItemsInStock = 10,
            PricePerItem = 20
        };

        // use the postfix increment operator
        int result = p1 + "20";

        // print out the number of items in stock
        Console.WriteLine("Items in stock: {0}", result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

