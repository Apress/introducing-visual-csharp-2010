using System;

namespace Listing_05 {
    class Listing_05 {

        static void Main(string[] args) {

            // create an initialize an array
            string[] nameArray = new string[3];

            // set 2 of the array values
            nameArray[0] = "bananas";
            nameArray[1] = "cherries";

            // get the array values
            string value = nameArray[0];
            Console.WriteLine("Item: {0}", value);
            // get an array value that has not been set
            // and so will still be null
            value = nameArray[2];
            Console.WriteLine("Item: {0}", value == null);

            try {
                // try to get an index that is out of bounds
                value = nameArray[10];
            } catch (IndexOutOfRangeException ex) {
                Console.WriteLine("Exception: {0}", ex);
            }
            
            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}