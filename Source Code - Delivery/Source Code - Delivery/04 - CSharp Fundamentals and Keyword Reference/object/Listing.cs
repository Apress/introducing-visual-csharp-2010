using System;
using System.Text;

class ObjectTest {

    static void Main(string[] args) {

        // create a new StringBuilder object and upcast it to object
        object myObject = new StringBuilder("Adam Freeman");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
