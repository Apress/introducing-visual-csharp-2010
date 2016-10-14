using System;

class MyClass : IDisposable {

    public MyClass() {
        // constructor statements
        Console.WriteLine("Constructor called");
    }

    public void DoSomeWork() {
        Console.WriteLine("Doing some work...");
    }

    public void Dispose() {
        // disposal statements
        Console.WriteLine("Dispose method called");
    }
}

class DisposalTest {

    static void Main(string[] args) {

        // create a new MyClass object
        MyClass myClass = new MyClass();

        // do some work with the object we created
        myClass.DoSomeWork();

        // call the dispose method
        myClass.Dispose();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
