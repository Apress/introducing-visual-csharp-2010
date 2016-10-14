using System;

class Listing_29 {

    static void Main(string[] args) {

        // define and populate a rectangular array of strings
        string[,] namesArray = {
            {"apples", "oranges", "grapes", "pears"},
            {"green", "orange", "red", "green"}
        };

        Console.WriteLine("Enumerating using a for loop");
        int dim0Len = namesArray.GetLength(0);
        int dim1Len = namesArray.GetLength(1);

        for (int row = 0; row < dim0Len; row++) {
            for (int column = 0; column < dim1Len; column++) {
                Console.WriteLine("Row: {0}, Col: {1}, Value: {2}",
                   row, column, namesArray[row, column]);
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}