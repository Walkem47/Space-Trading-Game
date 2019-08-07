using DocumentFormat.OpenXml.Wordprocessing;
using MediaFoundation.OPM;
using System;
using System.Drawing;



namespace SpaceTradeGame
{
    public class Planet
    {
        public string name;

        public Island[] Islands { get; set; }

        public (double, double) location;

        public Planet()
        {
            this.name = "Earth";
            this.location = (10, 10);
        }

        //public Palanet()
        // {
        //   Object planet1 = new object; 

    }

}

        




