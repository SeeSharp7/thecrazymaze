using TheCrazyMaze.Enumerations;

namespace TheCrazyMaze.Interfaces
{
    public interface IMapPiece
    {
        MapPieceType MapPieceType { get; }

        Rotation Orientation { get; }
    }
}
