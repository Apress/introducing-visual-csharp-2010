using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

class Listing_05 {

    static void Main(string[] args) {

        // get the connection string from the config file
        ConnectionStringSettings connStringSettings
            = ConfigurationManager.ConnectionStrings["NorthwindConnection"];

        // create the connection object
        SqlConnection myConnection 
            = new SqlConnection(connStringSettings.ConnectionString);

        // create the SQL command object
        SqlCommand myCommand = myConnection.CreateCommand();
        myCommand.CommandText = "SELECT * FROM Employees WHERE City='London'";

        // create the SqlDataAdapter
        SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);

        // create the DataSet object
        DataSet myDataSet = new DataSet();

        // fill the dataset into the named table
        myAdapter.Fill(myDataSet, "Employees");

        // close the database connection
        myConnection.Close();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}