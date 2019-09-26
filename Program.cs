using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo Function

            GreetUser(); // Greet User

            // Loop the game
            while (true)
            {
                // Create a random number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                // Init Guest nummber
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10.");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get Guess
                    string input = Console.ReadLine();

                    // Make sure input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print Error Message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number.");
                        continue;
                    }
                    
                    // Cast to int and put in guess var
                    guess = Int32.Parse(input);

                    // Match Numbers
                    if (guess != 7)
                    {
                        // Print Error Message
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number");
                    }
                }

                // Output Success Message
               
                PrintColorMessage(ConsoleColor.Yellow, "Correct! You guessed it!");

                // Ask the user to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                // Check for Y or N 
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
            }
        }
        // Set the GetApp variables 
        static void GetAppInfo()
        {
            // Set app vars
            String appName = "Number Guesser";
            String appVersion = "1.0.0";
            String appAuthor = "Ryan Williamson";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version 1 {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color to white
            Console.ResetColor();
        }
        // Greet User Function
        static void GreetUser()
        {
            // Ask User
            Console.WriteLine("What is your name?");

            //Get Username
            string inputName = Console.ReadLine();

            // Write Out 
            Console.WriteLine("Hello {0} let's play a game...", inputName);
        }

        // Print Color Message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Write out app info
            Console.WriteLine(message);

            // Reset text color to white
            Console.ResetColor();            
        }
    }
}
