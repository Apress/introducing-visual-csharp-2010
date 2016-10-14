using System;

class Listing_35 {

    static void Main(string[] args) {

        string[][] jaggedArray = new string[3][];

        jaggedArray[0] = new string[] { "apples", "oranges" };
        jaggedArray[1] = new string[] { "bananas" };
        jaggedArray[2] = new string[] { "guavas", "pears", "cherries" };

        foreach (string[] outer in jaggedArray) {
            foreach (string s in outer) {
                Console.WriteLine("Item: {0}", s);
            }
        }

        for (int i = 0; i < jaggedArray.Length; i++) {
            for (int j = 0; j < jaggedArray[i].Length; j++) {
                Console.WriteLine("Row: {0}, Col: {1}, Value: {2}",
                   i, j, jaggedArray[i][j]);
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
