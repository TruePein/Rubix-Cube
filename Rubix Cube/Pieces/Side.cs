using Rubix_Cube.Enums;
namespace Rubix_Cube.Pieces
{
    public class Side
    {
        public SidePositionEnum SidePositionEnum { get; private set; }
        
		public ColorEnum ColorEnum { get; }
        
	    public Side(ColorEnum colorEnum, SidePositionEnum sidePositionEnum)
        {
            SidePositionEnum = sidePositionEnum;
            ColorEnum = colorEnum;
        }
        
		public Side(Side side)
        {
            SidePositionEnum = side.SidePositionEnum;
            ColorEnum = side.ColorEnum;
        }

        public void MoveToNextPosition(AxisEnum axisEnum, DirectionEnum directionEnum)
        {
            switch (axisEnum)
            {
                case AxisEnum.X:
                    {
                        SidePositionEnum = GetNextPositionX(directionEnum);
                        break;
                    }
                case AxisEnum.Y:
                    {
                        SidePositionEnum = GetNextPositionY(directionEnum);
                        break;
                    }
                case AxisEnum.Z:
                    {
                        SidePositionEnum = GetNextPositionZ(directionEnum);
                        break;
                    }
            }
        }

        public int GetDistanceFrom(SidePositionEnum actualSidePositionEnum)
        {
            switch (actualSidePositionEnum)
            {
                case SidePositionEnum.Top:
                    {
                        if (SidePositionEnum == SidePositionEnum.Top) return 0;
                        if (SidePositionEnum == SidePositionEnum.Bottom) return 2;
                        return 1;
                    }
                case SidePositionEnum.Front:
                    {
                        if (SidePositionEnum == SidePositionEnum.Front) return 0;
                        if (SidePositionEnum == SidePositionEnum.Back) return 2;
                        return 1;
                    }
                case SidePositionEnum.Right:
                    {
                        if (SidePositionEnum == SidePositionEnum.Right) return 0;
                        if (SidePositionEnum == SidePositionEnum.Left) return 2;
                        return 1;
                    }
                case SidePositionEnum.Bottom:
                    {
                        if (SidePositionEnum == SidePositionEnum.Bottom) return 0;
                        if (SidePositionEnum == SidePositionEnum.Top) return 2;
                        return 1;
                    }
                case SidePositionEnum.Back:
                    {
                        if (SidePositionEnum == SidePositionEnum.Back) return 0;
                        if (SidePositionEnum == SidePositionEnum.Front) return 2;
                        return 1;
                    }
                case SidePositionEnum.Left:
                    {
                        if (SidePositionEnum == SidePositionEnum.Left) return 0;
                        if (SidePositionEnum == SidePositionEnum.Right) return 2;
                        return 1;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }

        private SidePositionEnum GetNextPositionX(DirectionEnum directionEnum)
        {
            if (SidePositionEnum == SidePositionEnum.Top)
            {
                return directionEnum == DirectionEnum.Clockwise ? SidePositionEnum.Back : SidePositionEnum.Front;
            }
            if (SidePositionEnum == SidePositionEnum.Back)
            {
                return directionEnum == DirectionEnum.Clockwise ? SidePositionEnum.Bottom : SidePositionEnum.Top;
            }
            if (SidePositionEnum == SidePositionEnum.Bottom)
            {
                return directionEnum == DirectionEnum.Clockwise ? SidePositionEnum.Front : SidePositionEnum.Back;
            }
            if (SidePositionEnum == SidePositionEnum.Front)
            {
                return directionEnum == DirectionEnum.Clockwise ? SidePositionEnum.Top : SidePositionEnum.Bottom;
            }
            return SidePositionEnum;
        }

        private SidePositionEnum GetNextPositionY(DirectionEnum directionEnum)
        {
            if (SidePositionEnum == SidePositionEnum.Top)
            {
                return directionEnum == DirectionEnum.Clockwise ? SidePositionEnum.Right : SidePositionEnum.Left;
            }
            if (SidePositionEnum == SidePositionEnum.Right)
            {
                return directionEnum == DirectionEnum.Clockwise ? SidePositionEnum.Bottom : SidePositionEnum.Top;
            }
            if (SidePositionEnum == SidePositionEnum.Bottom)
            {
                return directionEnum == DirectionEnum.Clockwise ? SidePositionEnum.Left : SidePositionEnum.Right;
            }
            if (SidePositionEnum == SidePositionEnum.Left)
            {
                return directionEnum == DirectionEnum.Clockwise ? SidePositionEnum.Top : SidePositionEnum.Bottom;
            }
            return SidePositionEnum;
        }

        private SidePositionEnum GetNextPositionZ(DirectionEnum directionEnum)
        {
            if (SidePositionEnum == SidePositionEnum.Front)
            {
                return directionEnum == DirectionEnum.Clockwise ? SidePositionEnum.Left : SidePositionEnum.Right;
            }
            if (SidePositionEnum == SidePositionEnum.Left)
            {
                return directionEnum == DirectionEnum.Clockwise ? SidePositionEnum.Back : SidePositionEnum.Front;
            }
            if (SidePositionEnum == SidePositionEnum.Back)
            {
                return directionEnum == DirectionEnum.Clockwise ? SidePositionEnum.Right : SidePositionEnum.Left;
            }
            if (SidePositionEnum == SidePositionEnum.Right)
            {
                return directionEnum == DirectionEnum.Clockwise ? SidePositionEnum.Front : SidePositionEnum.Back;
            }
            return SidePositionEnum;
        }
    }
}
