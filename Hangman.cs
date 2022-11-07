using System.Text;

namespace Hangman;

public class Hangman
{
    public int rightGuess = 0;
    public int wrongGuess = 0;
    public string allUserGuesses = "";
    public string randomWord = "";
    public string[] words = { "word", "thing", "sun", "excalibur", "dependencies", "hangman" };
    //public string[] words = { "dependencies"};
    public string underscoreWord = "";
    string head = " ";
    string leftArm = " ";
    string torso = " ";
    string torsoBottom = " ";
    string rightArm = " ";
    string leftLeg = " ";
    string rightLeg = " ";
    string crate = "[¯¯]";
    string warnUser = "";
    public Hangman()
    {
        //RunGame();
    }

    
    public void RunGame()
    {
        Console.WriteLine("Welcome to Hangman! Guess the letters and try to not unalive this poor man.");
        setRandomWord();

        while (true)
        {
            if (wrongGuess >= 7)
            {
                Console.WriteLine("Sorry you lost the game...");
                Console.WriteLine($"The word was: {randomWord}");
                return;
            }
            if(randomWord == underscoreWord)
            {
                Console.WriteLine("Congrats! You won.");
                return;
            }
            
            Console.WriteLine("Enter a letter: ");
            string userInputLetter = Console.ReadLine().ToLower().Substring(0, 1);
            
            if (!allUserGuesses.Contains(userInputLetter))
            {
                //Console.Clear();
                CheckIfRightOrWrong(randomWord, userInputLetter);
                allUserGuesses += userInputLetter;
                //Console.WriteLine($"Here is your guesses: {allUserGuesses}");
                Console.WriteLine("--------------------------------");
                Console.WriteLine();
                PrintHangman();

            }
            else if(allUserGuesses.Contains(userInputLetter))
            {
                Console.WriteLine("You have already guessed this letter, try again.");
            }
        }
    }

    public void setRandomWord()
    {
        Random random = new Random();

        randomWord = words[random.Next(words.Length)];
        Console.WriteLine($"the word is {randomWord.Length} characters long");
        foreach (var character in randomWord)
        {
            underscoreWord += "_";
        }
    }
    public string PrintWordLetters()
    {
        for (int i = 0; i < randomWord.Length; i++)
        {
            for (int j = 0; j < allUserGuesses.Length; j++)
            {
                if (randomWord[i] == allUserGuesses[j])
                {
                    StringBuilder someString = new StringBuilder(underscoreWord);
                    someString[i] = allUserGuesses[j];
                    underscoreWord = someString.ToString();
                }
            }
        }
        return underscoreWord;
    }

    public void CheckIfRightOrWrong(string word, string letter)
    {
        if (word.Contains(letter))
        {
            rightGuess++;
        }
        else
        {
            wrongGuess++;
        }
    }

    public void PrintHangman()
    {

        //PrintMan.Print(wrongGuess,rightGuess);
        
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
        Console.WriteLine($"The word is: " + PrintWordLetters());
        Console.WriteLine($"{warnUser}");
        Console.WriteLine($"   ------");
        Console.WriteLine($"   |   |");
        Console.WriteLine($"   {head}   |");
        Console.WriteLine($"  {leftArm}{torso}{rightArm}  |");
        Console.WriteLine($"  {leftLeg}{torsoBottom}{rightLeg}  |");
        Console.WriteLine($"  {crate} |");
        Console.WriteLine($"  ========");
        
        //---------------------------------


        //switch (wrongGuess)
        //{
        //    case 0:
        //        Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
        //        Console.WriteLine("The word is: " + PrintWordLetters());
        //        Console.WriteLine("   -----");
        //        Console.WriteLine("   |   |");
        //        Console.WriteLine("       |");
        //        Console.WriteLine("       |");
        //        Console.WriteLine("       |");
        //        Console.WriteLine("  [¯¯] |");
        //        Console.WriteLine("  ========");
        //        break;
        //    case 1:
        //        Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
        //        Console.WriteLine("The word is: " + PrintWordLetters());
        //        Console.WriteLine("   -----");
        //        Console.WriteLine("   |   |");
        //        Console.WriteLine("   ☺   |");
        //        Console.WriteLine("       |");
        //        Console.WriteLine("       |");
        //        Console.WriteLine("  [¯¯] |");
        //        Console.WriteLine("  ========");
        //        break;
        //    case 2:
        //        Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
        //        Console.WriteLine("The word is: " + PrintWordLetters());
        //        Console.WriteLine("   -----");
        //        Console.WriteLine("   |   |");
        //        Console.WriteLine("   ☺   |");
        //        Console.WriteLine("  /    |");
        //        Console.WriteLine("       |");
        //        Console.WriteLine("  [¯¯] |");
        //        Console.WriteLine("  ========");
        //        break;
        //    case 3:
        //        Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
        //        Console.WriteLine("The word is: " + PrintWordLetters());
        //        Console.WriteLine("   -----");
        //        Console.WriteLine("   |   |");
        //        Console.WriteLine("   ☺   |");
        //        Console.WriteLine("  /|   |");
        //        Console.WriteLine("       |");
        //        Console.WriteLine("  [¯¯] |");
        //        Console.WriteLine("  ========");
        //        break;
        //    case 4:
        //        Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
        //        Console.WriteLine("The word is: " + PrintWordLetters());
        //        Console.WriteLine("   -----");
        //        Console.WriteLine("   |   |");
        //        Console.WriteLine("   ☺   |");
        //        Console.WriteLine("  /|\\  |");
        //        Console.WriteLine("       |");
        //        Console.WriteLine("  [¯¯] |");
        //        Console.WriteLine("  ========");
        //        break;
        //    case 5:
        //        Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
        //        Console.WriteLine("The word is: " + PrintWordLetters());
        //        Console.WriteLine("   -----");
        //        Console.WriteLine("   |   |");
        //        Console.WriteLine("   ☺   |");
        //        Console.WriteLine("  /|\\  |");
        //        Console.WriteLine("  /    |");
        //        Console.WriteLine("  [¯¯] |");
        //        Console.WriteLine("  ========");
        //        break;
        //    case 6:
        //        Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
        //        Console.WriteLine("The word is: " + PrintWordLetters());
        //        Console.WriteLine("ONE MORE WRONG AND IT'S GAME OVER!");
        //        Console.WriteLine("   ------");
        //        Console.WriteLine("   |   |");
        //        Console.WriteLine("   0   |");
        //        Console.WriteLine("  /|\\  |");
        //        Console.WriteLine("  /'\\  |");
        //        Console.WriteLine("  [¯¯] |");
        //        Console.WriteLine("  ========");
        //        break;
        //    case 7:
        //        Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
        //        Console.WriteLine("The word is: " + PrintWordLetters());
        //        Console.WriteLine("   ------");
        //        Console.WriteLine("   |   |");
        //        Console.WriteLine("   0   |");
        //        Console.WriteLine("  /|\\  |");
        //        Console.WriteLine("  /'\\  |");
        //        Console.WriteLine("       |");
        //        Console.WriteLine("  ========");
        //        break;

        //    default:
        //        //Console.WriteLine("Hangman error...");
        //        break;
        //}
    }
}