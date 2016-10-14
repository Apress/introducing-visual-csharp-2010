using System.Diagnostics.CodeAnalysis;


class Calculator {

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public int CalculateSum(int x, int y) {
        return x + y;
    }

    public int CalculateProduct(int x, int y) {
        return x * y;
    }

    public int CalculateSubtraction(int x, int y) {
        return x - y;
    }

    public int CalculateDivision(int x, int y) {
        return x / y;
    }

}

class CalculatorTest {

    static void Main() {

    }
}