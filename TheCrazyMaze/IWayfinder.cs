using TheCrazyMaze.Enumerations;

namespace TheCrazyMaze
{
    public interface IWayfinder
    {
        bool DirectWayToTreasure();

        IMove CalculateNextMove();
    }
}
