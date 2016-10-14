using System;

class Product {
    public int ItemsInStock;
    public double PricePerItem;

    public double GetTotalValueOfStock() {
        return ItemsInStock * PricePerItem;
    }
}

class Listing_01 {

    static void Main(string[] args) {

        // create a new instance of the Product class
        Product prod = new Product();

        // set the value of the fields
        prod.ItemsInStock = -20;
        prod.PricePerItem = 5.23;

        // get the total value of the products in stock
        Console.WriteLine("Total stock value: {0}", prod.GetTotalValueOfStock());

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

