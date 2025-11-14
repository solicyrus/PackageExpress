using System;

namespace PackageExpressQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask user for package weight
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if weight exceeds limit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End program
            }

            // Ask user for package width
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // Ask user for package height
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // Ask user for package length
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Check if total dimensions exceed limit
            double totalDimensions = width + height + length;
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End program
            }

            // Calculate shipping quote
            double quote = (width * height * length * weight) / 100;

            // Display the quote
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
