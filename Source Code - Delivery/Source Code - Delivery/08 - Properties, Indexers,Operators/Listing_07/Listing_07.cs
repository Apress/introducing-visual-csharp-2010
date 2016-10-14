using System;

class Product {
    private double pricePerItem;

    public string PricePerItem {

        get {
            return string.Format("{0:0.00}", pricePerItem);
        }

        set {
            pricePerItem = double.Parse(value);
        }
    }
}

class Listing_07 {

    static void Main(string[] args) {

        // create a new instance of the Product class
        Product prod = new Product();

        // set the value of the property
        prod.PricePerItem = "5.23";

        // get the total value of the products in stock
        Console.WriteLine("PricePerItem: {0}", prod.PricePerItem);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

