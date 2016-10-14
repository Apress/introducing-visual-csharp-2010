using System;


class decimal_double_float {

    static void Main(string[] args) {

        decimal myDecimal = 100.23m;
        double myDouble = 100.23d;
        float myFloat = 100.23f;

        Console.WriteLine("Decimal: {0}", myDecimal);
        Console.WriteLine("Double: {0}", myDouble);
        Console.WriteLine("Float: {0}", myFloat);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
