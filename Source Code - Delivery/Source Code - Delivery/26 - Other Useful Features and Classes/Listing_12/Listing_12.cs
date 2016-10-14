using System;

class Listing_12 {

    static void Main(string[] args) {

        Console.WriteLine("64 bit OS? {0}", Environment.Is64BitOperatingSystem);
        Console.WriteLine("64 bit program? {0}", Environment.Is64BitProcess);
        Console.WriteLine("Machine name: {0}", Environment.MachineName);
        Console.WriteLine("Processor count: {0}", Environment.ProcessorCount);
        Console.WriteLine("User: {0}", Environment.UserName);
        Console.WriteLine("Version: {0}", Environment.Version);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}