using System;

class Listing_17 {

    static void Main(string[] args) {

        // define the numeric types used in the example
        int x = 0;
        int y;

        // demonstrate postfix increment operator
        Console.WriteLine("Post-fix increment - initial value of x: {0}", x);
        y = x++;
        Console.WriteLine("Post-fix increment - new value of x: {0}", x);
        Console.WriteLine("Post-fix increment - value of y: {0}", y);

        // demonstrate prefix increment operator
        Console.WriteLine("Pre-fix increment - initial value of x: {0}", x);
        y = ++x;
        Console.WriteLine("Pre-fix increment - new value of x: {0}", x);
        Console.WriteLine("Pre-fix increment - value of y: {0}", y);

        // demonstrate postfix decrementoperator
        Console.WriteLine("Post-fix decrement value of x: {0}", x);
        y = x--;
        Console.WriteLine("Post-fix decrement - new value of x: {0}", x);
        Console.WriteLine("Post-fix decrement - value of y: {0}", y);

        // demonstrate prefix decrement operator
        Console.WriteLine("Pre-fix decrement - initial value of x: {0}", x);
        y = --x;
        Console.WriteLine("Pre-fix decrement - new value of x: {0}", x);
        Console.WriteLine("Pre-fix decrement - value of y: {0}", y);

        // wait for input before exiting
        Console.WriteLine("Press enter to finish");
        Console.ReadLine();
    }
}