using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class HumanPlayer : Player
    {
        // member variables (HAS A)
        public string userInput;
        
        // Constructor (SPAWNER)
        public HumanPlayer()
        {

        }

        //member methods (CAN DO)
        public override void ChooseGesture()
        {
            List<string> Gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            Console.WriteLine("Please enter a gesture: rock/paper/scissors/lizard/spock and press Enter:");
            string userInput = Console.ReadLine();

            if (userInput == "rock")
            {
                gesture = 0;
            }
            else if (userInput == "paper")
            {
                gesture = 1;
            }
            else if (userInput == "scissors")
            {
                gesture = 2;
            }
            else if (userInput == "lizard")
            {
                gesture = 3;
            }
            else if (userInput == "spock")
            {
                gesture = 4;
            }
            else ChooseGesture();
            return;
        }
        
    }
}
