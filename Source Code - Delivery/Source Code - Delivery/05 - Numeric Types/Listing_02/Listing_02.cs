using System;

class Listing_02 {

    static void Main(string[] args) {

        Type t1 = 23L.GetType();
        Console.WriteLine("Value: 23 - Type: {0}", t1);

        Type t2 = 2500000000UL.GetType();
        Console.WriteLine("Value: 2500000000 - Type: {0}", t2);

        Type t3 = 2017.2M.GetType();
        Console.WriteLine("Value: 2017.2 - Type: {0}", t3);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

