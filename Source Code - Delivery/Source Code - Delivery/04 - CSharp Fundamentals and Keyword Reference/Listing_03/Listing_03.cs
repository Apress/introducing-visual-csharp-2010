using System;
using System.Text;

class Listing_03 {

    static void Main(string[] args) {

        StringBuilder builder = new StringBuilder("Introduction to C#");
        StringBuilder builder2 = builder;

        bool sameRefs = builder == builder2;

        Console.WriteLine("References the same: {0}", sameRefs);

        string str1 = "Hello World";
        string str2 = "Hello World";
        string str3 = "Intro to C#";

        bool str1EqualsStr2 = str1 == str2;
        bool str1EqualsStr3 = str1 == str3;

        Console.WriteLine("str1 equals str2: {0}", str1EqualsStr2);
        Console.WriteLine("str1 equals str3: {0}", str1EqualsStr3);

        int i = 40;
        if (i == 40) {
            Console.WriteLine("Int value is 40");
        } else {
            Console.WriteLine("Int value is not 40");
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
