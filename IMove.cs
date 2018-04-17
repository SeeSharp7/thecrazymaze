using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCrazyMaze
{
    public interface IMove
    {
        IPlayer Player { get; }
        Treasure TargetTreasure { get; }
        
        //TODO: Position of the move (to prevent next move in the other direction)
    }
}
