using TheCrazyMaze.Enumerations;

namespace TheCrazyMaze
{
    public interface IPlayer
    {
        /// <summary>
        /// The <see cref="PlayerColor"/> of this <see cref="IPlayer"/>
        /// </summary>
        PlayerColor Color { get; set; }
        /// <summary>
        /// Current <see cref="Position"/> of this player on <see cref="IMap"/>
        /// </summary>
        Position Position { get; set; }
    }
}
