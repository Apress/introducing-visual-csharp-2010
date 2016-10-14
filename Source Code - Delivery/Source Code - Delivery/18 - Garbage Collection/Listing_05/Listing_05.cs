using System;

class MyClass {

    public MyClass() {
        // constructor statements
        Console.WriteLine("Constructor called");
    }

    ~MyClass() {
        // destructor statement
        Console.WriteLine("Destructor called");
    }

    public void DoSomeWork() {
        Console.WriteLine("Doing some work...");
    }
}

class Listing_05 {

    static void Main(string[] args) {
        
        // create a weak reference
        WeakReference weakRef = new WeakReference(new MyClass());

        // use the weak reference to access the object and so some work
        if (weakRef.IsAlive) {
            ((MyClass)weakRef.Target).DoSomeWork();
        }

        // run the garbage collector
        GC.Collect();

        // test to see if the weak reference is still alive
        Console.WriteLine("Still alive? {0}", weakRef.IsAlive);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}