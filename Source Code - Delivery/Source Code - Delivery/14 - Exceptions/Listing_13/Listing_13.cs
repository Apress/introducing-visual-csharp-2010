using System;

class Listing_13 {

    static void Main(string[] args) {

        // define a string array
        string[] array = { "orange", "apple", "pear" };

        try {
            // make a call to the GetStringLength method
            int result = GetStringLength(array, 2);
            Console.WriteLine("Result: {0}", result);

            // make a call that will cause an exception
            result = GetStringLength(array, 100);

        } catch (Exception ex) {
            Console.WriteLine(ex.ToString());
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static int GetStringLength(string[] array, int index) {        
        if (index < array.Length) {
            return array[index].Length;
        } else {
            throw new Exception();            
        }
    }
}