using System;
using System.Collections.Generic;
using System.Linq;

class NameInfo {

    public NameInfo(char charParam, int lenParam) {
        FirstChar = charParam;
        Length = lenParam;
    }

    public char FirstChar { get; set; }
    public int Length { get; set; }

}

class Listing_12 {

    static void Main(string[] args) {

        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        IEnumerable<NameInfo> results = from e in myFruitList
                                        select new NameInfo(e[0], e.Length);

        foreach (NameInfo item in results) {
            Console.WriteLine("Result item - FirstChar: {0}, Length: {1}", item.FirstChar, item.Length);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}