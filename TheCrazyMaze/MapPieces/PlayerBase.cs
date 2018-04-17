using TheCrazyMaze.Enumerations;

namespace TheCrazyMaze.MapPieces
{
    public class PlayerBase : IMapPiece
    {
        /// <summary>
        /// Returns current <see cref="MapPieceType"/>
        /// </summary>
        public MapPieceType MapPieceType
        {
            get { return MapPieceType.Curve; }
        }

        public Orientation Orientation
        {
            get { return Orientation.NotTurned; }
        }
    }
}
