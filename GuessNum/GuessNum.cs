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
            int min = 1;
            int max = 100;
            int guess;
            int guessCount; // will output total attempts once correct number is guessed
            bool playAgain = true; // for if the user wants to play again after finishing one game
            string repsonse; // will determine if program ends or another game begins


            while (playAgain)
            {
                guess = 0;
                guessCount = 0;
                int answer = random.Next(min, max + 1); // range from min to max + 1 to be inclusive

                while (guess != answer) // to keep the game going until the correct number is guessed
                {
                    System.Console.Write($"Guess a number between {min} - {max}: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine($"You guessed: {guess}");
                    if (guess < answer) // for when the guess is lower than the answer
                    {
                        System.Console.WriteLine($"{guess} was too low!");
                    }
                    else if (guess > answer) // for when the guess is higher than the answer
                    {
                        System.Console.WriteLine($"{guess} was too high!");
                    }
                    guessCount++; // add to total guesses
                }
                guessCount++; // add to count as correct answer is still an attempt
                System.Console.WriteLine($"You guessed the correct number: {answer}");
                System.Console.WriteLine($"It took you only {guessCount} attempts!!!");

                System.Console.Write("Play again? (Y/N): ");
                repsonse = Console.ReadLine().ToUpper();
                if (repsonse == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            System.Console.WriteLine("Thanks for playing!!!");
        }

    }
}