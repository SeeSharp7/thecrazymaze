using System;
using System.Collections.Generic;
using TheCrazyMaze.Interfaces;

namespace TheCrazyMaze
{
    public abstract class Game : IGame
    {
        //Schieben nur in geraden reihen (%2)!!!
        public bool DirectWayToTreasure()
        {
            throw new NotImplementedException();
        }

        public IMove CalculateNextMove()
        {
            throw new NotImplementedException();
        }

        public IPlayer[] Players { get; set; }
        public Map Map { get; set; }
        public ICollection<IMove> Moves { get; }
        public void MakeMove(IPlayer player, IMove move)
        {
            throw new NotImplementedException();
        }

        public void StartGame()
        {
            throw new NotImplementedException();
        }
    }
}
