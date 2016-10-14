using System;

namespace Listing_06 {
    class Listing_06 {

        static void Main(string[] args) {

            // define, initialize and populate a string array in one go
            string[] names1 = { "oranges", "apples", "guava" };
            // define, initialize and populate a string array in one go
            string[] names2 = new string[] { "oranges", "apples", "guava" };
            // define, initialize and populate a string array in one go
            string[] names3 = new string[3] { "oranges", "apples", "guava" };


            

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
