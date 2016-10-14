using System;
using System.IO;

class Listing_11 {

    static void Main(string[] args) {

        // create a unique temporary filename
        string fileName = Path.GetTempFileName();
        Console.WriteLine("File name is :{0}", fileName);

        // define a string array that we'll use for the file contents
        string[] lineArray = new string[] { "apple", "banana", "apricot", "cherry" };

        // write the string array to the temporary file
        File.WriteAllLines(fileName, lineArray);

        // read the contents of the file 
        foreach (string str in File.ReadAllLines(fileName)) {
            Console.WriteLine("Read line: {0}", str);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
