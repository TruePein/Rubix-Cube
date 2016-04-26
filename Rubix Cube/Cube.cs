using System;
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

        public readonly TargetPiece Target;

        public Cube(int size = 3)
        {
            Size = size;
            Pieces = new Dictionary<int, IPiece>();
            MovesMade = 0;
            CreateRubixCube();
            Target = PieceFactory.GetPiece() as TargetPiece;
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

            Target = PieceFactory.GetPiece(c.Target) as TargetPiece;
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
            var distance = Pieces.Sum(piece => piece.Value.CalculateDistance(Target));

            return distance / 8;
        }

        private int GetScore()
        {
            return MovesMade + GetDistanceFromSolved();
        }

        public void MakeMove(Axes.Axis axis, int layer, Directions.Direction direction)
        {
            if (layer >= Size || layer < 0)
                throw new IndexOutOfRangeException($"Expected range to be between 0 and {Size - 1}.");
            LastMove.Axis = axis;
            LastMove.Layer = layer;
            LastMove.Direction = direction;

            if (layer == 0)
            {
                direction = direction == Directions.Direction.Clockwise
                                ? Directions.Direction.CounterClockwise
                                : Directions.Direction.Clockwise;
                for (layer = 1; layer < Size; layer++)
                {
                    FindAndMovePieces(axis,layer, direction);
                }

                MovesMade++;
                return;
            }

            FindAndMovePieces(axis, layer, direction);

            MovesMade++;
        }

        public void UndoLastMove()
        {
            var axis = LastMove.Axis;
            var layer = LastMove.Layer;
            var direction = LastMove.Direction == Directions.Direction.Clockwise
                ? Directions.Direction.CounterClockwise
                : Directions.Direction.Clockwise;

            if (layer == 0)
            {
                direction = direction == Directions.Direction.Clockwise
                                ? Directions.Direction.CounterClockwise
                                : Directions.Direction.Clockwise;
                for (layer = 1; layer < Size; layer++)
                {
                    FindAndMovePieces(axis, layer, direction);
                }

                MovesMade++;
                return;
            }

            FindAndMovePieces(axis, layer, direction);

            MovesMade++;
        }

        private void FindAndMovePieces(Axes.Axis axis, int layer, Directions.Direction direction)
        {
            var pieces = GetAllPiecesInALayerOnAnAxis(layer, axis);
            MovePieces(pieces, axis, direction);
        }

        private void MovePieces(IEnumerable<IPiece> pieces, Axes.Axis axis, Directions.Direction direction)
        {
            foreach (var piece in pieces)
            {
                piece.Move(axis, direction, Size);
            }
        }

        private IEnumerable<IPiece> GetAllPiecesInALayerOnAnAxis(int layer, Axes.Axis axis)
        {
            var pieces = new List<IPiece>();
            if (layer >= Size) throw new IndexOutOfRangeException();

            pieces.AddRange(Pieces.Values.Where(piece => PieceIsInLayerOnAxis(piece, layer, axis)));
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

        public void Scramble(int moves = 1000)
        {
            var r = new Random();

            for (var i = 0; i < moves; i++)
            {
                var axis = (Axes.Axis) r.Next(3);
                var layer = r.Next(Size);
                var direction = (Directions.Direction) r.Next(2);
                MakeMove(axis, layer, direction);
            }

            MovesMade = 0;
        }
    }
}
