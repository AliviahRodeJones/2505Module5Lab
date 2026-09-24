using Module5Lab;

// Create a new player with one life and add points to the player's score.

Player player = new Player("Frankenstein", 1);
player.AddPoints(100);

Console.WriteLine("Welcome to the game! Your score is: " + player.GetScore() +
". You have " + player.GetLivesLeft() + " lives left!");

// Kills off the player's character. 
player.Kill();

Console.WriteLine("An orc attacks you. Sorry, you were killed. You have " 
+ player.GetLivesLeft() + " lives left! ");

// Creates a new superplayer (a child class of player)
SuperPlayer superPlayer = new SuperPlayer();

superPlayer.AddPoints(200);
superPlayer.Fly();

Console.WriteLine($"SuperPlayer score: {superPlayer.GetScore()}, Lives left: {superPlayer.GetLivesLeft()} ");



