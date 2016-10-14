using System;
using System.Text;

class varTest {

    static void Main(string[] args) {

        var myInferredType = new StringBuilder("Introduction to C#");
        myInferredType.Append(" 2010");

        var myAnonType = new {
            Name = "Adam Freeman",
            Age = 32,
            City = "London"
        };

        Console.WriteLine("Name: {0}", myAnonType.Name);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
