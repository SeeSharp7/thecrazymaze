using System.Collections.Generic;

namespace TheCrazyMaze
{
    public interface IGame : IWayfinder
    {
        IPlayer[] Players { get; set; }
        IMap Map { get; set; }
        ICollection<IMove> Moves { get; }

        void MakeMove(IPlayer player, IMove move);
    }
}
