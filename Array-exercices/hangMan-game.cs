using System;

namespace game
{
    class Program
{
    static void Main(string[] args)
    {
        string[] word = { "google", "water", "calculator", "school", "tissue", "chair", "table", "computer", "code", "laboratory", "charger", "chrome", "safari", "explore", "edge" };
        //Console.Write(word.Length);
        Random random = new Random();
        int randomIndex = random.Next(0, 15);
        string selectedWord = word[randomIndex];
        char wordAlpha = selectedWord[random.Next(0, selectedWord.Length)];
        string hiddenWord = "";
        foreach (int i in selectedWord)
        {
            if (i != wordAlpha)
            {
                hiddenWord += "*";
            }
            else
            {
                hiddenWord += wordAlpha;
            }
        }


        while (hiddenWord.Contains("*"))
        {
            Console.WriteLine("Word: {0} ", hiddenWord);
            Console.Write("Guess a letter - ");


            char letter = char.Parse(Console.ReadLine());
                    
            bool containsLetter = false;
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i] == letter)
                {
                    hiddenWord = hiddenWord.Remove(i, 1);
                    hiddenWord = hiddenWord.Insert(i, letter.ToString());
                    containsLetter = true;
                }
            }
            if (!Char.IsLetter(letter))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Invalid Character.");
                //containsLetter == false;
            }
             else if (containsLetter == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Yes! {0} is in the word", letter);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, {0} is not in the word😪", letter);

            }
            Console.ResetColor();
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Congratulations!! You won. The winning word was {0}.", selectedWord);

    }
}
}