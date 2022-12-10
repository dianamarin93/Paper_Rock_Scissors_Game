using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paper_Rock_Scissors_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Play_Game();
        }

        public static void Play_Game()
        {
            Random rd = new Random();
            List<char> computerChoices = new List<char>() { 'S', 'P', 'R' };

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            int numberOfGames = 5;
            int playerScore = 0;
            int computerScore = 0;
            int roundsCounter = 0;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Round {++roundsCounter}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter one of the characters: S, P or R");
                char playerChoice = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (playerChoice)
                {
                    case 'S':
                        Console.WriteLine($"Player choose {playerChoice} - Scissors.");
                        break;
                    case 'P':
                        Console.WriteLine($"Player choose {playerChoice} - Paper.");
                        break;
                    case 'R':
                        Console.WriteLine($"Player choose {playerChoice} - Rock.");
                        break;
                    default:
                        Console.WriteLine("Erorr! Please enter the character corresponding to the game!");
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Black;
                char computerPlay = computerChoices[rd.Next(computerChoices.Count)];
                Console.WriteLine($"Computer choose {(computerPlay == 'S' ? "Scissors" : computerPlay == 'P' ? "Paper" : "Rock")}");


                if (computerPlay == 'S' && playerChoice == 'P')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Computer wins!");
                    computerScore++;
                    numberOfGames--;
                }
                else if (computerPlay == 'P' && playerChoice == 'S')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Player wins!");
                    playerScore++;
                    numberOfGames--;
                }
                else if (computerPlay == 'S' && playerChoice == 'R')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Player wins!");
                    playerScore++;
                    numberOfGames--;
                }
                else if (computerPlay == 'R' && playerChoice == 'S')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Computer wins!");
                    computerScore++;
                    numberOfGames--;
                }
                else if (computerPlay == 'R' && playerChoice == 'P')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Player wins!");
                    playerScore++;
                    numberOfGames--;
                }
                else if (computerPlay == 'P' && playerChoice == 'R')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Computer wins!");
                    computerScore++;
                    numberOfGames--;
                }
                else if (computerPlay == 'P' && playerChoice == 'P')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Draw");
                    numberOfGames--;
                }
                else if (computerPlay == 'R' && playerChoice == 'R')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Draw");
                    numberOfGames--;
                }
                else if (computerPlay == 'S' && playerChoice == 'S')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Draw");
                    numberOfGames--;
                }
                else
                {
                    Console.WriteLine("Invalid game!");
                }

                if (numberOfGames == 0)
                {
                    if (computerScore > playerScore)
                    {
                        Console.WriteLine($"The winner of the game is the computer, which has the score {computerScore}");
                    }
                    else if (playerScore > computerScore)
                    {
                        Console.WriteLine($"The winner of the game is the player, which has the score {playerScore}");
                    }
                    else
                    {
                        Console.WriteLine("Equality!");
                    }

                    Console.WriteLine("Replay? Press 'Y' for yes or any key for quit. ");
                    char response = char.Parse(Console.ReadLine());
                    response = Char.ToLower(response);

                    if (response == 'y')
                    {
                        Play_Game();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Press any key to close the console");
            Console.ReadKey();
        }
    }
}
