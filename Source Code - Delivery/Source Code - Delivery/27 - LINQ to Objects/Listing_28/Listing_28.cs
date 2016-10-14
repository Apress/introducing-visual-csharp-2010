using System;
using System.Collections.Generic;
using System.Linq;

class Listing_28 {

    static void Main(string[] args) {

        // create the data source
        List<string> myFruitList = new List<string>() {
            "apple", "plum", "cherry", "grape", "banana", "pear", "mango" , 
            "persimmon", "lemon", "lime", "coconut", "pineapple", "orange"};

        // define the LINQ query - leave out the aggregation part
        IEnumerable<string> results = myFruitList
                          .Where(e => e[0] == 'p' || e[0] == 'l')
                          .Select(e => e);

        // convert the results to an array
        string[] resultArray = results.ToArray();

        // print out the contents of the array
        foreach (string str in resultArray) {
            Console.WriteLine("Array result: {0}", str);
        }

        // convert the results to a List<T>
        List<string> resultList = results.ToList();

        // print out the contents of the List<string>
        foreach (string str in resultList) {
            Console.WriteLine("List result: {0}", str);
        }

        // group the results based on first letter
        IEnumerable<IGrouping<char, string>> groupResults = results.GroupBy(e => e[0]);

        // convert the results to a Dictionary<TKey, TVal>
        Dictionary<char, IGrouping<char, string>> resultDict = groupResults.ToDictionary(e => e.Key);
        
        // print out the contents of the dictionary
        foreach (char key in resultDict.Keys) {
            Console.WriteLine("Dictionary Key: {0}", key);
            // get the IGrouping associated with the key
            IEnumerable<string> groupEnum = resultDict[key];
            foreach (string str in groupEnum) {
                Console.WriteLine("Dictionary entry: {0}", str);
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}