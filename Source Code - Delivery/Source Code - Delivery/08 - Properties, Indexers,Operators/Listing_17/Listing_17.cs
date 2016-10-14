using System;

class Product {
    public string Name { get; set; }
    public int ItemsInStock { get; set; }
    public double PricePerItem { get; set; }


    public static Product operator ++(Product p) {
        p.ItemsInStock++;
        return p;
    }
}

class Listing_17_Test {

    static void Main(string[] args) {

        // create a new product
        Product p = new Product() {
            Name = "oranges",
            ItemsInStock = 10,
            PricePerItem = 20
        };

        // use the postfix increment operator
        p++;
   
        // print out the number of items in stock
        Console.WriteLine("Items in stock: {0}", p.ItemsInStock);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

