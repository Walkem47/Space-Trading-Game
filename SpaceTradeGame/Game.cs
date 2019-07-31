using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTradeGame
{
    class Game
    {
        CharacterClass character = new CharacterClass(); 
        public void run()
        {
            gameTitle();
        }

        public void gameTitle()
        {
            Console.WriteLine($"Welcome Space Trading, {character.name} ");
            Console.WriteLine($"You are an {character.age} year old");

            Console.WriteLine("Press 'Enter' to begin game. ");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public void first()
        {
            Console.WriteLine("You start your journey in at your ship.");
            Console.WriteLine(" What do you want to do next?");
            Console.WriteLine(" 1. Go to your factory?");
            Console.WriteLine(" 2. Go to Starbucks? ");
            Console.WriteLine(" 3. visit another planet? ");
            Console.Write("Choice: ");
            var choice = Console.ReadLine().ToLower();
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
        private  void gameOver()
        {
            throw new NotImplementedException();
        }


    }
}
