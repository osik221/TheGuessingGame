using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                int guess = 0;
                int guesses = 0;
                int number = rnd.Next(1,101);

                Console.WriteLine("Welcome to the Guessing Game!");
                Console.WriteLine("-----------------------------");

                while (guess != number)
                {
                    Console.Write("Guess a number between 1-100: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!\n");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!\n");
                    }
                    guesses++;
                }
                Console.WriteLine($"It`s the number: {number}!!!!");
                Console.WriteLine("YOU WIN!");
                Console.WriteLine($"Guesses: {guesses}\n");

                playAgain = AskToPlayAgain();
            }
        }
        static bool AskToPlayAgain()
        {
            while(true)
            {
                Console.WriteLine("Do you want to play again?\nYes/No");
                string aswer = Console.ReadLine().ToUpper();
                if ((aswer == "YES"))
                {
                    return true;
                }
                else if ((aswer == "NO"))
                {
                    Console.WriteLine("Goodbye!!!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Write either yes or no");
                }
            }
        }
    }
}
