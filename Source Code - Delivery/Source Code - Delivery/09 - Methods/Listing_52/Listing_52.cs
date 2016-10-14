using System;

class Company {
    public string Name { get; set; }
    public string City { get; set; }
}

class Employee {
    public string Name { get; set; }
    public Company Employer { get; set; }

    public Employee(string personName, string companyName, string city) {
        Name = personName;
        Employer = new Company() { Name = companyName, City = city };
    }

    public Employee(Employee originalEmployee) {
        Name = originalEmployee.Name;
        Employer = originalEmployee.Employer;
        //Employer = new Company() {
        //    Name = originalEmployee.Employer.Name,
        //    City = originalEmployee.Employer.City};
    }
}

class Listing_52 {

    static void Main(string[] args) {

        // create an Employee object
        Employee original = new Employee("Adam Freeman", "BigCo", "Boston");

        // create a copy Employee using the copy constructor
        Employee copy = new Employee(original);

        // print out the employer city from the copy
        Console.WriteLine("City: {0}", copy.Employer.City);

        // modify the original company name
        original.Employer.City = "Paris";

        // print out the employer city from the copy
        Console.WriteLine("City: {0}", copy.Employer.City);        

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
