using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

class Listing_08 {

    static void Main(string[] args) {

        // get the connection string from the config file
        ConnectionStringSettings connStringSettings
            = ConfigurationManager.ConnectionStrings["NorthwindConnection"];

        // create the connection object
        SqlConnection myConnection
            = new SqlConnection(connStringSettings.ConnectionString);

        // create the SqlDataAdapters
        SqlDataAdapter myEmployeesAdapter = new SqlDataAdapter(
            "SELECT * FROM Employees", myConnection);
        SqlDataAdapter myOrdersAdapter = new SqlDataAdapter(
            "SELECT * FROM Orders", myConnection);

        // create the DataSet object
        DataSet myDataSet = new DataSet();

        // fill the dataset into the named tables
        myEmployeesAdapter.Fill(myDataSet, "Employees");
        myOrdersAdapter.Fill(myDataSet, "Orders");

        // perform the LINQ query
        var results
            = from employee in myDataSet.Tables["Employees"].AsEnumerable()
              where employee.Field<string>("City") == "London"
              join order in myDataSet.Tables["Orders"].AsEnumerable()
                  on employee.Field<int>("EmployeeID") equals order.Field<int>("EmployeeID")
              select new {
                  OrderID = order.Field<int>("OrderID"),
                  EmployeeName = string.Format("{0} {1}",
                    employee.Field<string>("FirstName"),
                    employee.Field<string>("LastName")),
              } into interimresult
              group interimresult by interimresult.EmployeeName;

        // enumerate the results
        foreach (var group in results) {
            Console.WriteLine("Employee: {0}", group.Key);
            // print out the first five orders for this employee
            foreach (var order in group.Take(2)) {
                Console.WriteLine("Order ID: {0}", order.OrderID);
            }
            Console.WriteLine("------------");
        }

        // close the database connection
        myConnection.Close();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}