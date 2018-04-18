using TheCrazyMaze.Enumerations;

namespace TheCrazyMaze.Interfaces
{
    /// <summary>
    /// The current player
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Indicates if this player is human or a bot
        /// </summary>
        bool IsBot { get; }
        
        /// <summary>
        /// The name of the player
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The age of the player (Youngest player begins)
        /// </summary>
        int Age { get; }

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
