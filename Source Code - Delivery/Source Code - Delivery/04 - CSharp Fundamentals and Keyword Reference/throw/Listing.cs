using System;

class ThrowTest {

    static void Main(string[] args) {

        throw new NullReferenceException();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
