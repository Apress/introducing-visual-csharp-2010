using System;

class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    public Person(string name, int age = 38, string city = "London") {
        Name = name;
        Age = age;
        City = city;
    }
}

class Listing_47 {

    static void Main(string[] args) {

        // create a person instance using the second constructor
        Person p1 = new Person("Adam Freeman");
        Person p2 = new Person("Adam Freeman", 38);
        Person p3 = new Person("Adam Freeman", 38, "London");


        // print out the details of the person object
        foreach (Person p in new Person[] { p1, p2, p3 }) {
            Console.WriteLine("--- Person ---");
            Console.WriteLine("Name: {0}", p.Name);
            Console.WriteLine("Age: {0}", p.Age);
            Console.WriteLine("City: {0}", p.City);
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}