using Module5Lab;


Player player = new Player("Frankenstein", 1);
player.AddPoints(100);
// Creates a new player with one life and add points to the player's score.

Console.WriteLine("Welcome to the game! Your score is: " + player.GetScore() +
". You have " + player.GetLivesLeft() + " lives left!");
// Welcomes the player. 

player.Kill();
// Kills off the player's character. 

Console.WriteLine("An orc attacks you. Sorry, you were killed. You have " 
+ player.GetLivesLeft() + " lives left! ");
// Informs the player of how many lives they have left. 

SuperPlayer superPlayer = new SuperPlayer();
// Creates a new superplayer (a child class of player)

superPlayer.AddPoints(200);
superPlayer.Fly();
// Tests two methods. 

Console.WriteLine($"SuperPlayer score: {superPlayer.GetScore()}, Lives left: {superPlayer.GetLivesLeft()} ");
// Displays information to the player. 
