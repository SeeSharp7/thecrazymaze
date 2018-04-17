using TheCrazyMaze.Enumerations;

namespace TheCrazyMaze
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMove
    {
        IPlayer Player { get; }
        Treasure TargetTreasure { get; }
        IMapPiece CurrentSparePiece { get; }
        
        //TODO: Position of the move (to prevent next move in the other direction)
    }
}
