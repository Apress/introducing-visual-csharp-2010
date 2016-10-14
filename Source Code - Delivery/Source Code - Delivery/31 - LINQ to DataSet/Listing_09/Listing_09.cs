using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

class Listing_09 {

    static void Main(string[] args) {

        // get the connection string from the config file
        ConnectionStringSettings connStringSettings
            = ConfigurationManager.ConnectionStrings["NorthwindConnection"];

        // create the connection object
        SqlConnection myConnection
            = new SqlConnection(connStringSettings.ConnectionString);

        // create the SqlDataAdapters
        SqlDataAdapter adapter1 = new SqlDataAdapter(
            "SELECT * FROM Employees WHERE City='London' OR City = 'Seattle'", 
            myConnection);
        SqlDataAdapter adapter2 = new SqlDataAdapter(
            "SELECT * FROM Employees WHERE City='London' OR City = 'Redmond'", 
            myConnection);

        // create the DataSet object
        DataSet myDataSet = new DataSet();

        // fill the dataset into the named tables
        adapter1.Fill(myDataSet, "LondonOrSeattle");
        adapter2.Fill(myDataSet, "LondonOrRedmond");

        // find the intersection of the data
        IEnumerable<DataRow> results
            = myDataSet.Tables["LondonOrSeattle"].AsEnumerable()
              .Intersect(myDataSet.Tables["LondonOrRedmond"].AsEnumerable(),
              DataRowComparer.Default);

        // enumerate the common data
        foreach (DataRow row in results) {
            Console.WriteLine("Item - Name: {0} {1}, City: {2}",
                row.Field<string>("FirstName"),
                row.Field<string>("LastName"),
                row.Field<string>("City"));
        }

        // close the database connection
        myConnection.Close();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}