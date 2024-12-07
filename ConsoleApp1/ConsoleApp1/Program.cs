//Guess the word Game

using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Threading;
using System.IO;
using System.Threading.Tasks.Sources;

namespace ConsoleApp1
{
    internal class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("      Welcome to Number Sequence Memory");
            Console.WriteLine("Enter username");
            string  user= Console.ReadLine();
            int points = 0;
            int level = 1;
            string fileName = "PS C:\\Users\\Zarrouk\\Desktop\\score.csv";
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
                    points++;
                }
                else
                {
                    Console.WriteLine("You Lost");
                    Console.WriteLine("The correct number was" + generatedNumber);
                    SaveToCSV(fileName, user, points);
                    break;
                }
            }
            string Add(string s)
                {
                    return s+ Convert.ToString(rnd.Next(0,10));
                }
            void SaveToCSV(string filename,string user, int points)
            {
                string UserScore = user + ";" + points;
                File.WriteAllText(filename, UserScore+Environment.NewLine);
            }
            

        }
    }
}
