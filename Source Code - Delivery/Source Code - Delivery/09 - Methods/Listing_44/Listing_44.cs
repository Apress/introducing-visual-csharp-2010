using System;

class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    public Person(string name, int age, string city) {
        Name = name; 
        Age = age; 
        City = city;
    }

    public Person(string name, string age, string city) {
        Name = name;
        Age = int.Parse(age);
        City = city;
    }
}

class Listing_44 {

    static void Main(string[] args) {

        // create a person instance using the first constructor
        Person p1 = new Person("Adam Freeman", 38, "London");

        // print out the details of the person object
        Console.WriteLine("--- Person ---");
        Console.WriteLine("Name: {0}", p1.Name);
        Console.WriteLine("Age: {0}",  p1.Age);
        Console.WriteLine("City: {0}", p1.City);

        // create a person instance using the second constructor
        Person p2 = new Person("Adam Freeman", "38", "London");

        // print out the details of the person object
        Console.WriteLine("--- Person ---");
        Console.WriteLine("Name: {0}", p2.Name);
        Console.WriteLine("Age: {0}", p2.Age);
        Console.WriteLine("City: {0}", p2.City);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}