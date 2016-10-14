
class Product {
    readonly int unitsPerCrate = 5;

    public Product(int units) {
        if (units > 10) {
            unitsPerCrate = units;
        }
    }

    public int UnitsPerCrate {
        get { return unitsPerCrate; }
    }
}

class Listing_15 {

    static void Main(string[] args) {

        // create an instance of product using the default constructor
        Product p1 = new Product(8);

        // get the number of units per crate
        System.Console.WriteLine("Units in Stock: {0}", p1.UnitsPerCrate);

        // create an instance of product
        Product p2 = new Product(20);

        // get the number of units per crate
        System.Console.WriteLine("Units in Stock: {0}", p2.UnitsPerCrate);

        // wait for input before exiting
        System.Console.WriteLine("Press enter to finish");
        System.Console.ReadLine();
    }
}

