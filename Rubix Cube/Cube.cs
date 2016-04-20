using System;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;
using System.Collections.Generic;

namespace Rubix_Cube
{
    public class Cube : IComparable<Cube>
    {
        private const int SIZE = 3;

        public int movesMade { get; set; }

        private List<IPiece> _pieces;

        private TargetPiece target;

        public Cube()
        {
            _pieces = new List<IPiece>();
            movesMade = 0;
            CreateRubixCube();
            target = PieceFactory.GetPiece() as TargetPiece;
        }

        public Cube(Cube c) //copy constructor
        {
            movesMade = c.movesMade;
            _pieces = new List<IPiece>();
            foreach (IPiece piece in c._pieces)
            {
                _pieces.Add(PieceFactory.GetPiece(piece));
            }

            target = PieceFactory.GetPiece(c.target) as TargetPiece;
        }

        private void CreateRubixCube()
        {
            var numberOfPieces = getNumberOfPieces();
            //create (SIZE)^3 pieces
            for (int i = 0; i < numberOfPieces; i++)
            {
                var x = getXPosition(i);
                var y = getYPosition(i);
                var z = getZPosition(i);
                _pieces.Add(PieceFactory.GetPiece(x, y, z, SIZE));
            }
        }

        private int getXPosition(int i)
        {
            var pieceLimit = getNumberOfPieces();
            checkRange(i, 0, pieceLimit);
            return (int)(i / (Math.Pow(SIZE, 2)));
        }

        private int getYPosition(int i)
        {
            var pieceLimit = getNumberOfPieces();
            checkRange(i, 0, pieceLimit);
            return (i % (int)(Math.Pow(SIZE, 2))) / SIZE;
        }

        private int getZPosition(int i)
        {
            var pieceLimit = getNumberOfPieces();
            checkRange(i, 0, pieceLimit);
            return i % SIZE;
        }

        private void checkRange(int i, int min, int max)
        {
            if (i < min || i > max) throw new IndexOutOfRangeException(
                string.Format("Error: {0} is outside the range of {1} to {2}", i, min, max));
        }

        private int getNumberOfPieces()
        {
            return (int)Math.Pow(SIZE, 3);
        }

        private int getDistanceFromSolved()
        {
            var distance = 0;

            foreach (var piece in _pieces)
            {
                distance += piece.calculateDistance(target);
            }

            return distance / 8;
        }

        private int getScore()
        {
            return movesMade + getDistanceFromSolved();
        }

        private void makeMove(Axes.Axis axis, int layer, Directions.Direction direction)
        {
            LastMove.Axis = axis;
            LastMove.Layer = layer;
            LastMove.Direction = direction;
			if (SIZE % 2 != 0 && layer == SIZE / 2) target.turnPiece(axis, direction);

            List<IPiece> pieces = getAllPiecesInALayerOnAnAxis(layer, axis);
            foreach(IPiece piece in pieces)
            {
                piece.Move(axis, direction, SIZE);
            }

            movesMade++;
        }

        private void undoLastMove()
        {
            var axis = LastMove.Axis;
            var layer = LastMove.Layer;
            var direction = LastMove.Direction == Directions.Direction.Clockwise?LastMove.Direction:Directions.Direction.CounterClockwise;
            if (SIZE % 2 != 0 && layer == SIZE / 2) target.turnPiece(axis, direction);

            List<IPiece> pieces = getAllPiecesInALayerOnAnAxis(layer, axis);
            foreach (IPiece piece in pieces)
            {
                piece.Move(axis, direction, SIZE);
            }

            movesMade--;
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

        private List<IPiece> getAllPiecesInALayerOnAnAxis(int layer, Axes.Axis axis)
        {
            List<IPiece> pieces = new List<IPiece>();
            if (layer >= SIZE) return pieces;
            foreach(IPiece piece in pieces)
            {
                if (!pieceIsInLayerOnAxis(piece, layer, axis)) continue;
                pieces.Add(piece);
            }
            return pieces;
        }

        private bool pieceIsInLayerOnAxis(IPiece piece, int layer, Axes.Axis axis)
        {
            switch (axis)
            {
                case Axes.Axis.X:
                    {
                        return piece.Coordinates.Item1 == layer;
                    }
                case Axes.Axis.Y:
                    {
                        return piece.Coordinates.Item2 == layer;
                    }
                case Axes.Axis.Z:
                    {
                        return piece.Coordinates.Item3 == layer;
                    }
            }
            return false;
        }
    }
}
