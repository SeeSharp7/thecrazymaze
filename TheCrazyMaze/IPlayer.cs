using TheCrazyMaze.Enumerations;

namespace TheCrazyMaze
{
    /// <summary>
    /// The current player
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// The <see cref="PlayerColor"/> of this <see cref="IPlayer"/>
        /// </summary>
        PlayerColor Color { get; }

        /// <summary>
        /// Current <see cref="Position"/> of this player on <see cref="IMap"/>
        /// </summary>
        Position Position { get; set; }

        /// <summary>
        /// The <see cref="Treasure"/> which this <see cref="IPlayer"/> is currently hunting
        /// </summary>
        Treasure CurrentTreasure { get; set; }
    }
}
