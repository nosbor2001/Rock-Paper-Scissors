using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are to declare 4 variables called player1, player2, numberOfWins1 and numberOfWins2
            //Ask each player in turn to enter ‘R’ for Rock ‘P’ for Paper or ‘S’ for Scissors
            //Then test using Multiple Case Decision If statements(And and Or) each possible outcome and update the scores
            //Because you have not been taught to use a loop you will need to run your program several times to test all conditions for both players.

            string player1;
            string player2;
            int wins1 = 0;
            int wins2 = 0;
            int draws = 0;
            string ans = "Y";



            Console.WriteLine(Globals.rock());

            while (ans == "Y")
            {
                Console.WriteLine("Enter R, P or S");
                Console.Write("Player 1's Turn: ");
                player1 = Console.ReadLine().ToUpper();

                Console.Write("Player 2's Turn: ");
                player2 = Console.ReadLine().ToUpper();

                if (player1 == player2)
                {
                    draws = +1;
                    Console.WriteLine("Draw!");

                }

                else if ((player1 == "R") && (player2 == "S"))
                {
                    wins1 = +1;
                    Console.WriteLine("Player 1 Wins!");
                }

                else if ((player1 == "S") && (player2 == "R"))
                {
                    wins2 = +1;
                    Console.WriteLine("Player 2 Wins!");
                }

                else if ((player1 == "R") && (player2 == "P"))
                {
                    wins2 = +1;
                    Console.WriteLine("Player 2 Wins!");
                }

                else if ((player1 == "P") && (player2 == "R"))
                {
                    wins1 = +1;
                    Console.WriteLine("Player 1 Wins!");
                }

                else if ((player1 == "S") && (player2 == "P"))
                {
                    wins1 = +1;
                    Console.WriteLine("Player 1 Wins!");
                }

                else if ((player1 == "P") && (player2 == "S"))
                {
                    wins2 = +1;
                    Console.WriteLine("Player 2 Wins!");
                }
                else
                {
                    break;
                }
                Console.WriteLine("\nPlayer 1 Wins: " + wins1);
                Console.WriteLine("Player 2 Wins: " + wins2);
                Console.WriteLine("Draws: " + draws);

                Console.Write("Play Again? (Y or N): ");
                ans = Console.ReadLine();

            }

        }
        static class Globals
        {
            public static string rock()
            {
                return @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
";
            }

            public static string paper()
            {
                return @"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
";
            }

            public static string scissors()
            {
                return @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
";
            }


            //public static string ASCII(string c)
            //{
            //    if (c == "R")
            //        return Console.WriteLine(Globals.rock);

            //    if (c == "S")
            //        return Console.WriteLine(scissors);

            //    if (c == "P")
            //        return Console.WriteLine(paper);
            //}
        }
    }
}
