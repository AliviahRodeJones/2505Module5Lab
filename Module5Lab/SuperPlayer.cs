namespace Module5Lab
{
    // Class declaration. Creates a class with the Player class as a parent class. 
    internal class SuperPlayer : Player
    {
        
        // Methods specific to SuperPlayer. 
        public void Fly()
        {
            Console.WriteLine("SuperPlayer is flying!");
            // Prints a message to the user. 
        }// end method.
    }
}