using System;

class Listing_21 {

    static void Main(string[] args) {

        byte b = 15;

        // left shift the byte two places
        int result = b << 2;

        // show the before and after values
        Console.WriteLine("--- Left-shift Operator ---");
        Console.WriteLine("Before: {0} ({1})", ConvertToBinary(b), b);
        Console.WriteLine("After:  {0} ({1})", ConvertToBinary(result), result);


        b = 60;

        // right shift three places
        result = b >> 3;

        // show the before and after values
        Console.WriteLine("\n--- Right-shift Operator ---");
        Console.WriteLine("Before: {0} ({1})", ConvertToBinary(b), b);
        Console.WriteLine("After:  {0} ({1})", ConvertToBinary(result), result);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    private static string ConvertToBinary(int value) {
        return String.Format("{0:00000000}", int.Parse(Convert.ToString(value, 2)));
    }
}
