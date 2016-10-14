using System;
using MyNamespace.NestedNamespace;

namespace MyNamespace {

    class MyClass {

        static void Main(string[] args) {

            int result = new AdditionHelper().AddIntegers(10, 20);
            Console.WriteLine("Result: {0}", result);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}