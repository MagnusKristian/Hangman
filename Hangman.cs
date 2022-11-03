using System.Text;

namespace Hangman;

public class Hangman
{
    public int rightGuess = 0;
    public int wrongGuess = 0;
    public string allUserGuesses = "";
    public string randomWord = "";
    //public string[] words = { "word", "thing", "sun", "excalibur", "dependencies", "hangman" };
    public string[] words = { "dependencies"};
    public Hangman()
    {
        RunGame();
    }

    public void RunGame()
    {
        Console.WriteLine("Welcome to Hangman! Guess the letters and try to not unalive this poor man.");
        Random random = new Random();

        randomWord = words[random.Next(words.Length)];
        Console.WriteLine($"the word is {randomWord.Length} characters long");

        while (wrongGuess <= 6)
        {
            Console.WriteLine("Enter a letter: ");
            string userInputLetter = Console.ReadLine().ToLower().Substring(0, 1);
            CheckIfRightOrWrong(randomWord, userInputLetter);
            allUserGuesses += userInputLetter;
            Console.WriteLine($"Here is your guesses: {allUserGuesses}");
            Console.WriteLine("--------------------------------");
            PrintHangman();
            if (rightGuess == randomWord.Length)
            {
                Console.WriteLine("Congrats, you won!");
                return;
            }
        }

        Console.WriteLine($"The word was: {randomWord}");

    }

    public string PrintWordLetters()
    {
        string underscoreWord = "";
        string underscoreWordV2 = "";
        foreach (var character in randomWord)
        {
            underscoreWord += "_";
            underscoreWordV2 += "_";
        }

        for (int i = 0; i < randomWord.Length; i++)
        {
            for (int j = 0; j < allUserGuesses.Length; j++)
            {
                if (randomWord[i] == allUserGuesses[j])
                {
                    Console.WriteLine($"RIGHT LETTER: -{allUserGuesses[j]}-");

                    foreach (var letter in allUserGuesses)
                    {
                        int letterPosition = randomWord.IndexOf(randomWord[i]);

                        StringBuilder someString = new StringBuilder(underscoreWordV2);
                        someString[letterPosition] = randomWord[i];
                        underscoreWordV2 = someString.ToString();

                    }


                    //int letterPosition = randomWord.IndexOf(randomWord[i]);

                    //StringBuilder someString = new StringBuilder(underscoreWordV2);
                    //someString[letterPosition] = randomWord[i];
                    //underscoreWordV2 = someString.ToString();

                    //if (underscoreWordV2[i] == allUserGuesses[j])
                    //{

                    //}

                }
            }
        }

        return underscoreWordV2;
    }

    public void CheckIfRightOrWrong(string word, string letter)
    {
        if (word.Contains(letter) == true)
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
        //Console.WriteLine("This is hangman! you have 'x'-right and 'x'-wrong ");
        //Console.WriteLine("  ----");
        //Console.WriteLine("  |  |");
        //Console.WriteLine("  0  |");
        //Console.WriteLine(" /|\\ |");
        //Console.WriteLine(" /'\\ |");
        //Console.WriteLine("     |");
        //Console.WriteLine("   ======");

        switch (wrongGuess)
        {
            case 0://does this one not run?
                Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
                Console.WriteLine("The word is: " + PrintWordLetters());
                Console.WriteLine("  ----");
                Console.WriteLine("  |  |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("   ======");
                break;
            case 1:
                Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
                Console.WriteLine("The word is: " + PrintWordLetters());
                Console.WriteLine("  ----");
                Console.WriteLine("  |  |");
                Console.WriteLine("  0  |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("   ======");
                break;
            case 2:
                Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
                Console.WriteLine("The word is: " + PrintWordLetters());
                Console.WriteLine("  ----");
                Console.WriteLine("  |  |");
                Console.WriteLine("  0  |");
                Console.WriteLine(" /   |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("   ======");
                break;
            case 3:
                Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
                Console.WriteLine("The word is: " + PrintWordLetters());
                Console.WriteLine("  ----");
                Console.WriteLine("  |  |");
                Console.WriteLine("  0  |");
                Console.WriteLine(" /|  |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("   ======");
                break;
            case 4:
                Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
                Console.WriteLine("The word is: " + PrintWordLetters());
                Console.WriteLine("  ----");
                Console.WriteLine("  |  |");
                Console.WriteLine("  0  |");
                Console.WriteLine(" /|\\ |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("   ======");
                break;
            case 5:
                Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
                Console.WriteLine("The word is: " + PrintWordLetters());
                Console.WriteLine("  ----");
                Console.WriteLine("  |  |");
                Console.WriteLine("  0  |");
                Console.WriteLine(" /|\\ |");
                Console.WriteLine(" /   |");
                Console.WriteLine("     |");
                Console.WriteLine("   ======");
                break;
            case 6:
                Console.WriteLine($"You have {rightGuess}-right and {wrongGuess}-wrong ");
                Console.WriteLine("The word is: " + PrintWordLetters());
                Console.WriteLine("  ----");
                Console.WriteLine("  |  |");
                Console.WriteLine("  0  |");
                Console.WriteLine(" /|\\ |");
                Console.WriteLine(" /'\\ |");
                Console.WriteLine("     |");
                Console.WriteLine("   ======");
                break;

            default:
                //Console.WriteLine("Hangman error...");
                break;
        }
    }
}