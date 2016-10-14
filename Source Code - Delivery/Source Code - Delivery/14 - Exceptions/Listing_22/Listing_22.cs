using System;

class CustomException : Exception {
    public CustomException() : base() { }
    public CustomException(string message) : base(message) { }
    public CustomException(string message, Exception inner) : base(message, inner) { }
}

class Listing_22 {

    static void Main(string[] args) {

        try {
            // create a chain of exceptions
            ArgumentOutOfRangeException ex1 
                = new ArgumentOutOfRangeException("This is the original exception");
            NullReferenceException ex2 
                = new NullReferenceException("This is the 2nd exception", ex1);
            CustomException ex3 
                = new CustomException("This is the 3rd exception", ex2);
            IndexOutOfRangeException ex4 
                = new IndexOutOfRangeException("This is the outer exception", ex3);
            // throw the outermost exception
            throw ex4;

        } catch (IndexOutOfRangeException ex) {
            // print the details of the exception we have caught
            Console.WriteLine("---Outer Exception---");
            Console.WriteLine("Type: {0}", ex.GetType());
            Console.WriteLine("Message: {0}", ex.Message);

            // define a local variable for the inner exception
            Exception inner = ex;
            // work our way along the chain
            while ((inner = inner.InnerException) != null) {
                Console.WriteLine("---Inner Exception---");
                Console.WriteLine("Type: {0}", inner.GetType());
                Console.WriteLine("Message: {0}", inner.Message);
            }
            Console.WriteLine("---End of Inner Exception Chain");
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}
