using System;

class Listing_01 {

    static void Main(string[] args) {

        // define the product names
        string product1 = "oranges";
        string product2 = "apples";
        string product3 = "guava";
        string product4 = "cherry";
        string product5 = "strawberry";

        // select the product names > six chars
        CheckLengthAndPrintName(product1);
        CheckLengthAndPrintName(product2);
        CheckLengthAndPrintName(product3);
        CheckLengthAndPrintName(product4);
        CheckLengthAndPrintName(product5);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static void CheckLengthAndPrintName(string name) {
        if (name.Length > 5) {
            Console.WriteLine("Item: {0}", name);
        }
    }
}

