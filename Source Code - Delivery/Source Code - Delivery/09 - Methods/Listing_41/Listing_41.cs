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
}

class Listing_42 {

    static void Main(string[] args) {

        // create a new person instance
        Person person = new Person(
            "Adam Freeman",
            38,
            "London");

        // print out the details of the person object
        Console.WriteLine("--- Person ---");
        Console.WriteLine("Name: {0}", person.Name);
        Console.WriteLine("Age: {0}", person.Age);
        Console.WriteLine("City: {0}", person.City);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}