using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

class Listing_12 {

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

        // create the command builder
        SqlCommandBuilder myCommandBuilder = new SqlCommandBuilder(myAdapter);

        // create the DataSet object
        DataSet myDataSet = new DataSet();

        // fill the dataset into the named table
        myAdapter.Fill(myDataSet, "Employees");

        // query the DataSet using LINQ
        IEnumerable<DataRow> results
            = from row in myDataSet.Tables["Employees"].AsEnumerable()
              where row.Field<string>("Title") == "Sales Representative"
              select row;

        // enumerate through the results and modify the Title field
        foreach (DataRow row in results) {
            row["Title"] = "Client Liaison";
        }

        // update the database
        int updatedRows = myAdapter.Update(myDataSet, "Employees");
        Console.WriteLine("There were {0} updated rows", updatedRows);

        // close the database connection
        myConnection.Close();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
