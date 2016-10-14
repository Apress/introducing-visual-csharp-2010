using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

class Listing_07 {

    static void Main(string[] args) {

        // get the connection string from the config file
        ConnectionStringSettings connStringSettings
            = ConfigurationManager.ConnectionStrings["NorthwindConnection"];

        // create the connection object
        SqlConnection myConnection
            = new SqlConnection(connStringSettings.ConnectionString);

        // create the SqlDataAdapter
        SqlDataAdapter myAdapter = new SqlDataAdapter(
            "SELECT * FROM Employees", myConnection);

        // create the DataSet object
        DataSet myDataSet = new DataSet();

        // fill the dataset into the named table
        myAdapter.Fill(myDataSet, "Employees");

        // query the results with LINQ
        IEnumerable<DataRow> cityResults
            = from row in myDataSet.Tables["Employees"].AsEnumerable()
              where row.Field<string>("City") == "London"
              select row;

        // enumerate the results
        foreach (DataRow row in cityResults) {
            Console.WriteLine("City Result: {0} {1}",
                row.Field<string>("FirstName"),
                row.Field<string>("Lastname"));
        }

        // use LINQ to perform a different query on the same data
        var titleResults
            = from row in myDataSet.Tables["Employees"].AsEnumerable()
              where row.Field<string>("Title") == "Sales Representative"
              select new {
                  Firstname = row.Field<string>("FirstName"),
                  LastName = row.Field<string>("Lastname")
              };

        // enumerate the second set of results
        foreach (var item in titleResults) {
            Console.WriteLine("Title Result: {0} {1}",
                item.Firstname,
                item.LastName);
        }


        // close the database connection
        myConnection.Close();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
