using System;

class Listing_20 {

    static void Main(string[] args) {

        // define the byte values that will be used
        byte b1 = 138;
        byte b2 = 129;

        // demonstrate the & operator
        Console.WriteLine("--- & Operator ---");
        Console.WriteLine("binary: {0} decimal: {1}", ConvertToBinary(b1), b1);
        Console.WriteLine("binary: {0} decimal: {1}", ConvertToBinary(b2), b2);
        int result1 = b1 & b2;
        Console.WriteLine("result: {0} decimal: {1}", ConvertToBinary(result1), result1);

        // demonstrate the | operator
        Console.WriteLine("\n--- | Operator ---");
        Console.WriteLine("binary: {0} decimal: {1}", ConvertToBinary(b1), b1);
        Console.WriteLine("binary: {0} decimal: {1}", ConvertToBinary(b2), b2);
        int result2 = b1 | b2;
        Console.WriteLine("result: {0} decimal: {1}", ConvertToBinary(result2), result2);

        // demonstrate the ^ operator
        Console.WriteLine("\n--- ^ Operator ---");
        Console.WriteLine("binary: {0} decimal: {1}", ConvertToBinary(b1), b1);
        Console.WriteLine("binary: {0} decimal: {1}", ConvertToBinary(b2), b2);
        int result3 = b1 ^ b2;
        Console.WriteLine("result: {0} decimal: {1}", ConvertToBinary(result3), result3);

        // demonstrate the ~ operator
        Console.WriteLine("\n--- ~ Operator ---");
        Console.WriteLine("binary: {0} decimal: {1}", ConvertToBinary(b1), b1);
        byte result4 = (byte)~b1;
        Console.WriteLine("result: {0} decimal: {1}", ConvertToBinary(result4), result4);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    private static string ConvertToBinary(int value) {
        return String.Format("{0:00000000}", int.Parse(Convert.ToString(value, 2)));
    }
}

