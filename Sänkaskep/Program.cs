using System;

namespace Sänkaskep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define variables
            Random r = new Random();
            int ship = r.Next(1, 11);
            string sGuess = "";
            int iGuess = -1;
            bool parse = false;
            bool control = false;
            int diff = 0;
            bool game = true;
            int guesses = 1;


            Console.WriteLine("Welcome to the game!");
            while (game)
            {
                iGuess = -1;
                parse = false;
                control = false;
                diff = 0;

                System.Console.WriteLine("Guess my number between from 1 to 10!");
                sGuess = Console.ReadLine();

                //Check that it is in correct format
                parse = int.TryParse(sGuess, out iGuess);
                if (iGuess > 0 & iGuess <= 10)
                {
                    control = true;
                }

                while (parse == false || control == false)
                {
                    if (parse == false)
                    {
                        System.Console.WriteLine("You didn't enter an integer!");
                    }
                    else
                    {
                        System.Console.WriteLine("Your number was not between 1-10!");
                    }

                    sGuess = Console.ReadLine();

                    parse = int.TryParse(sGuess, out iGuess);
                    if (iGuess > 0 & iGuess <= 10)
                    {
                        control = true;
                    }
                }

                //Calculates diff
                diff = GuessCheck(ship, iGuess);

                if (diff == 0)
                {
                    System.Console.WriteLine("Correct! You made it in " + guesses + " guesses!");
                    game = false;

                }
                else if (diff >= -3 & diff <= 3)
                {
                    System.Console.WriteLine("So close! You're 3 steps away!");
                }
                else
                {
                    System.Console.WriteLine("Nope, not even close!");
                }
                guesses++;
            }
            Console.ReadLine();
        }


        static int GuessCheck(int s, int g)
        {
            int a = s - g;

            return a;
        }
    }
}
