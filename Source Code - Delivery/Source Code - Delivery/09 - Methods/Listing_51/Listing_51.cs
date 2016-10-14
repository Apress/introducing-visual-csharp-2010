using System;

class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    public Person(string name, int age = 38, string city = "London") {
        Name = name; Age = age; City = city;
    }

    public Person(Person originalPerson) {
        Name = originalPerson.Name;
        Age = originalPerson.Age;
        City = originalPerson.City;
    }
}

class Listing_51 {

    static void Main(string[] args) {

        // create a new instance of Person
        Person orig = new Person("Joe Smith", 50, "New York");

        // create an instance of Person 
        // using the copy constructor
        Person copy = new Person(orig);

        // print out the details of the copied Person
        Console.WriteLine("--- Person ---");
        Console.WriteLine("Name: {0}", copy.Name);
        Console.WriteLine("Age: {0}", copy.Age);
        Console.WriteLine("City: {0}", copy.City);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
