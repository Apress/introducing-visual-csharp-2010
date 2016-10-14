using System;

class Product {
    private int unitsInStock;
    private double pricePerItem;

   
    public int ItemsInStock {
        get { return unitsInStock; }
    }

    public double PricePerItem {
        set { pricePerItem = value; }
    }
}

class Listing_05 {

    static void Main(string[] args) {

        // create a new instance of the Product class
        Product prod = new Product();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

