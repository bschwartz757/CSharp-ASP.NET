using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1
{
    // BLAKE SCHWARTZ    SECTION 3192        11/5/2014
     /* This midterm covers variables, operators, arrays, loops, selection(if statements) and methods.

The goal of this project is to create a guessing game. The game should generate a number between 1 and 500. 
     * The player gets 10 tries to guess the number. With each guess the game will notify the player whether 
     * the guess is too high, too low or correct.  If the player correctly guesses the number, the program will 
     * stop asking for guesses, congratulate the player and show the player's score. The score is 10 minus 
     * the number of guesses. The game should then prompt whether the player wants to play again. If the player
     * responds yes, start the play over, if no, end the game and display all the players scores and their
     * average scores.

The project is a console application.

List the inputs for this program.

List the outputs.

List the steps required to get from the inputs to the outputs (algorithm).

Break the project into appropriate methods.

Use an array to track scores for the games played.

Use proper naming conventions and document code.

General suggestions: break the game into discrete parts. Test each part and make sure it is working before going on the next part. 
     * Draw a picture if you need to, write out a list of the steps in the game.

Turn this in the same way you turn in your usual assignments.
     * */
    class Program
    {
        int number;
        int[] GetScore = new int[5];
        int GameCount = 0;

        /* 
         //Steps:
         // 1) Generate random number between 1 & 500;
         // 2) User input (guess);
         // 3) Selection: too high, too low, or correct;
         // 4) Ten tries to guess number (loops);
         // 5) Calculate score (array);
         // 6) End, or start over (loop) */
        static void Main(string[] args)
        {
            Program p = new Program();
            p.StartGame();
        }

        // Generate random number:
        private void GetRandom()
        {
            Random rand = new Random();
            number = rand.Next(1, 501);
        }
       
        // Initialize game; this is the main method of the program
        private void StartGame()
        {
            GetRandom();
            int Score = 10;
            GameCount++;
            // For loop; this takes the user inputs and constitutes the primary actions of the game
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Guess a number between 1 and 500");
                int Guess = int.Parse(Console.ReadLine());
                if (Guess > number)
                {
                    Console.WriteLine("Your guess was too high");
                }
                else if (Guess < number)
                {
                    Console.WriteLine("Your guess was too low");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number.");
                    break;
                }
                Score--;
            }
            GetScore[GameCount] = Score - 1;
            Console.WriteLine("Your score is {0}", Score - 1);
            Console.ReadKey();

            PlayAgain();
        }

        // Gives player the ability to play the game again
        private void PlayAgain()
        {
            Console.WriteLine("Do you want to play again? Yes or No");
            string keepPlaying = Console.ReadLine();
            if (keepPlaying == "Yes" || keepPlaying == "yes")
            {
                StartGame();
            }
            else
            {
                Console.WriteLine("Thank you for playing!");
                double AverageScore = GetScore.Sum() / GameCount;
                Console.WriteLine("Your average score is {0}", AverageScore);
                Console.ReadKey();
            }
        }
    }
}
