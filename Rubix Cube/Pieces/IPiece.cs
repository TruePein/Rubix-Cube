using System;
using System.Collections.Generic;
using Rubix_Cube.Enums;

namespace Rubix_Cube.Pieces
{
    public interface IPiece
    {
        Tuple<int, int, int> Coordinates { get; set; }

        PieceTypes.PieceType Type { get; }

        List<Side> Sides { get; }

        int CalculateDistance(TargetPiece target);

        void Move(Axes.Axis axis, Directions.Direction direction, int sizeOfCube);

        void MoveToNextCoordinates(Axes.Axis axis, Directions.Direction direction, int sizeOfCube);

        void TurnPiece(Axes.Axis axis, Directions.Direction direction);

        Side GetSideByColor(Colors.Color color);

        Side GetSideByPosition(SidePositions.Position position);
    }
}