using System;

class Product {

    public int ItemsInStock {
        get;
        set; 
    }
}

class Listing_04 {

    static void Main(string[] args) {

        // create a new instance of the Product class
        Product prod = new Product();

        // set the value of the fields
        prod.ItemsInStock = 20;

        Console.WriteLine("Items in stock: {0}", prod.ItemsInStock);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

