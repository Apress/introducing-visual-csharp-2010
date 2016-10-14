using System;

class MyClass {
    private int myPrivateField = 100;

    public int MyPublicProperty {
        get {
            return myPrivateField;
        }
        set {
            myPrivateField = value;
        }
    }
}

class access_modifiers {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
