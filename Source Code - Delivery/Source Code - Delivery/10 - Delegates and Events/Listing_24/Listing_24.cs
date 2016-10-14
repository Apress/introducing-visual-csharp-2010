using System;

class Listing_24 {

    static void Main(string[] args) {

        // define a variable that will be captured
        string message = "Hello World";

        // define an anonymous method that will capture
        // the local variables
        Action printMessage = delegate() {
            Console.WriteLine("Message: {0}", message);
        };

        // modify one of the local vaiables
        message = "Howdy!";

        // invoke the delegate
        printMessage();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
