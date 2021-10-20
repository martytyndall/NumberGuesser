using System;

// namespace
namespace NumberGuesser
{   
    // main class
    class Program
    {

        // entry point method
        static void Main(string[] args)
        {
            // initialize GetAppinfo function
            GetAppInfo();

            // initialize GreetUser function
            GreetUser();

            while (true)
            {
                // create new random object
                Random random = new Random();

                // initialize correct number
                int correctNumber = random.Next(1, 10);

                // init guess variable
                int guess = 0;

                // ask user to guess a number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    // get user input and store in input var
                    string input = Console.ReadLine();

                    // deal with invalid input
                    if (!int.TryParse(input, out guess))
                    {
                        // print error message
                        PrintColourMessage(ConsoleColor.Red, "Please enter a valid number...");                        

                        // continue, enter valid input
                        continue;
                    }

                    // cast to int and place in guess var
                    guess = Int32.Parse(input);

                    // match guess to correct number
                    if (guess != correctNumber)
                    {
                        // print colour message
                        PrintColourMessage(ConsoleColor.Red, "Incorrect number, please try again...");
                    }
                }

                // output success message
                // print colour message
                PrintColourMessage(ConsoleColor.Yellow, "Your guess is correct :-)");

                // ask user to play again
                Console.WriteLine("Play again? [y or n]");

                // get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }


        // get and display app info
        static void GetAppInfo()
        {
            // app variables
            string appName = "number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Marty Tyndall";

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            // app header
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text color
            Console.ResetColor();
        }


        // ask for users name and greet
        static void GreetUser()
        {
            // ask users name
            Console.WriteLine("What is your name?");

            // get user input
            string inputName = Console.ReadLine();

            // name output
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // print colour message
        static void PrintColourMessage(ConsoleColor colour, string message)
        {
            // Change text colour
            Console.ForegroundColor = colour;

            // inform user of invalid input
            Console.WriteLine(message);

            // reset text color
            Console.ResetColor();
        }
    }
}
