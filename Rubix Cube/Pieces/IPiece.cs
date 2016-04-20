using System;
using Rubix_Cube.Enums;

namespace Rubix_Cube.Pieces
{
    public interface IPiece
    {
        Tuple<int, int, int> Coordinates { get; set; }

        PieceTypes.PieceType type { get; }

        int calculateDistance(TargetPiece target);

        void Move(Axes.Axis axis, Directions.Direction direction, int sizeOfCube);

        void MoveToNextCoordinates(Axes.Axis axis, Directions.Direction direction, int sizeOfCube);

        void turnPiece(Axes.Axis axis, Directions.Direction direction);

        Side getSideByColor(Colors.Color color);

        Side getSideByPosition(SidePositions.Position position);
    }
}