using System;


class LockTest {

    static void Main(string[] args) {

        object myObject = new object();

        lock (myObject) {

            // ... critical region code statements

        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
