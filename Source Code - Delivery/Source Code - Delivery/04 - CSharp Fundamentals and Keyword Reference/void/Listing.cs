using System;

class MyClass {

    public void PrintMessage(String str) {
        Console.WriteLine("Message: {0}", str);
    }
}

class @void {

    static void Main(string[] args) {

        // create a new class and call the void method
        new MyClass().PrintMessage("Hello");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
