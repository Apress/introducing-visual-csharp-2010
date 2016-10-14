using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

class Listing_06 {

    static void Main(string[] args) {

        // get the connection string from the config file
        ConnectionStringSettings connStringSettings
            = ConfigurationManager.ConnectionStrings["NorthwindConnection"];

        // create the connection object
        SqlConnection myConnection
            = new SqlConnection(connStringSettings.ConnectionString);

        // create the SqlDataAdapter
        SqlDataAdapter myAdapter = new SqlDataAdapter(
            "SELECT * FROM Employees WHERE City='London'",
            myConnection);

        // create the DataSet object
        DataSet myDataSet = new DataSet();

        // fill the dataset into the named table
        myAdapter.Fill(myDataSet, "Employees");

        // get the DataTable
        DataTable employeeResultTable = myDataSet.Tables["Employees"];

        // report the number of rows in the table
        Console.WriteLine("There are {0} DataRows in the DataTable", 
            employeeResultTable.Rows.Count);

        // enumerate the rows in the table
        foreach (DataRow row in employeeResultTable.Rows) {
            // extract the fields we want
            string firstName = (string) row["FirstName"];
            string lastName = (string) row["Lastname"];
            string city = (string) row["City"];

            // print out the results
            Console.WriteLine("Result - Name: {0} {1}, City: {2}",
                firstName, lastName, city);
        }

        // close the database connection
        myConnection.Close();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}