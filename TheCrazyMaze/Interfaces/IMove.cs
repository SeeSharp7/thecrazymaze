using TheCrazyMaze.Enumerations;

namespace TheCrazyMaze.Interfaces
{
    /// <summary>
    /// Indicates a players move in a game
    /// </summary>
    public interface IMove
    {
        IPlayer Player { get; }
        Treasure TargetTreasure { get; }
        IMapPiece CurrentSparePiece { get; }
        
        //TODO: Position of the move (to prevent next move in the other direction)
    }
}
