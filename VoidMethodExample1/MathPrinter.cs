using System;

namespace VoidMethodExample
{
    // This class contains a void method that takes two integers
    public class MathPrinter
    {
        // Void method that does a math operation on the first number
        // and prints the second number
        public void DoMathAndPrint(int number1, int number2)
        {
            // Multiply the first number by 2
            int result = number1 * 2;

            // Display the result of the first number
            Console.WriteLine("First number multiplied by 2: " + result);

            // Display the second number
            Console.WriteLine("Second number: " + number2);
        }
    }
}
