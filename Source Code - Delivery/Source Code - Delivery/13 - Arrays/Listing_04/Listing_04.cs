using System;

namespace Listing_04 {
    class Listing_04 {

        static void Main(string[] args) {

            object[] nameArray = new string[5];

            object obj = nameArray[0];
            string str = (string)nameArray[0];

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
