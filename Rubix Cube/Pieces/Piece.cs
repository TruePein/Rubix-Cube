using System.Collections.Generic;

namespace Rubix_Cube.Pieces
{
    public abstract class Piece
    {
        protected Type type;

        protected const int SIDES = 6;

        public enum Type
        {
            Unseen,
            Middle,
            Inner,
            Side,
            Corner,
            Target
        }

        public readonly List<Side> colors;
        
        public Piece()
        {
            colors = new List<Side>();
            for(int i = 0; i < SIDES; i++)
            {
                colors.Add(new Side(i));
            }
        }

        public Piece(Piece p)
        {
            colors = new List<Side>();
            for (int i = 0; i < 6; i++)
            {
                colors.Add(new Side(p.colors[i]));
            }
        }

        public abstract int calculateDistance(TargetPiece piece);
        
        public void turnPiece(int axis, bool clockwise)
        {
            switch (axis)
            {
                case 2://top, left, bottom, right;0, 5, 3, 2
                    changePositions(new Side.Position[]
                    {
                        Side.Position.Top,
                        clockwise?Side.Position.Right:Side.Position.Left,
                        Side.Position.Bottom,
                        clockwise?Side.Position.Left:Side.Position.Right
                    });
                    break;
                case 0://top, front, bottom, back;0, 1, 3, 4
                    changePositions(new Side.Position[]
                    {
                        Side.Position.Top,
                        clockwise?Side.Position.Back:Side.Position.Front,
                        Side.Position.Bottom,
                        clockwise?Side.Position.Front:Side.Position.Back
                    });
                    break;
                case 1://front, left, back, right;1, 5, 4, 2
                    changePositions(new Side.Position[]
                    {
                        Side.Position.Front,
                        clockwise?Side.Position.Right:Side.Position.Left,
                        Side.Position.Back,
                        clockwise?Side.Position.Left:Side.Position.Right
                    });
                    break;
                default: //do nothing
                    break;
            }
        }

        private void changePositions(Side.Position[] positions)
        {
            Side sideTo = getSideByPosition(positions[0]);
            Side.Position temp = sideTo.SidePosition;
            for(int i = 0; i < 3; i++)
            {
                Side sideFrom = getSideByPosition(positions[i + 1]);
                sideTo.SidePosition = sideFrom.SidePosition;
                sideTo = sideFrom;
            }
            sideTo.SidePosition = temp;
        }

        public Side getSideByColor(Side.Color color)
        {
            foreach (Side side in colors)
            {
                if (side.SideColor == color) return side;
            }
            throw new System.Exception();
        }

        public Side getSideByPosition(Side.Position position)
        {
            foreach (Side side in colors)
            {
                if (side.SidePosition == position) return side;
            }
            throw new System.Exception();
        }
    }
}
