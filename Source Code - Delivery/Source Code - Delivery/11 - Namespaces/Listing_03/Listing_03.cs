using System;
using System.Runtime.Serialization.Formatters.Binary;

class MyClass {

    static void Main(string[] args) {

        // define an object with a long namespace
        BinaryFormatter binaryFormatter;

        // print out a simple message
        Console.WriteLine("Hello World!");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}

