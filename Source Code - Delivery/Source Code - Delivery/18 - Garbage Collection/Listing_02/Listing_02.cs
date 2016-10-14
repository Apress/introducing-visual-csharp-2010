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
}

class DestructorTest {

    static void Main(string[] args) {

        // create a new MyClass object, but don't assign
        // it to a variable or field
        new MyClass();

        // manually invoke the GC
        GC.Collect();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
