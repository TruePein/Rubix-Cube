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
            pieces = new Piece[SIZE, SIZE, SIZE];//created left to right, top to bottom, front to back; [0,1,2] on a 3x3 is the left, far, middle piece
			movesMade = 0;
            CreateRubixCube();
			target = PieceFactory.GetPiece() as TargetPiece;
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
						pieces[i, j, k] = PieceFactory.GetPiece(c.pieces[i, j, k]);
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
						pieces[i, j, k] = PieceFactory.GetPiece(i, j, k, SIZE);
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

        private void makeMove(int axis, int layer, bool clockwise)
        {
			if (SIZE % 2 != 0 && layer == SIZE / 2) target.turnPiece(axis, clockwise);
			Piece temp;
            for (int i = 0; i < SIZE/2; i++)
            {
                for (int j = 0; j < SIZE - (i + 1); j++)
                {
                    switch (axis)
                    {
                        case 0://x remains constant to the layer 
							{
								temp = pieces[layer, i, j];
								if (clockwise)
								{
									pieces[layer, i, j] = pieces[layer, SIZE - (j + 1), i];
									pieces[layer, SIZE - (j + 1), i] = pieces[layer, SIZE - (i + 1), SIZE - (j + 1)];
									pieces[layer, SIZE - (i + 1), SIZE - (j + 1)] = pieces[layer, j, SIZE - (i + 1)];
									pieces[layer, j, SIZE - (i + 1)] = temp;
									break;
								}
								pieces[layer, i, j] = pieces[layer, j, SIZE - (i + 1)];
								pieces[layer, j, SIZE - (i + 1)] = pieces[layer, SIZE - (i + 1), SIZE - (j + 1)];
								pieces[layer, SIZE - (i + 1), SIZE - (j + 1)] = pieces[layer, SIZE - (j + 1), i];
								pieces[layer, SIZE - (j + 1), i] = temp;
								break;
                            }
                        case 1://y remains constant to the layer
                            {
								temp = pieces[i, layer, j];
								if (clockwise)
								{
									pieces[i, layer, j] = pieces[SIZE - (j + 1), layer, i];
									pieces[SIZE - (j + 1), layer, i] = pieces[SIZE - (i + 1), layer, SIZE - (j + 1)];
									pieces[SIZE - (i + 1), layer, SIZE - (j + 1)] = pieces[j, layer, SIZE - (i + 1)];
									pieces[j, layer, SIZE - (i + 1)] = temp;
									break;
								}
								pieces[i, layer, j] = pieces[j, layer, SIZE - (i + 1)];
								pieces[j, layer, SIZE - (i + 1)] = pieces[SIZE - (i + 1), layer, SIZE - (j + 1)];
								pieces[SIZE - (i + 1), layer, SIZE - (j + 1)] = pieces[SIZE - (j + 1), layer, i];
								pieces[SIZE - (j + 1), layer, i] = temp;
								break;
                            }
                        case 2://z remains constant to the layer
                            {
								temp = pieces[i, j, layer];
								if (clockwise)
								{
									pieces[i, j, layer] = pieces[SIZE - (j + 1), i, layer];
									pieces[SIZE - (j + 1), i, layer] = pieces[SIZE - (i + 1), SIZE - (j + 1), layer];
									pieces[SIZE - (i + 1), SIZE - (j + 1), layer] = pieces[j, SIZE - (i + 1), layer];
									pieces[j, SIZE - (i + 1), layer] = temp;
									break;
								}
								pieces[i, j, layer] = pieces[j, SIZE - (i + 1), layer];
								pieces[j, SIZE - (i + 1), layer] = pieces[SIZE - (i + 1), SIZE - (j + 1), layer];
								pieces[SIZE - (i + 1), SIZE - (j + 1), layer] = pieces[SIZE - (j + 1), i, layer];
								pieces[SIZE - (j + 1), i, layer] = temp;
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
