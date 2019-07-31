using LanguageExt;
using LanguageExt.TypeClasses;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D; 

namespace SpaceTradeGame
{
    class Program
    {
        private static string choice;

        static void Main(string[] args)
        {
            gameTitle();

        }

        public static void gameTitle()
        {
            Console.WriteLine("Welcome Space Trading. ");
            Console.WriteLine("Press 'Enter' to begin game. ");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first()
        {
            Console.WriteLine("You start your journey in at your ship.");
            Console.WriteLine(" What do you want to do next?");
            Console.WriteLine(" 1. Go to your factory?");
            Console.WriteLine(" 2. Go to Starbucks? ");
            Console.WriteLine(" 3. visit another planet? ");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "2":
                case "3":
                    //Come up with statements that explain the outcome of your choice. 
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        gameOver();
                        break;

                    }

            }


            
                




        }

        private static void gameOver()
        {
            throw new NotImplementedException();
        }
    }
}
    
