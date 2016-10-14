using System;

class PropertyDemo {
    private string myField = "Hello";

    public string MyProperty {
        get {
            return myField;
        }
        set {
            myField = value;
        }
    }
}


class get_set_value {

    static void Main(string[] args) {


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
