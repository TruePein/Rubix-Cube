﻿using System;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Rubix_Cube
{
    public class Cube : IComparable<Cube>
    {
        public readonly int Size;

        public int MovesMade { get; private set; }

        public Dictionary<int,IPiece> Pieces { get; }

        public int Score => GetScore();

        private readonly TargetPiece _target;

        public Cube(int size)
        {
            Size = size;
            Pieces = new Dictionary<int, IPiece>();
            MovesMade = 0;
            CreateRubixCube();
            _target = PieceFactory.GetPiece() as TargetPiece;
        }

        public Cube(Cube c) //copy constructor
        {
            Size = c.Size;
            MovesMade = c.MovesMade;
            Pieces = new Dictionary<int, IPiece>();
            var count = 0;
            foreach (var piece in c.Pieces)
            {
                Pieces.Add(count++,PieceFactory.GetPiece(piece.Value));
            }

            _target = PieceFactory.GetPiece(c._target) as TargetPiece;
        }

        private void CreateRubixCube()
        {
            var numberOfPieces = GetNumberOfPieces();
            //create (SIZE)^3 pieces
            for (var i = 0; i < numberOfPieces; i++)
            {
                var x = GetXPosition(i);
                var y = GetYPosition(i);
                var z = GetZPosition(i);
                Pieces.Add(i, PieceFactory.GetPiece(x, y, z, Size));
            }
        }

        private int GetXPosition(int i)
        {
            var pieceLimit = GetNumberOfPieces();
            CheckRange(i, 0, pieceLimit);
            return (int)(i / Math.Pow(Size, 2));
        }

        private int GetYPosition(int i)
        {
            var pieceLimit = GetNumberOfPieces();
            CheckRange(i, 0, pieceLimit);
            return i % (int)Math.Pow(Size, 2) / Size;
        }

        private int GetZPosition(int i)
        {
            var pieceLimit = GetNumberOfPieces();
            CheckRange(i, 0, pieceLimit);
            return i % Size;
        }

        private static void CheckRange(int i, int min, int max)
        {
            if (i < min || i > max) throw new IndexOutOfRangeException(
                string.Format("Error: {0} is outside the range of {1} to {2}", i, min, max));
        }

        private int GetNumberOfPieces()
        {
            return (int)Math.Pow(Size, 3);
        }

        private int GetDistanceFromSolved()
        {
            var distance = Pieces.Sum(piece => piece.Value.CalculateDistance(_target));

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
			if (Size % 2 != 0 && layer == Size / 2) _target.TurnPiece(axis, direction);

            var pieces = GetAllPiecesInALayerOnAnAxis(layer, axis);
            foreach(var piece in pieces)
            {
                piece.Move(axis, direction, Size);
            }

            MovesMade++;
        }

        public void UndoLastMove()
        {
            var axis = LastMove.Axis;
            var layer = LastMove.Layer;
            var direction = LastMove.Direction == Directions.Direction.Clockwise?LastMove.Direction:Directions.Direction.CounterClockwise;
            if (Size % 2 == 1 && layer == Size / 2) _target.TurnPiece(axis, direction);

            var pieces = GetAllPiecesInALayerOnAnAxis(layer, axis);
            foreach (var piece in pieces)
            {
                piece.Move(axis, direction, Size);
            }

            MovesMade--;
        }

        private IEnumerable<IPiece> GetAllPiecesInALayerOnAnAxis(int layer, Axes.Axis axis)
        {
            var pieces = new List<IPiece>();
            if (layer >= Size) return pieces;
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

            var thisScore = Score;
            var otherScore = other.Score;

            if (thisScore < otherScore) return -1;
            return thisScore == otherScore ? 0 : 1;
        }

        private IPiece GetPieceByCoordinates(Tuple<int, int, int> coordinates)
        {
            IPiece retPiece = new TargetPiece();
            foreach (var piece in Pieces)
            {
                if (piece.Value.Coordinates.Item1 != coordinates.Item1) continue;
                if (piece.Value.Coordinates.Item2 != coordinates.Item2) continue;
                if (piece.Value.Coordinates.Item3 != coordinates.Item3) continue;
                retPiece = piece.Value;
            }
            return retPiece;
        }

        private void Reorient()
        {
            var anchor = PieceFactory.GetPiece(GetPieceByCoordinates(new Tuple<int, int, int>(0, 0, 0)));

            var oldDistance = anchor.CalculateDistance(_target);

            for (var i = 0; i < oldDistance; i++)
            {
                if (IsTurnedPieceCloser(anchor, Axes.Axis.X, Directions.Direction.Clockwise))
                {
                    TurnWholeCube(Axes.Axis.X, Directions.Direction.Clockwise);
                    continue;
                }

                if (IsTurnedPieceCloser(anchor, Axes.Axis.X, Directions.Direction.CounterClockwise))
                {
                    TurnWholeCube(Axes.Axis.X, Directions.Direction.CounterClockwise);
                    continue;
                }

                if (IsTurnedPieceCloser(anchor, Axes.Axis.Y, Directions.Direction.Clockwise))
                {
                    TurnWholeCube(Axes.Axis.Y, Directions.Direction.CounterClockwise);
                    continue;
                }

                if (IsTurnedPieceCloser(anchor, Axes.Axis.Y, Directions.Direction.CounterClockwise))
                {
                    TurnWholeCube(Axes.Axis.Y, Directions.Direction.CounterClockwise);
                    continue;
                }

                if (IsTurnedPieceCloser(anchor, Axes.Axis.Z, Directions.Direction.Clockwise))
                {
                    TurnWholeCube(Axes.Axis.Z, Directions.Direction.CounterClockwise);
                    continue;
                }

                if (IsTurnedPieceCloser(anchor, Axes.Axis.Z, Directions.Direction.CounterClockwise))
                {
                    TurnWholeCube(Axes.Axis.Z, Directions.Direction.CounterClockwise);
                }
            }
        }

        private bool IsTurnedPieceCloser(IPiece anchor, Axes.Axis axis, Directions.Direction direction)
        {
            var oldDistance = anchor.CalculateDistance(_target);

            anchor.Move(axis, direction, Size);

            var newDistance = anchor.CalculateDistance(_target);

            if (newDistance <= oldDistance)
            {
                return true;
            }
            var newDirection = direction == Directions.Direction.Clockwise
                ? Directions.Direction.CounterClockwise
                : direction;
            anchor.Move(axis, newDirection, Size);
            return false;
        }

        private void TurnWholeCube(Axes.Axis axis, Directions.Direction direction)
        {
            foreach (var piece in Pieces)
            {
                piece.Value.Move(axis, direction, Size);
            }
            _target.Move(axis, direction, Size);
        }
    }
}
