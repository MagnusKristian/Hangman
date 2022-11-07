namespace Hangman;

public class MakeGame
{
    public Hangman hangman = new Hangman();
    public bool userWantsExit = false;
    public MakeGame()
    {
        hangman.RunGame();
        while (userWantsExit == false)
        {
            playAgain();
        }
        
    }
    public void playAgain()
    {
        Console.WriteLine("Would you like to play again? Y/N :");
        string yesOrNo = Console.ReadLine().ToLower();
        if (yesOrNo == "y")
        {
            hangman = new Hangman();
            hangman.RunGame();
        }
        else if (yesOrNo == "n")
        {
            Console.WriteLine("Thanks for playing! Goodbye!");
            userWantsExit = true;
        }
    }
}