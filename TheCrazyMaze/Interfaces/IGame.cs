using System.Collections.Generic;

namespace TheCrazyMaze.Interfaces
{
    public interface IGame : IWayfinder
    {
        IPlayer[] Players { get; set; }
        Map Map { get; set; }
        ICollection<IMove> Moves { get; }

        void MakeMove(IPlayer player, IMove move);

        void StartGame();
    }
}