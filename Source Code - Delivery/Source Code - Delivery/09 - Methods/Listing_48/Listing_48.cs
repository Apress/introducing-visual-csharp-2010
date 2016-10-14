using System;

class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    public Person(string name, int age = 38, string city = "London") {
        Console.WriteLine("Person constructor called");
        Name = name;
        Age = age;
        City = city;
    }
}

class Employee : Person {
    public string Company { get; set; }

    public Employee(string name, string company)
        : base(name) {

        Console.WriteLine("Employee constructor called");
        Company = company;
    }
}

class Listing_48 {

    static void Main(string[] args) {

        // create a new instance of Employee
        Employee e = new Employee("Adam Freeman", "BigCorp");

        Console.WriteLine("--- Employee ---");
        Console.WriteLine("Name: {0}", e.Name);
        Console.WriteLine("Age: {0}", e.Age);
        Console.WriteLine("City: {0}", e.City);
        Console.WriteLine("Employer: {0}", e.Company);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
