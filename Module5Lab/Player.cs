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

    

    // Three constructor methods. One with no parameters, one with only one parameter, and one with two parameters. 
    public Player()
    {
            
    }// end of constructor.
  
    public Player(string name)
        {
            this.name = name;
        }// end constructor

    public Player(string name, int startingLives)
        {
            this.name = name;

            livesLeft = startingLives;
        }// end constructor

    // A method that returns the users score. 
    public int GetScore()
        {
            return score;
        }
    // A method that adds points to the players score. Passes a int to the method. 
    public void AddPoints(int totalPoints)
        {
            score += totalPoints;
            
        }// end method. 

    // This method removes a life from the player. 
    public void Kill()
        {
            // Ensure lives don't go below 0.
            if (livesLeft > 0)
            {
                livesLeft--;
            }
        } // end of  method. 

        // Returns the number of lives the player has left. 
        public int GetLivesLeft()
        {
            return livesLeft;
            // Returns the number of lives the player has left. 
        } // end of methd. 


}
}
