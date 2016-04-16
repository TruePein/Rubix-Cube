using System;
using Rubix_Cube.Pieces;

namespace Rubix_Cube
{
    public class Cube:IComparable<Cube>
    {
        private const int SIZE = 3;

        private int movesMade;

        private Piece[,,] pieces;

        private TargetPiece target;

        public Cube()
        {
            pieces = new Piece[SIZE, SIZE, SIZE];
            movesMade = 0;
            CreateRubixCube();
            target = new TargetPiece();
        }

        public Cube(Cube c) //copy constructor
        {
            movesMade = c.movesMade;
            pieces = new Piece[SIZE, SIZE, SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    for (int k = 0; k < SIZE; k++)
                    {
                        pieces[i, j, k] = c.pieces[i, j, k];//replace with copy constructor
                    }
                }
            }
            target = c.target;//replace with copy constructor
        }

        private void CreateRubixCube()
        {
            //create (SIZE)^3 pieces
            for(int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    for (int k = 0; k < SIZE; k++)
                    {
                        if((SIZE % 2 == 1) && (((i == 0 || i == SIZE - 1) && (j == SIZE / 2) && (k == SIZE / 2))
                            ||((i == SIZE / 2) && (j == 0 || j == SIZE - 1) && (k == SIZE / 2))
                            ||((i == SIZE / 2) && (j == SIZE / 2) && (k == 0 || k == SIZE - 1))))
                        {
                            pieces[i, j, k] = new MiddlePiece();
                            continue;
                        }

                        if (((i == 0 || i == SIZE - 1) && (j != 0 && j != SIZE - 1) && (k != 0 && k != SIZE - 1)) 
                            || ((i != 0 && i != SIZE - 1) && (j == 0 || j == SIZE - 1) && (k != 0 && k != SIZE - 1)) 
                            || ((i != 0 && i != SIZE - 1) && (j != 0 && j != SIZE - 1) && (k == 0 || k == SIZE - 1)))
                        {
                            Side.Color color = Side.Color.White;
                            if (i == 0) color = Side.Color.White;
                            if (i == SIZE - 1) color = Side.Color.Yellow;
                            if (j == 0) color = Side.Color.Blue;
                            if (j == SIZE - 1) color = Side.Color.Green;
                            if (k == 0) color = Side.Color.Red;
                            if (k == SIZE - 1) color = Side.Color.Orange;
                            pieces[i, j, k] = new InnerPiece(color);
                            continue;
                        }

                        if (((i == 0 || i == SIZE - 1) && (j == 0 || j == SIZE - 1) && (k != 0 && k != SIZE - 1))
                            || ((i != 0 && i != SIZE - 1) && (j == 0 || j == SIZE - 1) && (k == 0 || k == SIZE - 1))
                            || ((i == 0 || i == SIZE - 1) && (j != 0 && j != SIZE - 1) && (k == 0 || k == SIZE - 1)))
                        {
                            pieces[i, j, k] = new EdgePiece();
                            continue;
                        }

                        if ((i == 0 || i == SIZE - 1) && (k == 0 || k == SIZE - 1) && (k == 0 || k == SIZE - 1))
                        {
                            pieces[i, j, k] = new CornerPiece();
                            continue;
                        }

                        pieces[i, j, k] = new UnseenPiece();
                    }
                }
            }
        }

        private int getDistanceFromSolved()
        {
            var distance = 0;

            for(var i = 0; i < SIZE; i++)
            {
                for (var j = 0; j < SIZE; j++)
                {
                    for (var k = 0; k < SIZE; k++)
                    {
                        distance += pieces[i, j, k].calculateDistance(target);
                    }
                }
            }

            return distance / 8;
        }

        private int getScore()
        {
            return movesMade + getDistanceFromSolved();
        }

        private void makeMove(int axis, int layer, int direction)
        {
            for (int i= 0; i < SIZE/2; i++)
            {
                for (int j = 0; j < SIZE - (i + 1); j++)
                {
                    switch (axis)
                    {
                        case 0:
                            {
                                break;
                            }
                        case 1:
                            {
                                break;
                            }
                        case 2:
                            {
                                break;
                            }
                    }
                }
            }
            //get all pieces on the provided axis and layer

            //swap the corner pieces in the provided direction
            //swap the side pieces in the provided direction
            //rotate all of the pieces on the provided axis and layer in the given direction

            movesMade++;
        }

        public int CompareTo(Cube other)
        {
            if (other == null) return -1;

            var thisScore = getScore();
            var otherScore = other.getScore();

            if (thisScore < otherScore) return -1;
            if (thisScore == otherScore) return 0;
            return 1;
        }
    }
}
