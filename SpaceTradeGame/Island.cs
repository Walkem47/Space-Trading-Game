using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTradeGame
{
    public class Island
    {
        public string name { get; set; }
        public (double, double) location { get; set; }

        public IslandStatus islandStatus { get; set; }

    }

    public enum IslandStatus { Hostile, Trading }; 
}
