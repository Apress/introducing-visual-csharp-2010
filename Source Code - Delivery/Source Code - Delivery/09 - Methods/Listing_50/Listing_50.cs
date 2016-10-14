using System;

class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    protected Person(string name, int age = 38, string city = "London") {
        Name = name; Age = age; City = city;
    }
}

class Employee : Person {
    public string Company { get; set; }

    public Employee(string name, string company)
        : base(name) {

        Company = company;
    }
}

class Listing_50 {

    static void Main(string[] args) {

        Person p = new Employee("Adam Freeman", "BigCo");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}