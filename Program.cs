using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry point method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to get user info input

            GreetUser(); //Ask for users name and greet

            while (true)
            {
                //int correctNumber = 7;

                //Create a new Random Object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //Make sure user entered a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use a number!");

                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong... Please try again...");
                    }

                }

                //Output success message

                //Print SUCCESS message
                PrintColorMessage(ConsoleColor.Yellow, "Correct!!! :D :D :D");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        //Get and display app info
        static void GetAppInfo()
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "CodeLeonn";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            /*^ above code uses everything after "" to fill in 0 based {x} items*/

            //Reset Text color
            Console.ResetColor();
        }

        //Ask users name and greet
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input as a string
            string inputName = Console.ReadLine();

            //Speak to user
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Print colour message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            // Tell user input is not a number
            Console.WriteLine(message);

            //Reset Text color
            Console.ResetColor();
        }
    }
}
