using System;

class Listing_11 {

    static void Main(string[] args) {

        float f1 = 0f;
        float f2 = float.Epsilon / 2;
        float f3 = float.Epsilon;

        Console.WriteLine("f2 == f1? {0}", f2 == f1);
        Console.WriteLine("f3 == f1? {0}", f3 == f1);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}