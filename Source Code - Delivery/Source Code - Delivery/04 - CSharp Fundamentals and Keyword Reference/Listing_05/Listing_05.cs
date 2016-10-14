using System;

class Listing_05 {

    static void Main(string[] args) {

        string myName = "Adam Freeman";

        switch (myName) {
            case "Joe Smith":
                Console.WriteLine("Name is Joe Smith");
                break;
            case "Adam Freeman":
            case "Jane Jones":
            case "Peter Kent":
                Console.WriteLine("Name is Adam Freeman, Jane Jones or Peter Kent");
                break;
            default:
                Console.WriteLine("Default reached");
                break;
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
