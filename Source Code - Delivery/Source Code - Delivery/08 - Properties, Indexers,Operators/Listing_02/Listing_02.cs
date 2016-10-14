using System;

class Product {
    private int itemsInStock;
    public double PricePerItem;

    public int ItemsInStock {

        get { return itemsInStock; }

        set {
            if (value >= 0) {
                itemsInStock = value;
            } else {
                throw new ArgumentOutOfRangeException();
            }
        }

    }

    public double GetTotalValueOfStock() {
        return itemsInStock * PricePerItem;
    }
}

class Listing_02 {

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

