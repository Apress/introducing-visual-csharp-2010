using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyService {

    class CalculatorImpl : ICalculatorServer {

        public int PerformAddition(int x, int y) {
            int result = x + y;
            Console.WriteLine("Addition Request: {0} + {1} = {2}",
                x, y, result);
            return result;
        }

        public int PerformMultiplcation(int x, int y) {
            int result = x * y;
            Console.WriteLine("Multiplcation Request: {0} * {1} = {2}",
                x, y, result);
            return result;
        }

        public int PerformSubtraction(int x, int y) {
            int result = x - y;
            Console.WriteLine("Subtraction Request: {0} - {1} = {2}",
                x, y, result);
            return result;
        }

        public float PerformDivision(int x, int y) {
            float result = ((float)x) / ((float)y);
            Console.WriteLine("Division Request: {0} / {1} = {2}",
                x, y, result);
            return result;
        }
    }
}
