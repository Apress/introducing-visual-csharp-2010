using System;

class Person {
    public string Name { get; set; }
    public string Age { get; set; }
    public string City { get; set; }

    public virtual void PrintInformation() {
        Console.WriteLine("--- Information ---");
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("Age: {0}", Age);
        Console.WriteLine("City: {0}", City);
    }
}

class Employee : Person {
    public string Employer { get; set; }
    public int HourlyRate { get; set; }

    public override void PrintInformation() {
        // have the base class print out the basic info
        base.PrintInformation();
        // print out the additional information we have
        Console.WriteLine("Employer: {0}", Employer);
        Console.WriteLine("Rate: ${0}/hr", HourlyRate);
    }
}

class Listing_37 {

    static void Main(string[] args) {

        // create an employee instance
        Employee e = new Employee() { 
            Name = "Adam", City = "London", Age = "38", 
            Employer = "Big Co", HourlyRate = 10
        };

        // call the PrintInformation method
        e.PrintInformation();
        
        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}