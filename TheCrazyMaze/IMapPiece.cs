using TheCrazyMaze.Enumerations;

namespace TheCrazyMaze
{
    public interface IMapPiece
    {
        MapPieceType MapPieceType { get; }

        Orientation Orientation { get; }
    }
}
