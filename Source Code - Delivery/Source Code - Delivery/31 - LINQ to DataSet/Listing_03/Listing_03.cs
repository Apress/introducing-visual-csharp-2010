using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

class Listing_03 {

    static void Main(string[] args) {

        ConnectionStringSettings connStringSettings
            = ConfigurationManager.ConnectionStrings["NorthwindConnection"];

        using (SqlConnection myConnection = new SqlConnection(connStringSettings.ConnectionString)) {

            // open the connection to the database
            myConnection.Open();

            // display the connection state
            if (myConnection.State == ConnectionState.Open) {
                Console.WriteLine("Connection is open");
            } else {
                Console.WriteLine("Connection didn't open properly");
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}