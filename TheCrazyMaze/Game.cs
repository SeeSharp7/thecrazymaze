using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCrazyMaze
{
    public interface IGame
    {
        IPlayer[] Players { get; set; }
    }
}
