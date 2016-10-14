using System;


interface ISalesItem {

    int PricePerItem();

}

public struct Product : ISalesItem {
    public int CasesInStock;
    public int ItemsPerCase;

    public Product(int cases, int itemspc) {
        CasesInStock = cases;
        ItemsPerCase = itemspc;
    }

    public int PricePerItem() {
        return 100;
    }
}


class Listing_18_Test {

    static void Main(string[] args) {

        // create a new struct value and upcast to the interface type
        ISalesItem salesItem = new Product(10, 10);

        // call the method specified in the interface
        int price = salesItem.PricePerItem();
        Console.WriteLine("Price per item: {0}", price);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

