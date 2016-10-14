using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

class Listing_04 {

    static void Main(string[] args) {

        ConnectionStringSettings connStringSettings
            = ConfigurationManager.ConnectionStrings["NorthwindConnection"];

        // create the connection object
        SqlConnection myConnection = new SqlConnection(connStringSettings.ConnectionString);

        // create a SQL command object
        SqlCommand myCommand = myConnection.CreateCommand();
        myCommand.CommandText = "SELECT * FROM Employees WHERE City='London'";

        // open the connection to the database
        myConnection.Open();

        // execute the command
        SqlDataReader myReader = myCommand.ExecuteReader();

        // process the data
        while (myReader.Read()) {
            // get the fields for this current row
            string firstName = (string) myReader["FirstName"];
            string lastName = (string) myReader["LastName"];
            string city = (string) myReader["City"];

            // print out the information for this record
            Console.WriteLine("Name: {0} {1}, City: {2}",
                firstName, lastName, city);
        }

        // close the database connection
        myConnection.Close();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}