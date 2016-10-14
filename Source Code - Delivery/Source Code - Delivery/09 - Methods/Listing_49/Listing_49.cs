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

class Employee : Person {
    public string Company { get; set; }

    public Employee(string name, string company)
        : base(name) {

        Company = company;
    }
}

class Listing_49 {

    static void Main(string[] args) {

        // create a new instance of Employee
        Person p = new Employee("Adam Freeman", "BigCorp");

        Console.WriteLine("--- Person ---");
        Console.WriteLine("Name: {0}", p.Name);
        Console.WriteLine("Age: {0}", p.Age);
        Console.WriteLine("City: {0}", p.City);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
