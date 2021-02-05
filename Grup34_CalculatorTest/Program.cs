using System;

namespace Grup34_CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab1Exercise1();
        }

        static void Lab1Exercise1()
        {
            var calc = new Calculator();

            const double a = 2.5;
            const double b = 4;

            double testval;
            testval = calc.Add(a, b);

            Console.WriteLine($"Calculator:");

            Console.WriteLine($"{a} + {b} = {testval}");
            TestIsEq(testval, 6.5, "Add");

            testval = calc.Subtract(a, b);
            Console.WriteLine($"{a} - {b} = {testval}");
            TestIsEq(testval, -1.5, "Subtract");

            testval = calc.Multiply(a, b);
            Console.WriteLine($"{a} * {b} = {testval}");
            TestIsEq(testval, 10, "Multiply");

            testval = calc.Power(a, b);
            Console.WriteLine($"{a}^{b} = {testval}");
            TestIsEq(testval, 39.0625, "Power");


            const double ax = -3;
            const double bx = 0.5;
            Console.WriteLine();
            Console.WriteLine($"test power {bx} of negativ: ");


            testval = calc.Power(ax, bx);
            Console.WriteLine($"{ax}^{bx} = {testval}");
            TestIsEq(testval, double.NaN, "Power"); //makes no sense  it fails

        }



        static void TestIsEq(double test, double expected, string type)
        {
            Console.WriteLine($"Test-{type} Result:");
            if (test == expected)
            {
                Console.WriteLine("Test OK");
            } else
            {
                Console.WriteLine($"Test FALD");
                Console.WriteLine($"Result is {test} but is shut be {expected}");
            }
            Console.WriteLine();
        }
    }
}
