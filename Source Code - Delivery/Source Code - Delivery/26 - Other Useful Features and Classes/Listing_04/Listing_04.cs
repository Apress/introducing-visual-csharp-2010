using System;

class Listing_04 {

    static void Main(string[] args) {

        Nullable<int> myNullableInt = null; 

        // no value has been assigned so far
        Console.WriteLine("Nullable variable - has value: {0}", myNullableInt.HasValue);

        // assign a value
        myNullableInt = 34;
        Console.WriteLine("Nullable variable - has value: {0}, value: {1}", 
            myNullableInt.HasValue, myNullableInt.Value );

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}