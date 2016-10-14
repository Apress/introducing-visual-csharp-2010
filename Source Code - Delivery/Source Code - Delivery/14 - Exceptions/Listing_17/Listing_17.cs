using System;

class CustomException : Exception {

    public CustomException()
        : base() {
    }

    public CustomException(string message)
        : base(message) {
    }

    public CustomException(string message, Exception inner)
        : base(message, inner) {
    }
}

class Listing_17 {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}


