using System;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random num = new Random();
            int rndNum = num.Next(1, 27); //change number to 27 from 26
            string yourGuess;
            bool win = false;
            string rndNumber = rndNum.ToString();
            int guessCount = 1;

            while (win == false)
            {
                Console.WriteLine("Guess the number between 1 and 26"); //changed string to reflect number change to 26
                yourGuess = Console.ReadLine();

                if (yourGuess == rndNumber)
                {
                    Console.WriteLine($"Congrats you guessed the number in {guessCount} guess(es)!");
                    win = true;
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("Sorry, try again. Make sure you enter a number.");
                    win = false;
                    guessCount += 1;
                    
                }
            }
            




        }
    }
}
