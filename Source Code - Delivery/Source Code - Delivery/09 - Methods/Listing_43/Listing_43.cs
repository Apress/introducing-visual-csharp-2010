using System;

class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

class Listing_43 {

    static void Main(string[] args) {

        // create a new instance of Person and
        // provide values for the public properties
        Person person = new Person() {
            Name = "Adam Freeman",
            Age = 38,
            City = "London"
        };

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