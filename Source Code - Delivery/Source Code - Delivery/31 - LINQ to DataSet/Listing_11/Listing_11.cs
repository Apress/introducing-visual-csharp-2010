using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

class Listing_11 {

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

        // create a new DataRow
        DataRow newRow = myDataSet.Tables["Employees"].NewRow();

        // set some field values for the new DataRow
        newRow["FirstName"] = "Adam";
        newRow["LastName"] = "Freeman";
        newRow["City"] = "London";

        // add the new row to the table
        myDataSet.Tables["Employees"].Rows.Add(newRow);

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
