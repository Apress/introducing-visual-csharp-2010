
namespace System {

    class MyConsoleHelper {

        internal void PrintMessages() {
            Console.WriteLine("Hello World");
            Console.WriteLine("Press enter to finish");
        }

    }

}

class Listing_10 {

    static void Main(string[] args) {

        // use the MyConsoelHelper class
        new System.MyConsoleHelper().PrintMessages();

        // wait for input before exiting
        System.Console.ReadLine();
    }
}

