using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SpaceTradeGame
{
    public class CharacterClass

    {
        public int currency { get; set; }
        public int age { get; set; }

        public Planet location { get; set; }
        public char appearance { get; set; }
        public string name { get; }
        public CharacterClass()
        {
            name = "Elon";
            age = 18;


        }

    }





}
