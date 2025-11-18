using System;

namespace VoidMethodExample
{
    class Program
    {
        static void Main()
        {
            // Step 1: Instantiate the MathPrinter class
            MathPrinter printer = new MathPrinter();

            // Step 2: Call the method passing two numbers
            printer.DoMathAndPrint(5, 10);

            // Step 3: Call the method specifying parameters by name
            printer.DoMathAndPrint(number2: 20, number1: 7);

            // Step 4: Wait for user input before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
