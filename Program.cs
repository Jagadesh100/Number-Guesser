using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            int guesses;
            //Runs to get Application Information
            GetAppInfo();

            //asks the userName
            GreetInfo();

            while(true)
            {
                guesses = 0;

                //create a Random object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(min, max);

                //Init guess var
                int guessNumber = 0;

                //Ask user for a number
                Console.WriteLine("Guess a Number between {0} and {1}", min, max);

                while(guessNumber!=correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //Make sure it's a Number
                    if(!int.TryParse(input,out guessNumber))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Please Enter a actual Number");

                        //keep going
                        continue;
                    }
                    guessNumber = Int32.Parse(input);

                    //Match guess to correctNumber
                    if(guessNumber!=correctNumber)
                    {
                        //Tell user it's  wrong number
                        PrintColorMessage(ConsoleColor.Red, "Wrong number,please try again");
                        if(guessNumber>correctNumber)
                        {
                            PrintColorMessage(ConsoleColor.DarkGreen, "Guess Number is higher than Actual Number");
                        }
                        else if(guessNumber<correctNumber)
                        {
                            PrintColorMessage(ConsoleColor.DarkGreen, "Guess Number is lower than Actual Number");
                        }
                    }
                    guesses++;
                }
                //Tell user it's correct number
                Console.WriteLine("Number:" + correctNumber);
                Console.WriteLine("Guesses:" + guesses);
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!!!");

                //Ask the user to continue or not
                Console.WriteLine("Would You like to Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    PrintColorMessage(ConsoleColor.Yellow, "Thanks for Playing!!!");
                    return;
                }
                else
                {
                    PrintColorMessage(ConsoleColor.Yellow, "Thanks for Playing!!!");
                    return;
                }
            }
        }

        //Get and Display App info
        static void GetAppInfo()
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jagadesh";

            //Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0} :Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Text Color
            Console.ResetColor();
        }
        //Asks username and greet
        static void GreetInfo()
        {
            //Asks User Name
            Console.WriteLine("Enter Your Name:");

            //Get user input
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0},let's play a game...", userName);

        }

        //print color Message
        static void PrintColorMessage(ConsoleColor color,string message)
        {
            //change text color
            Console.ForegroundColor = color;

            //Tell user it's not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
