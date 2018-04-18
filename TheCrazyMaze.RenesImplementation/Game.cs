using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCrazyMaze.Interfaces;

namespace TheCrazyMaze.RenesImplementation
{
    public class Game : IGame
    {
        public IPlayer[] Players { get; set; }
        public Map Map { get; set; }
        public ICollection<IMove> Moves { get; }

        public Game()
        {
            
        }

        public bool DirectWayToTreasure()
        {
            throw new NotImplementedException();
        }

        public IMove CalculateNextMove()
        {
            throw new NotImplementedException();
        }

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
