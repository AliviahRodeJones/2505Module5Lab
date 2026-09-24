using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5Lab
    {
    // Class declaration
    internal class Player
    {
        private string name;
        private int score;
        private int livesLeft;

    


    public Player()
    {
            
    }// end of constructor.
  


    public Player(string name)
        {
            this.name = name;
        }

    public Player(string name, int startingLives)
        {
            this.name = name;

            livesLeft = startingLives;
        }// end constructor

    public int GetScore()
        {
            return score;
        }

    public void AddPoints(int totalPoints)
        {
            score += totalPoints;
            
        }// end method. 

    public void Kill()
        {
            // Ensure lives don't go below 0.
            if (livesLeft > 0)
            {
                // Remove one of their lives when they get killed. 
                livesLeft--;
            }
        } // end of kill method. 

        public int GetLivesLeft()
        {
            return livesLeft;
            // Returns the number of lives the player has left. 
        }


}
}
