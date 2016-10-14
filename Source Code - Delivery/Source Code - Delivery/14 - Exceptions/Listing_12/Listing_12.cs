using System;

class Listing_12 {

    static void Main(string[] args) {

        // allocate the resources
        AllocateResources();

        try {

            // statements which uses the resources
            // and which may cause an exception
            Console.WriteLine("Perform work...");

            // define a loval variable
            string myLocalVar = null;

            // try to so something with the local variable
            Console.WriteLine("First letter: {0}", myLocalVar[0]);

        } finally {
            Console.WriteLine("Finally clause executed");
            // release the resources
            ReleaseResources();
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static void AllocateResources() {
        Console.WriteLine("Allocated Resources");
    }

    static void ReleaseResources() {
        Console.WriteLine("Release Resources");
    }
}
