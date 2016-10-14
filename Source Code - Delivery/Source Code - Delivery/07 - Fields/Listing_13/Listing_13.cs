
class Product {
    public const int UnitsPerCrate = 10;
}

class Listing_13 {

    static void Main(string[] args) {

        // access the public const field
        System.Console.WriteLine("Units in Stock: {0}", Product.UnitsPerCrate);

        // wait for input before exiting
        System.Console.WriteLine("Press enter to finish");
        System.Console.ReadLine();
    }
}

