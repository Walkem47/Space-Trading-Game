using System; 



namespace SpaceTradeGame
{
    public class Planet
    {
        public string name { get; set; }
        public Island[] Islands { get; set; }

        public (double, double) location { get; set; }
    }
}