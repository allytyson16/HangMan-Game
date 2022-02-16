using System;

namespace udemy_exercises
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
            string hiddenWord = "";
            for(int i = 0; i < selectedWord.Length; i++)
            {
                hiddenWord += "*";
            }
            while(hiddenWord.Contains("*"))
            {
                Console.WriteLine("Word: {0} ", hiddenWord);
                Console.Write("Guess a letter - ");
                char letter = char.Parse(Console.ReadLine());
                bool containsLetter = false;
                for(int i = 0; i < selectedWord.Length; i++)
                {
                    if(selectedWord[i] == letter)
                    {

                    }
                }
            }

;        }
    }
}