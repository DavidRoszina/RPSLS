using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class AIPlayer : Player
    {
        // member variables (HAS A)
        //public string randomGesture;
        //public string gestureToPerform;
        // Constructor (SPAWNER)
        public AIPlayer()
        {
            
        }

        //member methods (CAN DO)
        public override void ChooseGesture()
        {
            var aiGesture = new Random();
            var list = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
            int index = aiGesture.Next(list.Count);
            Console.WriteLine("The computer has chosen: " + list[index]);

            if (index == 0)
            {
                gesture = 0;
            }
            else if (index == 1)
            {
                gesture = 1;
            }
            else if (index == 2)
            {
                gesture = 2;
            }
            else if (index == 3)
            {
                gesture = 3;
            }
            else if (index == 4)
            {
                gesture = 4;
            }
            else ChooseGesture();
            return;
        }
    }
}
