using System;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube
{
    public class Cube:IComparable<Cube>
    {
        private const int SIZE = 3;

        private int movesMade;

        private Piece[,,] _pieces;

        private TargetPiece target;

        public Cube()
        {
            _pieces = new Piece[SIZE, SIZE, SIZE];//created left to right, top to bottom, front to back; [0,1,2] on a 3x3 is the left, far, middle piece
			movesMade = 0;
            CreateRubixCube();
			target = PieceFactory.GetPiece() as TargetPiece;
        }

        public Cube(Cube c) //copy constructor
        {
            movesMade = c.movesMade;
            _pieces = new Piece[SIZE, SIZE, SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    for (int k = 0; k < SIZE; k++)
                    {
						_pieces[i, j, k] = PieceFactory.GetPiece(c._pieces[i, j, k]);
                    }
                }
            }
            target = PieceFactory.GetPiece(c.target) as TargetPiece;
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
						_pieces[i, j, k] = PieceFactory.GetPiece(i, j, k, SIZE);
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
                        distance += _pieces[i, j, k].calculateDistance(target);
                    }
                }
            }

            return distance / 8;
        }

        private int getScore()
        {
            return movesMade + getDistanceFromSolved();
        }

        private void makeMove(Axes.Axis axis, int layer, Directions.Direction clockwise)
        {
			if (SIZE % 2 != 0 && layer == SIZE / 2) target.turnPiece(axis, clockwise);
			Piece temp;
            for (int i = 0; i < SIZE/2; i++)
            {
                for (int j = 0; j < SIZE - (i + 1); j++)
                {
                    switch (axis)
                    {
                        case Axes.Axis.X://x remains constant to the layer 
							{
								temp = _pieces[layer, i, j];
								if (clockwise == Directions.Direction.Clockwise)
								{
									_pieces[layer, i, j] = _pieces[layer, SIZE - (j + 1), i];
									_pieces[layer, SIZE - (j + 1), i] = _pieces[layer, SIZE - (i + 1), SIZE - (j + 1)];
									_pieces[layer, SIZE - (i + 1), SIZE - (j + 1)] = _pieces[layer, j, SIZE - (i + 1)];
									_pieces[layer, j, SIZE - (i + 1)] = temp;
									break;
								}
								_pieces[layer, i, j] = _pieces[layer, j, SIZE - (i + 1)];
								_pieces[layer, j, SIZE - (i + 1)] = _pieces[layer, SIZE - (i + 1), SIZE - (j + 1)];
								_pieces[layer, SIZE - (i + 1), SIZE - (j + 1)] = _pieces[layer, SIZE - (j + 1), i];
								_pieces[layer, SIZE - (j + 1), i] = temp;
								break;
                            }
                        case Axes.Axis.Y://y remains constant to the layer
                            {
								temp = _pieces[i, layer, j];
								if (clockwise == Directions.Direction.Clockwise)
								{
									_pieces[i, layer, j] = _pieces[SIZE - (j + 1), layer, i];
									_pieces[SIZE - (j + 1), layer, i] = _pieces[SIZE - (i + 1), layer, SIZE - (j + 1)];
									_pieces[SIZE - (i + 1), layer, SIZE - (j + 1)] = _pieces[j, layer, SIZE - (i + 1)];
									_pieces[j, layer, SIZE - (i + 1)] = temp;
									break;
								}
								_pieces[i, layer, j] = _pieces[j, layer, SIZE - (i + 1)];
								_pieces[j, layer, SIZE - (i + 1)] = _pieces[SIZE - (i + 1), layer, SIZE - (j + 1)];
								_pieces[SIZE - (i + 1), layer, SIZE - (j + 1)] = _pieces[SIZE - (j + 1), layer, i];
								_pieces[SIZE - (j + 1), layer, i] = temp;
								break;
                            }
                        case Axes.Axis.Z://z remains constant to the layer
                            {
								temp = _pieces[i, j, layer];
								if (clockwise == Directions.Direction.Clockwise)
								{
									_pieces[i, j, layer] = _pieces[SIZE - (j + 1), i, layer];
									_pieces[SIZE - (j + 1), i, layer] = _pieces[SIZE - (i + 1), SIZE - (j + 1), layer];
									_pieces[SIZE - (i + 1), SIZE - (j + 1), layer] = _pieces[j, SIZE - (i + 1), layer];
									_pieces[j, SIZE - (i + 1), layer] = temp;
									break;
								}
								_pieces[i, j, layer] = _pieces[j, SIZE - (i + 1), layer];
								_pieces[j, SIZE - (i + 1), layer] = _pieces[SIZE - (i + 1), SIZE - (j + 1), layer];
								_pieces[SIZE - (i + 1), SIZE - (j + 1), layer] = _pieces[SIZE - (j + 1), i, layer];
								_pieces[SIZE - (j + 1), i, layer] = temp;
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
