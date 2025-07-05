// app that creates a guessing number game
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace MyProgram
{
    class GameProgram //creates Game class
    {
        static void Main(string[] args)
        {
            GameProgram test = new GameProgram(); // create GameProgram object
            test.GuessNum(); // call the game method


            Console.ReadKey(); // easier to read console output
        }

        // creates the number guessing game
        public void GuessNum()
        {
            Random random = new Random(); // create random object
            int answer = random.Next(1, 101); // range from 1 - 100
            System.Console.Write("Guess a number from 1 - 100: "); // guide user to input a number
            int guess = Convert.ToInt32(Console.ReadLine()); // convert input to interval
            

            while (guess != answer) // to keep the game going until the correct number is guessed
            {
                if (guess < answer) // for when the guess is lower than the answer
                {
                    System.Console.WriteLine("Guess was too low!");
                    System.Console.Write("Guess again: "); // guide the user to enter another number
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                if (guess > answer) // for when the guess is higher than the answer
                {
                    System.Console.WriteLine("Guess was too high!");
                    System.Console.Write("Guess again: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }
            System.Console.WriteLine($"You guessed the correct number: {answer}\nCongrats to you!!!");
        }

    }
}