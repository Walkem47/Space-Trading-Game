using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTradeGame
{
    class Game
    {
        CharacterClass character = new CharacterClass();
        Planet name = new Planet(); 
        public void run()
        {
            gameIntro();
        }

        public void gameIntro()
        {
            Console.WriteLine($"Welcome Space Trading, {character.name} ");
            Console.WriteLine($"You are an {character.age} year old with {character.currency} Atoms in your account.");
            Console.WriteLine("Press 'Enter' to begin game. ");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public void first()
        {
            Console.WriteLine($"Your journey begins on your ship, on");
            Console.WriteLine(" What do you want to do next?");
            Console.WriteLine(" 1. Go to your factory?");
            Console.WriteLine(" 2. View your account? ");
            Console.WriteLine(" 3. visit another planet? ");
            Console.Write("Choice: ");
            var choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(" Welcome back to your factory.");
                    break; 
                case "2":
                    Console.WriteLine($" You now have {character.currency} Atoms");
                    Console.WriteLine(" Earn more Atoms as you travel the universe and battle or trade your goods."); 
                    break; 
                case "3":
                    Console.WriteLine("Which planet would you like to visit?"); 
                    break; 
                    //Come up with statements that explain the outcome of your choice. 
                    {
                        
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
