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
            Console.WriteLine($"You are an {character.age} year old.");
            Console.WriteLine("Press 'Enter' to begin game. ");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public void first()
        {
            Console.WriteLine("Your journey begins on your ship, on Earth ");
            Console.WriteLine(" What do you want to do next?");
            Console.WriteLine(" 1. Go to your factory?");
            Console.WriteLine(" 2. View your account? ");
            Console.WriteLine(" 3. Visit another planet? ");
            Console.Write("Choice: ");
            var choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(" Welcome back to your ship factory.");
                    Console.ReadLine();
                    second();
                    break;
                case "2":
                    Console.WriteLine($" You have {character.currency} Atoms in your account.");
                    Console.WriteLine(" Earn more Atoms as you travel the universe and battle or trade your goods.");
                    third();
                    break;
                case "3":
                    Console.WriteLine("Which planet would you like to visit?");
                    Console.WriteLine("1. Mars");
                    Console.WriteLine("2. Alpha Proxima");
                    Console.Write("Choice:  ");
                    _ = Console.ReadLine().ToLower();
                    Console.Clear();
                    third();
                    break;

            }
        }

        public static void second()
        {
            Random rnd = new Random();
            string[] secOptions = { "You notice a bomb, do you cut the red wire?", "You notice that you are overproduction, would you like to " +
                    "travel to other planets to sell your ships?"};

            int randomNumber = rnd.Next(0, 2);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Yes or No?");
            Console.WriteLine("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "yes")
            {
                second();

            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine(" An asteroid slams into planet earth and destroys everything.");
                Console.WriteLine("Game Over" );
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();


            }
            else
            {
                Console.WriteLine(" ");
            }






        }
        static void third()
        {
            Random rnd = new Random();
            string[] secOptions = { "Before you go, would you like a cup of coffee?", "Before you go, would you like to check your inventory?", " Before " +
                    "you go, would you like to eat something?"};

            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Yes or No?");
            Console.WriteLine("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "yes")
            {
                third();

            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine(" You should have said yes.");
                Console.WriteLine("You suffer a heart attack");
                Console.WriteLine("You're dead");
                Console.WriteLine("Game OVER, Press 'Enter' to continue");
                Console.ReadLine();


            }



           // public void gameOver()
            {
                throw new NotImplementedException();
            }


        }


    }
}
