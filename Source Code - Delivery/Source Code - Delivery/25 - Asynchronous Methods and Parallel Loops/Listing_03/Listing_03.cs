using System;

class Listing_03 {
    public delegate long PerformCalc(int start, int end, int increment);

    static void Main(string[] args) {

        // assign the deleate
        PerformCalc myDelegate = PerformCalcMethod;

        // call the method several times
        myDelegate.BeginInvoke(0, int.MaxValue, 1, AsyncMethodCallback, myDelegate);
        myDelegate.BeginInvoke(0, int.MaxValue/2, 1, AsyncMethodCallback, myDelegate);
        myDelegate.BeginInvoke(0, int.MaxValue/4, 4, AsyncMethodCallback, myDelegate);

        Console.WriteLine("Async methods are running...");

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