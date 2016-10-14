using System;

class MyData {
    // ...class members ...
}

class MyClass {

    public void MyMethod(MyData md, int count, bool enableoption) {
        // method body goes here
        Console.WriteLine("Int value: {0}", count);
    }
}

class Listing_09 {

    static void Main(string[] args) {

        MyData md = new MyData();
        MyClass mc = new MyClass();
        mc.MyMethod(md, 0, true);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}