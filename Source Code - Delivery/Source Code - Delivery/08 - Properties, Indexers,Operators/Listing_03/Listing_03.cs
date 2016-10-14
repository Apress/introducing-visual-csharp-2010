using System;

class Product {
    private int itemsInStock;

    public int ItemsInStock {
        get { return itemsInStock; }
        set { itemsInStock = value; }
    }
}

class Listing_03 {

    static void Main(string[] args) {

        // create a new instance of the Product class
        Product prod = new Product();

        // set the value of the fields
        prod.ItemsInStock = 20;

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

