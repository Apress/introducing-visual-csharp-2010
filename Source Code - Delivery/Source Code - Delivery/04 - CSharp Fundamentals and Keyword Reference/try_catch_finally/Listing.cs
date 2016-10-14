using System;

class try_catch_finally {

    static void Main(string[] args) {

        try {
            // code statements go here
        } catch (Exception ex) {
            // print out details of the exception
            Console.WriteLine(ex.ToString());
        } finally {
            // release any resources here
        }


        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
