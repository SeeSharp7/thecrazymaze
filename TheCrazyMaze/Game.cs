using System;
using System.Collections.Generic;

namespace TheCrazyMaze
{
    public abstract class Game : IGame
    {
        public bool DirectWayToTreasure()
        {
            throw new NotImplementedException();
        }

        public IMove CalculateNextMove()
        {
            throw new NotImplementedException();
        }

        public IPlayer[] Players { get; set; }

        public IMap Map { get; set; }

        public ICollection<IMove> Moves { get; }

        public void MakeMove(IPlayer player, IMove move)
        {
            throw new NotImplementedException();
        }
    }
}
