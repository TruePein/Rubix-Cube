using System;
using System.Collections.Generic;
using Rubix_Cube.Enums;

namespace Rubix_Cube.Pieces
{
    public interface IPiece
    {
        Tuple<int, int, int> Coordinates { get; }
        
        PieceTypeEnum TypeEnum { get; }
        
        List<Side> Sides { get; }
        
        int CalculateDistance(TargetPiece target);
        
        void Move(AxisEnum axisEnum, DirectionEnum directionEnum, int sizeOfCube);
        
        void MoveToNextCoordinates(AxisEnum axisEnum, DirectionEnum directionEnum, int sizeOfCube);
        
        void TurnPiece(AxisEnum axisEnum, DirectionEnum directionEnum);
        
        Side GetSideByColor(ColorEnum colorEnum);
        
        Side GetSideByPosition(SidePositionEnum sidePositionEnum);
    }
}