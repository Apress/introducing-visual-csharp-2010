using System;

class Listing_04 {

    static void Main(string[] args) {

        int x = 100;

        if (x == 100) {
            Console.WriteLine("Code Block Selected");
        }

        int y = 100;
        bool result = y == 100;

        if (result) {
            Console.WriteLine("Code Block Selected");
        }

        int z = 100;
        if (z > 50) {
            if (z == 100) {
                Console.WriteLine("Code Block Selected");
            }
        }

        if (x == 50) {
            Console.WriteLine("First Code Block Selected");
        } else if (x == 60) {
            Console.WriteLine("Second Code Block Selected");
        } else if (x == 100) {
            Console.WriteLine("Third Code Block Selected");
        }



        if (x == 100) {
            Console.WriteLine("First Code Block Selected");
        } else {
            Console.WriteLine("Second Code Block Selected");
        }

        if (x > 0 && x < 200) {
            Console.WriteLine("Code Block Selected");
        }


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
