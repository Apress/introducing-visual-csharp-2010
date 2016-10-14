using System;

class MyClass {

    public void PrintMessage() {
        // print a message
        Console.WriteLine("Hello World");
    }
}

class Listing_04 {

    static void Main(string[] args) {

        // create a new instance of my class
        MyClass mc = new MyClass();

        // print a message
        mc.PrintMessage();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

