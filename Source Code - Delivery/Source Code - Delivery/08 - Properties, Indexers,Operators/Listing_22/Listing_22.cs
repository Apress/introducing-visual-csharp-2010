using System;

class Product {
    public string Name { get; set; }
    public int ItemsInStock { get; set; }
    public double PricePerItem { get; set; }

    public static explicit operator int(Product p) {
        return p.ItemsInStock;
    }
}

class Listing_22_Test {

    static void Main(string[] args) {

        // create a new product
        Product p1 = new Product() {
            Name = "oranges",
            ItemsInStock = 10,
            PricePerItem = 20
        };

        // assign the product to an int variable
        int i = (int)p1;

        // print out the local variable
        Console.WriteLine("Int result: {0}", i);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

