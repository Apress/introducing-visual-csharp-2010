using System;

class Listing_04 {
    public delegate long PerformCalc(int start, int end, int increment);

    static void Main(string[] args) {

        // assign the deleate
        PerformCalc myDelegate = PerformCalcMethod;

        // call the method several times
        IAsyncResult res1 = myDelegate.BeginInvoke(0, int.MaxValue, 1, AsyncMethodCallback, myDelegate);
        IAsyncResult res2 = myDelegate.BeginInvoke(0, int.MaxValue / 2, 1, AsyncMethodCallback, myDelegate);
        IAsyncResult res3 = myDelegate.BeginInvoke(0, int.MaxValue / 4, 4, AsyncMethodCallback, myDelegate);

        Console.WriteLine("Async methods are running...");

        // wait for each of the async methods to complete
        res1.AsyncWaitHandle.WaitOne();
        res2.AsyncWaitHandle.WaitOne();
        res3.AsyncWaitHandle.WaitOne();

        Console.WriteLine("Async methods have all completed");

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }

    static void AsyncMethodCallback(IAsyncResult asyncResult) {
        // get the delegate that is being called from the result
        long result = ((PerformCalc)asyncResult.AsyncState).EndInvoke(asyncResult);
        // write out the result
        Console.WriteLine("Result: {0}", result);
    }

    static long PerformCalcMethod(int start, int end, int increment) {
        long result = 0;
        for (int i = start; i < end; i += increment) {
            result += i;
        }
        return result;
    }
}