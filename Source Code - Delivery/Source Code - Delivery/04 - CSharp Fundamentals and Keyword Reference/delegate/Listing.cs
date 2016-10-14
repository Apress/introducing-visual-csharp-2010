using System;

delegate void MyDelegate(int pValue);

class DelegateTest {

    static void Main(string[] args) {

        // define a new instance of the delegate type
        MyDelegate del = PerformAction;
        // invoke the delegate
        del(100);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static void PerformAction(int count) {
        Console.WriteLine("Perform action with parameter value: {0}", count);
    }
}
