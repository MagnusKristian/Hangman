namespace Hangman;

public class PrintHangman
{
        string head = " ";
        string leftArm = " ";
        string torso = " ";
        string torsoBottom = " ";
        string rightArm = " ";
        string leftLeg = " ";
        string rightLeg = " ";
        string crate = "[¯¯]";
        string warnUser = "";
    public void Print(int wrongGuess,int rightGuess)
    {
        
        switch (wrongGuess)
        {
            case 0:
                Console.WriteLine("Good luck!");
                break;
            case 1:
                head = "☺";
                break;
            case 2:
                leftArm = "/";
                break;
            case 3:
                torso = "|";
                break;
            case 4:
                rightArm = "\\";
                break;
            case 5:
                leftLeg = "/";
                break;
            case 6:
                rightLeg = "\\";
                torsoBottom = "'";
                warnUser = "ONE MORE WRONG AND IT'S GAME OVER!";
                break;
            case 7:
                warnUser = "";
                crate = "    ";
                break;
            default:
                break;

                

        }
                Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
                Console.WriteLine($"The word is: " /*+ PrintWordLetters()*/);
                Console.WriteLine($"{warnUser}");
                Console.WriteLine($"   ------");
                Console.WriteLine($"   |   |");
                Console.WriteLine($"   {head}   |");
                Console.WriteLine($"  {leftArm}{torso}{rightArm}  |");
                Console.WriteLine($"  {leftLeg}{torsoBottom}{rightLeg}  |");
                Console.WriteLine($"  {crate} |");
                Console.WriteLine($"  ========");
    }
}