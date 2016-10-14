using System;

[Flags]
enum MyProducts {
    Apples = 2,
    Bananas = 4,
    Cherries = 8
}

class FlagsTest {

    static void Main(string[] args) {

        // combine enum values to represent a mix of products
        MyProducts productMix = MyProducts.Apples | MyProducts.Bananas;

        // print out the product mix
        Console.WriteLine("Products: {0}", productMix);
            
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}