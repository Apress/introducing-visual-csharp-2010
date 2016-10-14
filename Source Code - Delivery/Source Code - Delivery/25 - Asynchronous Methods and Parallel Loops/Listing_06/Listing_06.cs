using System;
using System.Net;
using System.Threading.Tasks;

class Listing_06 {
    
    static void Main(string[] args) {

        // create a Task that will asychronously perform a DNS lookup
        Task<IPHostEntry> dnsTask = Task<IPHostEntry>.Factory.FromAsync(Dns.BeginGetHostEntry, Dns.EndGetHostEntry, "www.microsoft.com", null);

        // create a continuation that consumes the result from the DNS query
        Task continuationTask = dnsTask.ContinueWith(antecedent => {
            Console.WriteLine("Result from DNS Task is: {0}", antecedent.Result.HostName);
        });

        // wait for the continuation to complete
        continuationTask.Wait();

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}