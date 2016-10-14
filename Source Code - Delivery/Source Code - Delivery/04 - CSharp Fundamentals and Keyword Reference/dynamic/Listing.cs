using System;
using System.Text;

class DynamicTest {

    static void Main(string[] args) {

   
        dynamic myDynamicObject = new StringBuilder("Adam");
        // call a method that exists
        myDynamicObject.Append(" Freeman");
        // call a method that does not exist
        myDynamicObject.IllegalCall(200);



        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
