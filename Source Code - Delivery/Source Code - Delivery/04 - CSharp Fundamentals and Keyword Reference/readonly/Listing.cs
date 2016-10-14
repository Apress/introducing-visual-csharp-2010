using System;

class MyClass {
    private readonly int myReadonlyField = 100;

    public MyClass() {
        myReadonlyField = 200;
    }
}


class ReadOnly {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
