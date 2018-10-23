using System;

namespace WarGameII
{
    public class Game
    {
        private Player[] players;
        private CardStock cardstock;
        public Game()
        {
            players = new Player[] 
            { 
                new Player{Name = "Me" },
                new Player{ Name = "You"}
            };
            cardstock = new CardStock();

        }
        public void play()
        {
            throw new NotImplementedException();
        }
    }
}