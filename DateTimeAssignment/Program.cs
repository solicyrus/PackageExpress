using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Get current date and time
            DateTime currentTime = DateTime.Now;

            // Step 2: Print current date and time to console
            Console.WriteLine("Current date and time: " + currentTime);

            // Step 3: Ask the user for a number of hours to add
            Console.Write("Enter a number of hours to add: ");

            // Step 4: Read user input and convert it to an integer
            int hoursToAdd;
            bool isValid = int.TryParse(Console.ReadLine(), out hoursToAdd);

            // Step 5: Check if the input is valid
            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            else
            {
                // Step 6: Calculate the future time by adding the input hours
                DateTime futureTime = currentTime.AddHours(hoursToAdd);

                // Step 7: Print the future time to console
                Console.WriteLine("The time in " + hoursToAdd + " hours will be: " + futureTime);
            }

            // Step 8: Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
