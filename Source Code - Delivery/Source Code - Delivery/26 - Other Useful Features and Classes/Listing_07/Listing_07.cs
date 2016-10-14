using System;

class Listing_07 {

    static void Main(string[] args) {

        Console.WriteLine("Start pressing keys - press 'x' key to stop");

        while (true) {
            // read a key press using the Console class
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            // print out the details of the key we have read
            Console.Write("You pressed: ");
            if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0) {
                Console.Write("ALT+");
            }
            if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0) {
                Console.Write("CONTROL+");
            }
            if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0) {
                Console.Write("SHIFT+");
            }
            Console.WriteLine(keyInfo.Key);

            // see if we have to break the loop
            if (keyInfo.KeyChar == 'x') {
                Console.WriteLine("Stoppping");
                break;
            }
        }

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}