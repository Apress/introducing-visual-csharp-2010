using System;

public struct Product {
    private int casesInStock;
    private int itemsPerCase;

    public Product(int cases, int itemspc) {
        casesInStock = cases;
        itemsPerCase = itemspc;
    }

    public int CasesInStock {
        get {
            return casesInStock;
        }
        set {
            casesInStock = value;
        }
    }

    public int ItemsPerCase {
        get {
            return itemsPerCase;
        }
        set {
            itemsPerCase = value;
        }
    }

    public void PrintDetails() {
        Console.WriteLine("--- Product Details ---");
        Console.WriteLine("Cases In Stock: {0}", CasesInStock);
        Console.WriteLine("Items per Case: {0}", ItemsPerCase);
    }
}

class Listing_17 {

        static void Main(string[] args) {


            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
