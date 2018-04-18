namespace TheCrazyMaze.Interfaces
{
    public interface IWayfinder
    {
        bool DirectWayToTreasure();

        IMove CalculateNextMove();
    }
}
