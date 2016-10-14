using System;

class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    public Person(string name, int age, string city) {
        Name = name; Age = age; City = city;
    }
}

static class ExtensionMethods {

    public static void PrintInformation(this Person p) {
        Console.WriteLine("--- Person ---");
        Console.WriteLine("Name: {0}", p.Name);
        Console.WriteLine("Age: {0}", p.Age);
        Console.WriteLine("City: {0}", p.City);
    }
}

class Listing_65 {

    static void Main(string[] args) {

        // create a new instance of Person
        Person p = new Person("Adam Freeman", 38, "London");

        // call the extension method
        p.PrintInformation();

        // call the equivilent method in this class
        PrintPersonInformation(p);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

private static void PrintPersonInformation(Person p) {
    Console.WriteLine("--- Person ---");
    Console.WriteLine("Name: {0}", p.Name);
    Console.WriteLine("Age: {0}", p.Age);
    Console.WriteLine("City: {0}", p.City);
}
}
