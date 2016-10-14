using System;
using System.Data;
using System.Data.SqlClient;

class Listing_01 {

    static void Main(string[] args) {

        // create a connection object
        SqlConnection myConnection = new SqlConnection();

        // set the connection string 
        myConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Northwind\Northwind.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        // open the connection to the database
        myConnection.Open();

        // display the connection state
        if (myConnection.State == ConnectionState.Open) {
            Console.WriteLine("Connection is open");
        } else {
            Console.WriteLine("Connection didn't open properly");
        }

        // close the connection
        myConnection.Close();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}