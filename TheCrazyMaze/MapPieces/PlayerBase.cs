using TheCrazyMaze.Enumerations;
using TheCrazyMaze.Interfaces;

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

        public Rotation Orientation
        {
            get { return Rotation.NoRotation; }
        }
    }
}
