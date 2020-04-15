﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {

        // member variables (HAS A)

        // Constructor (SPAWNER)
        public Game()
        {

        }

        //member methods (CAN DO)
        public void RunGame()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock");
            // 1) Display rules (also include how many rounds!)     [Game]
            Console.WriteLine("In this game, each player will select a gesture, and the winning player will be awarded a point.");
            Console.WriteLine("The winner will be best 3 out of 5");
            Console.WriteLine("Rock beats Scissors and Lizard");
            Console.WriteLine("Scissors beats Paper and Lizard");
            Console.WriteLine("Paper beats Rock and Spock");
            Console.WriteLine("Lizard beats Spock and Paper");
            Console.WriteLine("Spock beats Rock and Scissors");
            // 2) What are we playing? (HvH or HvAI)                [Game]

            //// One round of game ////
            // 3) Display gesture options to the players            [Player]
            // 4) Player 1 chooses gesture                          [Player]
            // 5) Player 2 chooses a gesture                        [Player]
            // 6) Compare gestures (assign a point / check for tie) [Game]
            // 7) Display current score                             [Game]
            // 8) Check for Game Winner (best of 3/5)               [Game]

            // if no                
            // 9a) Repeat steps 3-8
            // if yes
            // 9b) Display final winner                         [Game]

            // 10) Ask to play again?                               [Game]
        }
    }
}
