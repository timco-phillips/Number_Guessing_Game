using System;
using System.Collections.Generic;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random num = new Random();
            int rndNum = num.Next(1, 31); //change number to 30 from 31
            string yourGuess;
            bool win = false;
            string rndNumber = rndNum.ToString();
            int guessCount = 0;
            string temp;
            List<string> guesses = new List<string>(); //list to hold all of the guesses

            while (win == false)
            {
                Console.Write("Guess a number between 1 and 30: "); //formatted the sentence a little differently
                yourGuess = Console.ReadLine();
                guessCount += 1;
                guesses.Add(yourGuess);                                 //add guess to list

                if (yourGuess == rndNumber)
                {
                    Console.WriteLine($"\nCongrats you guessed the number in {guessCount} guess(es)!");
                    win = true;
                    Console.ReadKey();
                }

                else if ((int.Parse(yourGuess) + 3).ToString() == rndNumber || (int.Parse(yourGuess) - 3).ToString() == rndNumber
                      || (int.Parse(yourGuess) + 2).ToString() == rndNumber || (int.Parse(yourGuess) - 2).ToString() == rndNumber
                      || (int.Parse(yourGuess) + 1).ToString() == rndNumber || (int.Parse(yourGuess) - 1).ToString() == rndNumber)
                      
                {
                    if ((int.Parse(yourGuess) + 1).ToString() == rndNumber || (int.Parse(yourGuess) - 1).ToString() == rndNumber)
                    {
                        temp = "Hot";
                        Console.WriteLine($"\n{temp}\n");
                        Console.WriteLine("=====================");
                        Console.WriteLine("= You have guessed: = ");
                        foreach (string guess in guesses)
                        {
                            Console.WriteLine($"=\t{guess}\t    =");                                    //shows all the previous guesses
                        }
                        Console.WriteLine("=====================\n");
                    }
                    else
                    {
                        temp = "warm";
                        Console.WriteLine($"\n{temp}...\n");
                        Console.WriteLine("=====================");
                        Console.WriteLine("= You have guessed: = ");
                        foreach (string guess in guesses)
                        {
                            Console.WriteLine($"=\t{guess}\t    =");                                    //shows all the previous guesses
                        }
                        Console.WriteLine("=====================\n");
                    }
                }

                //else if ()
                else
                {
                    Console.WriteLine("\n -- Sorry, try again. Make sure you enter a number. --\n");   //Added some formatting
                    Console.WriteLine("=====================");
                    Console.WriteLine("= You have guessed: = ");
                    foreach (string guess in guesses)
                    {
                        Console.WriteLine($"=\t{guess}\t    =");                                    //shows all the previous guesses
                    }
                    Console.WriteLine("=====================\n");
                    win = false;
                }
            }
            




        }
    }
}
