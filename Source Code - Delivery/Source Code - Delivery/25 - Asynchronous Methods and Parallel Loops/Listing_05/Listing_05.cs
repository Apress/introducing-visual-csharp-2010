using System;

class Listing_05 {
    public delegate long PerformCalc(int start, int end, int increment);

    static void Main(string[] args) {

        // assign the deleate
        PerformCalc myDelegate = PerformCalcMethod;

        // call the method several times
        IAsyncResult res1 = myDelegate.BeginInvoke(0, int.MaxValue, 1, null, myDelegate);
        IAsyncResult res2 = myDelegate.BeginInvoke(0, int.MaxValue / 2, 1, null, myDelegate);
        IAsyncResult res3 = myDelegate.BeginInvoke(0, int.MaxValue / 4, 4, null, myDelegate);

        Console.WriteLine("Async methods are running...");

        foreach (IAsyncResult res in new IAsyncResult[] { res1, res2, res3 }) {
            long result = myDelegate.EndInvoke(res);
            Console.WriteLine("Result: {0}", result);
        }

        Console.WriteLine("Async methods have all completed");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static long PerformCalcMethod(int start, int end, int increment) {
        long result = 0;
        for (int i = start; i < end; i += increment) {
            result += i;
        }
        return result;
    }
}