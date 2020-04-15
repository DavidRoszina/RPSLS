using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        // member variables (HAS A)
        public int score;
        public int gesture;
        // Constructor (SPAWNER)
        public Player()
        {
            
        }

        //member methods (CAN DO)

        public abstract void ChooseGesture();
            
        
    }
}
