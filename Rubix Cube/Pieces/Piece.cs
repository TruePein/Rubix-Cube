using System;
using System.Collections.Generic;
using Rubix_Cube.Enums;

namespace Rubix_Cube.Pieces
{
    public abstract class Piece : IPiece
    {
        public Tuple<int,int,int> Coordinates { get; private set; }
        
        public PieceTypeEnum TypeEnum { get; protected set; }
        
	    public List<Side> Sides { get; }
        
        protected Piece(int x, int y, int z)
	    {
		    Sides = new List<Side>
		    {
		        new Side(ColorEnum.White, SidePositionEnum.Top),
		        new Side(ColorEnum.Red, SidePositionEnum.Front),
		        new Side(ColorEnum.Blue, SidePositionEnum.Right),
		        new Side(ColorEnum.Yellow, SidePositionEnum.Bottom),
		        new Side(ColorEnum.Orange, SidePositionEnum.Back),
		        new Side(ColorEnum.Green, SidePositionEnum.Left)
		    };
		    Coordinates = new Tuple<int, int, int>(x, y, z);
        }
        
		protected Piece(IPiece p)
		{
            Sides = new List<Side>();
		    foreach (var side in p.Sides)
		    {
		        Sides.Add(new Side(side));
		    }
            Coordinates = new Tuple<int, int, int>(p.Coordinates.Item1, p.Coordinates.Item2, p.Coordinates.Item3);
		}
        
        public abstract int CalculateDistance(TargetPiece target);
        
		public void TurnPiece(AxisEnum axisEnum, DirectionEnum directionEnum)
        {
            foreach (var side in Sides)
            {
                side.MoveToNextPosition(axisEnum, directionEnum);
            }
        }
        
        public Side GetSideByColor(ColorEnum colorEnum)
        {
			var foundSide = new Side(colorEnum, SidePositionEnum.Top);
			var found = 0;
            foreach (var side in Sides)
            {
				if (side.ColorEnum != colorEnum) continue;
                foundSide = side;
				found++;
            }
			if (found == 1)
			{
				return foundSide;
			}
            throw new InvalidOperationException(string.Format("Error: {0} pieces of color {1} were found.", found, colorEnum));
        }
        
		public Side GetSideByPosition(SidePositionEnum sidePositionEnum)
        {
            var foundSide = new Side(ColorEnum.White, sidePositionEnum);
            var found = 0;
			foreach (var side in Sides)
            {
				if (side.SidePositionEnum != sidePositionEnum) continue;
                foundSide = side;
				found++;
			}
			if (found == 1)
			{
				return foundSide;
			}
			throw new InvalidOperationException(string.Format("Error: {0} pieces of position {1} were found.", found, sidePositionEnum));
        }
        
        public void MoveToNextCoordinates(AxisEnum axisEnum, DirectionEnum directionEnum, int sizeOfCube)
        {
            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (axisEnum)
            {
                case AxisEnum.X: //x value remains the same
                    {
                        MoveToNextCoordinatesOnXAxis(directionEnum, sizeOfCube);
                        break;
                    }
                case AxisEnum.Y: //y value remains the same
                    {
                        MoveToNextCoordinatesOnYAxis(directionEnum, sizeOfCube);
                        break;
                    }
                case AxisEnum.Z: //z value remains the same
                    {
                        MoveToNextCoordinatesOnZAxis(directionEnum, sizeOfCube);
                        break;
                    }
            }
        }
        
	    private void MoveToNextCoordinatesOnXAxis(DirectionEnum directionEnum, int sizeOfCube)
	    {
	        var oldY = Coordinates.Item2;
	        var oldZ = Coordinates.Item3;
	        var newY = directionEnum == DirectionEnum.Clockwise ? sizeOfCube - (oldZ + 1) : oldZ;
	        var newZ = directionEnum == DirectionEnum.Clockwise ? oldY : sizeOfCube - (oldY + 1);
	        Coordinates = new Tuple<int, int, int>(Coordinates.Item1, newY, newZ);
	    }
        
	    private void MoveToNextCoordinatesOnYAxis(DirectionEnum directionEnum, int sizeOfCube)
	    {
	        var oldX = Coordinates.Item1;
	        var oldZ = Coordinates.Item3;
	        var newX = directionEnum == DirectionEnum.Clockwise ? oldZ : sizeOfCube - (oldZ + 1);
	        var newZ = directionEnum == DirectionEnum.Clockwise ? sizeOfCube - (oldX + 1) : oldX;
	        Coordinates = new Tuple<int, int, int>(newX, Coordinates.Item2, newZ);
	    }
        
	    private void MoveToNextCoordinatesOnZAxis(DirectionEnum directionEnum, int sizeOfCube)
	    {
	        var oldX = Coordinates.Item1;
	        var oldY = Coordinates.Item2;
            var newX = directionEnum == DirectionEnum.Clockwise ? sizeOfCube - (oldY + 1) : oldY;
	        var newY = directionEnum == DirectionEnum.Clockwise ? oldX : sizeOfCube - (oldX + 1);
	        Coordinates = new Tuple<int, int, int>(newX, newY, Coordinates.Item3);
	    }
        
	    public void Move(AxisEnum axisEnum, DirectionEnum directionEnum, int sizeOfCube)
	    {
	        MoveToNextCoordinates(axisEnum, directionEnum, sizeOfCube);
	        TurnPiece(axisEnum, directionEnum);
	    }
    }
}
