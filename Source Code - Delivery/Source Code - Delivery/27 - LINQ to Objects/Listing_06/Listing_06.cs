using System;
using System.Collections.Generic;
using System.Linq;

public class Fruit {

    public Fruit(string name) {
        Name = name;
    }

    public string Name { get; set; }
}

public class RedFruit : Fruit {

    public RedFruit(string name, string size)
        : base(name) {
        Size = size;
    }

    public string Size { get; set; }

    public override string ToString() {
        return string.Format("Name: {0}, Size: {0}", Name, Size);
    }
}


class Listing_06 {

    static void Main(string[] args) {

        // create a collection of RedFruits, but assign them to a Fruit collection
        List<Fruit> myFruitList = new List<Fruit> {
            new RedFruit("cherry", "small"),
            new RedFruit("apple", "large"),
            new RedFruit("plum", "medium")
        };

        // define the query, explicitly specifying the range variable type
        IEnumerable<RedFruit> results = from RedFruit e in myFruitList
                                     select e;

        // enumerate the results
        foreach (RedFruit rf in results) {
            Console.WriteLine("Result: {0}", rf);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
