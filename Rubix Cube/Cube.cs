using System;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Rubix_Cube
{
    public class Cube : IComparable<Cube>
    {
        private readonly int _size;

        public int MovesMade { get; set; }

        private readonly List<IPiece> _pieces;

        private readonly TargetPiece _target;

        public Cube(int size)
        {
            _size = size;
            _pieces = new List<IPiece>();
            MovesMade = 0;
            CreateRubixCube();
            _target = PieceFactory.GetPiece() as TargetPiece;
        }

        public Cube(Cube c) //copy constructor
        {
            _size = c._size;
            MovesMade = c.MovesMade;
            _pieces = new List<IPiece>();
            foreach (IPiece piece in c._pieces)
            {
                _pieces.Add(PieceFactory.GetPiece(piece));
            }

            _target = PieceFactory.GetPiece(c._target) as TargetPiece;
        }

        private void CreateRubixCube()
        {
            var numberOfPieces = GetNumberOfPieces();
            //create (SIZE)^3 pieces
            for (int i = 0; i < numberOfPieces; i++)
            {
                var x = GetXPosition(i);
                var y = GetYPosition(i);
                var z = GetZPosition(i);
                _pieces.Add(PieceFactory.GetPiece(x, y, z, _size));
            }
        }

        private int GetXPosition(int i)
        {
            var pieceLimit = GetNumberOfPieces();
            CheckRange(i, 0, pieceLimit);
            return (int)(i / (Math.Pow(_size, 2)));
        }

        private int GetYPosition(int i)
        {
            var pieceLimit = GetNumberOfPieces();
            CheckRange(i, 0, pieceLimit);
            return (i % (int)(Math.Pow(_size, 2))) / _size;
        }

        private int GetZPosition(int i)
        {
            var pieceLimit = GetNumberOfPieces();
            CheckRange(i, 0, pieceLimit);
            return i % _size;
        }

        private static void CheckRange(int i, int min, int max)
        {
            if (i < min || i > max) throw new IndexOutOfRangeException(
                string.Format("Error: {0} is outside the range of {1} to {2}", i, min, max));
        }

        private int GetNumberOfPieces()
        {
            return (int)Math.Pow(_size, 3);
        }

        private int GetDistanceFromSolved()
        {
            var distance = _pieces.Sum(piece => piece.CalculateDistance(_target));

            return distance / 8;
        }

        private int GetScore()
        {
            return MovesMade + GetDistanceFromSolved();
        }

        public void MakeMove(Axes.Axis axis, int layer, Directions.Direction direction)
        {
            LastMove.Axis = axis;
            LastMove.Layer = layer;
            LastMove.Direction = direction;
			if (_size % 2 != 0 && layer == _size / 2) _target.TurnPiece(axis, direction);

            var pieces = GetAllPiecesInALayerOnAnAxis(layer, axis);
            foreach(var piece in pieces)
            {
                piece.Move(axis, direction, _size);
            }

            MovesMade++;
        }

        public void UndoLastMove()
        {
            var axis = LastMove.Axis;
            var layer = LastMove.Layer;
            var direction = LastMove.Direction == Directions.Direction.Clockwise?LastMove.Direction:Directions.Direction.CounterClockwise;
            if (_size % 2 == 1 && layer == _size / 2) _target.TurnPiece(axis, direction);

            var pieces = GetAllPiecesInALayerOnAnAxis(layer, axis);
            foreach (var piece in pieces)
            {
                piece.Move(axis, direction, _size);
            }

            MovesMade--;
        }

        private IEnumerable<IPiece> GetAllPiecesInALayerOnAnAxis(int layer, Axes.Axis axis)
        {
            var pieces = new List<IPiece>();
            if (layer >= _size) return pieces;
            foreach(var piece in pieces)
            {
                if (PieceIsInLayerOnAxis(piece, layer, axis))
                pieces.Add(piece);
            }
            return pieces;
        }

        private static bool PieceIsInLayerOnAxis(IPiece piece, int layer, Axes.Axis axis)
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
                default:
                    throw new ArgumentOutOfRangeException(nameof(axis), axis, null);
            }
        }

        public int CompareTo(Cube other)
        {
            if (other == null) return -1;

            var thisScore = GetScore();
            var otherScore = other.GetScore();

            if (thisScore < otherScore) return -1;
            return thisScore == otherScore ? 0 : 1;
        }
    }
}
