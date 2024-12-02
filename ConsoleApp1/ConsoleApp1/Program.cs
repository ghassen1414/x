//Guess the word Game

using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("      Welcome to Number Sequence Memory");
            int level = 1;
            string generatedNumber = "";
            while (true)
            {
                Console.WriteLine("Generating Number..");
                generatedNumber = Add(generatedNumber);
                Console.WriteLine(generatedNumber);
                Console.WriteLine("You have 3 seconds to memorize the number");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Enter the Number:");
                string guessendNumber = Console.ReadLine();
                if (guessendNumber == generatedNumber)
                {
                    Console.WriteLine("Good Job");
                    level++;
                }
                else
                {
                    Console.WriteLine("You Lost");
                    Console.WriteLine("The correct number was"+generatedNumber);
                    break;
                }




                string Add(string s)
                {
                    return s+ Convert.ToString(rnd.Next(0,10));
                }
            }
        }
    }
}
