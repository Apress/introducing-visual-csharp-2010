﻿using System;

class Product {
    int itemsInStock = 210;
    string productName = "Banana";
}


class Listing_02 {

    static void Main(string[] args) {

        // create a new instance of the Product type
        Product p = new Product();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

