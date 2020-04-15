using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {

      // member variables (HAS A)
        public int pointsToWin;
        public Player player1;
        public Player player2;
        

        // Constructor (SPAWNER)
        public Game()
        {
            pointsToWin = 3;
            player1 = new HumanPlayer();
        }

        //member methods (CAN DO)
        public void RunGame()
        {
            DisplayRules();
            SelectGameMode();
            // 1) Display rules (also include how many rounds!)     [Game] *
            // 2) What are we playing? (HvH or HvAI)                [Game] *

            //// One round of game ////
            DisplayGestureOptions();
            while (player1.score < pointsToWin && player2.score < pointsToWin)
            {
                Console.WriteLine("Starting round!");

                player2.ChooseGesture();
                player1.ChooseGesture();
                CompareGestures();
                DisplayCurrentScore();
            }
            DisplayWinner();
            // 3) Display gesture options to the players            [Game] *

            // 4) Player 1 chooses gesture 

            // 5) Player 2 chooses a gesture                        [Player]*

            // 6) Compare gestures (assign a point / check for tie) [Game]

            // 7) Display current score                             [Game]

            // 8) Check for Game Winner (best of 3/5)               [Game]*
            
            // if no                
            // 9a) Repeat steps 3-8
            // if yes
            // 9b) Display final winner                             [Game]

            // 10) Ask to play again?                               [Game]
        }
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock");
            Console.WriteLine("In this game, each player will select a gesture, and the winning player will be awarded a point.");
            Console.WriteLine("The winner will be best 3 out of 5");
            Console.WriteLine("Rock beats Scissors and Lizard");
            Console.WriteLine("Scissors beats Paper and Lizard");
            Console.WriteLine("Paper beats Rock and Spock");
            Console.WriteLine("Lizard beats Spock and Paper");
            Console.WriteLine("Spock beats Rock and Scissors");
        }

        public void SelectGameMode()
        {
            Console.WriteLine("Enter 1 to play Human vs AI, or enter 2 to play Human vs Human:");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                // HvC game
                player2 = new AIPlayer();
            }
            else if (userInput == "2")
            {
                // HvH game
                player2 = new HumanPlayer();
            }
            else
            {
                SelectGameMode();
            }
        }

        public void DisplayGestureOptions()
        {
            Console.WriteLine("Players will choose a gesture from the list: rock, paper, scissors, lizard, spock");
        }

        public void CompareGestures()
        {
            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("It was a tie!");
            }
            else if ((player1.gesture == 0 && player2.gesture == 2) || (player1.gesture == 0 && player2.gesture == 3))
            {
                Console.WriteLine("Player 1 wins the round!");
                player1.score++;
            }
            else if ((player1.gesture == 1 && player2.gesture == 0) || (player1.gesture == 1 && player2.gesture == 4))
            {
                Console.WriteLine("Player 1 wins the round!");
                player1.score++;
            }
            else if ((player1.gesture == 2 && player2.gesture == 1) || (player1.gesture == 2 && player2.gesture == 3))
            {
                Console.WriteLine("Player 1 wins the round!");
                player1.score++;
            }
            else if ((player1.gesture == 3 && player2.gesture == 1) || (player1.gesture == 3 && player2.gesture == 4))
            {
                Console.WriteLine("Player 1 wins the round!");
                player1.score++;
            }
            else if ((player1.gesture == 4 && player2.gesture == 0) || (player1.gesture == 4 && player2.gesture == 2))
            {
                Console.WriteLine("Player 1 wins the round!");
                player1.score++;
            }
            else
            {
                Console.WriteLine("Player 2 wins the round!");
                player2.score++;
            }
        }
        public void DisplayCurrentScore()
        {
            Console.WriteLine("Player 1 Score:" + player1.score);
            Console.WriteLine("Player 1 Score:" + player2.score);
        }
        public void DisplayWinner()
        {
            if (player1.score == pointsToWin)
            {
                Console.WriteLine("Player 1 Wins the game!");
            }
            else if (player2.score == pointsToWin)
            {
                Console.WriteLine("Player 2 Wins the game!");
            }
            else
            {
                return;
            }
        }

    }
}
