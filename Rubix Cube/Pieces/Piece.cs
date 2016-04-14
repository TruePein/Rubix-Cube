using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubix_Cube.Pieces
{
    public abstract class Piece
    {
        protected Type type;

        private const int SIDES = 6;

        protected enum Type
        {
            AbsoluteCenter,
            Unseen,
            Middle,
            Inner,
            Side,
            Corner,
            Target
        }

        protected enum Color
        {
            White, Red, Blue, Yellow, Orange, Green
        }

        private enum Side
        {
            Top, Front, Left, Bottom, Back, Right
        }

        private List<Color> colors;

        private readonly List<Color> targetColors;
        
        public Piece()
        {
            colors = new List<Color>();
            colors.Add(Color.White);
            colors.Add(Color.Red);
            colors.Add(Color.Blue);
            colors.Add(Color.Yellow);
            colors.Add(Color.Orange);
            colors.Add(Color.Green);
            targetColors = new List<Color>();
            targetColors.Add(Color.White);
            targetColors.Add(Color.Red);
            targetColors.Add(Color.Blue);
            targetColors.Add(Color.Yellow);
            targetColors.Add(Color.Orange);
            targetColors.Add(Color.Green);
        }

        public Piece(Piece p)
        {
            colors = new List<Color>();
            for (int i = 0; i < 6; i++)
            {
                colors.Add(p.colors[i]);
            }
        }

        public abstract int calculateDistance(TargetPiece piece)
        {//need to rework algorithm to use the target piece
            bool threeTurns = true;
            if (type == Type.AbsoluteCenter || type == Type.Middle) return 0;//center piece, do nothing
            int distance = 0;
            for(int i = 0; i < SIDES; i++)
            {
                Side side = (Side)i;
                Color targetColor = targetColors[(int)side];
                Side actualSide = Side.Top;
                for(int j = 0; j < SIDES; j++)
                {
                    if(targetColor != colors[j]) continue;
                    actualSide = (Side)j;
                    break;
                }
                int result = Math.Abs((int)side - (int)actualSide); //0-5
                if (result == 0)
                {
                    threeTurns = false;
                    continue;
                }
                distance += 1;
                if (result == 3) distance += 1;
            }
            if (distance == 0)
                return distance;//piece is oriented correctly, only hapens if it is in the right place
            if (distance == 4)
                return 1;//piece requires one turn before it is oriented correctly
            if (distance == 8 && !threeTurns)
                return 2;//piece requires two turns before it is oriented correctly
            return 3;//piece requires three turns before it is oriented correctly
        }

        public void turnCube(int axis, bool clockwise)
        {
            Color temp;
            switch (axis)
            {
                case 0://top, left, bottom, right
                    if (clockwise)
                    {
                        temp = colors[(int)Side.Top];
                        colors[(int)Side.Top] = colors[(int)Side.Left];
                        colors[(int)Side.Left] = colors[(int)Side.Bottom];
                        colors[(int)Side.Bottom] = colors[(int)Side.Right];
                        colors[(int)Side.Right] = temp;
                        break;
                    }
                    temp = colors[(int)Side.Top];
                    colors[(int)Side.Top] = colors[(int)Side.Right];
                    colors[(int)Side.Right] = colors[(int)Side.Bottom];
                    colors[(int)Side.Bottom] = colors[(int)Side.Left];
                    colors[(int)Side.Left] = temp;
                    break;
                case 1://top, front, bottom, back
                    if (clockwise)
                    {
                        temp = colors[(int)Side.Top];
                        colors[(int)Side.Top] = colors[(int)Side.Front];
                        colors[(int)Side.Front] = colors[(int)Side.Bottom];
                        colors[(int)Side.Bottom] = colors[(int)Side.Back];
                        colors[(int)Side.Back] = temp;
                        break;
                    }
                    temp = colors[(int)Side.Top];
                    colors[(int)Side.Top] = colors[(int)Side.Back];
                    colors[(int)Side.Back] = colors[(int)Side.Bottom];
                    colors[(int)Side.Bottom] = colors[(int)Side.Front];
                    colors[(int)Side.Front] = temp;
                    break;
                case 2://front, left, back, right
                    if (clockwise)
                    {
                        temp = colors[(int)Side.Front];
                        colors[(int)Side.Front] = colors[(int)Side.Right];
                        colors[(int)Side.Right] = colors[(int)Side.Back];
                        colors[(int)Side.Back] = colors[(int)Side.Left];
                        colors[(int)Side.Left] = temp;
                        break;
                    }
                    temp = colors[(int)Side.Top];
                    colors[(int)Side.Front] = colors[(int)Side.Left];
                    colors[(int)Side.Left] = colors[(int)Side.Back];
                    colors[(int)Side.Back] = colors[(int)Side.Right];
                    colors[(int)Side.Right] = temp;
                    break;
                default:
                    break;
            }
        }
    }
}
