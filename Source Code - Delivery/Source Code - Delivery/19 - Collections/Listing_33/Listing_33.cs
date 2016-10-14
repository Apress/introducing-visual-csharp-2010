using System;

namespace Listing_33 {
    class Listing_33 {

        static void Main(string[] args) {

            // create the source array
            string[] strArray = new string[] { 
                "apple", "orange", "banana", 
                "cherry", "guava" };

            // convert the string[] to an int[]
            int[] intArray = Array.ConvertAll(
                strArray, 
                new Converter<string, int>(s => s.Length)
            );

            // enumerate the int[]
            foreach (int i in intArray) {
                Console.WriteLine("Int Array Item: {0}", i);
            }

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}