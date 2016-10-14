using System;

class Product {
    public string Name { get; set; }
    public int ItemsInStock { get; set; }
    public double PricePerItem { get; set; }


    public static implicit operator string(Product p) {
        return p.Name;
    }
}

class Listing_21_Test {

    static void Main(string[] args) {

        // create a new product
        Product p1 = new Product() {
            Name = "oranges",
            ItemsInStock = 10,
            PricePerItem = 20
        };

        // assign the product to a string variable
        string str = p1;

        // print out the local variable
        Console.WriteLine("String result: {0}", str);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

