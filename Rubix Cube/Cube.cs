using System;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;
using System.Collections.Generic;
using System.Linq;
//TODO: Document fields, properties and methods
namespace Rubix_Cube
{
    /// <summary>
    /// 
    /// </summary>
    public class Cube : IComparable<Cube>
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Step> Path { get; }

        /// <summary>
        /// 
        /// </summary>
        public readonly int Size;

        /// <summary>
        /// 
        /// </summary>
        public int MovesMade { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int,IPiece> Pieces { get; }

        /// <summary>
        /// 
        /// </summary>
        public int Score => GetScore();

        /// <summary>
        /// 
        /// </summary>
        public readonly TargetPiece Target;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="size"></param>
        public Cube(int size = 3)
        {
            Size = size;
            MovesMade = 0;
            Pieces = new Dictionary<int, IPiece>();
            CreateRubixCube();
            Path = new List<Step>();
            Target = PieceFactory.GetPiece() as TargetPiece;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
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
            Path = new List<Step>();
            foreach (var step in c.Path)
            {
                Path.Add(step);
            }
            Target = PieceFactory.GetPiece(c.Target) as TargetPiece;
        }

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private int GetXPosition(int i)
        {
            var pieceLimit = GetNumberOfPieces();
            CheckRange(i, 0, pieceLimit);
            return (int)(i / Math.Pow(Size, 2));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private int GetYPosition(int i)
        {
            var pieceLimit = GetNumberOfPieces();
            CheckRange(i, 0, pieceLimit);
            return i % (int)Math.Pow(Size, 2) / Size;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private int GetZPosition(int i)
        {
            var pieceLimit = GetNumberOfPieces();
            CheckRange(i, 0, pieceLimit);
            return i % Size;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        private static void CheckRange(int i, int min, int max)
        {
            if (i < min || i > max) throw new IndexOutOfRangeException(
                string.Format("Error: {0} is outside the range of {1} to {2}", i, min, max));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int GetNumberOfPieces()
        {
            return (int)Math.Pow(Size, 3);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int GetDistanceFromSolved()
        {
            var distance = Pieces.Sum(piece => piece.Value.CalculateDistance(Target));

            return distance / 8;
        }

        private int GetScore()
        {
            return MovesMade + GetDistanceFromSolved();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="layer"></param>
        /// <param name="direction"></param>
        public void MakeMove(Axes.Axis axis, int layer, Directions.Direction direction)
        {
            if (layer >= Size || layer < 0)
                throw new IndexOutOfRangeException($"Expected range to be between 0 and {Size - 1}.");
            LastMove.Axis = axis;
            LastMove.Layer = layer;
            LastMove.Direction = direction;
            AddToPath(axis, layer, direction);
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

        private void AddToPath(Axes.Axis axis, int layer, Directions.Direction direction)
        {
            var step = new Step(axis, layer, direction);
            Path.Add(step);
        }

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="layer"></param>
        /// <param name="direction"></param>
        private void FindAndMovePieces(Axes.Axis axis, int layer, Directions.Direction direction)
        {
            var pieces = GetAllPiecesInALayerOnAnAxis(layer, axis);
            MovePieces(pieces, axis, direction);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pieces"></param>
        /// <param name="axis"></param>
        /// <param name="direction"></param>
        private void MovePieces(IEnumerable<IPiece> pieces, Axes.Axis axis, Directions.Direction direction)
        {
            foreach (var piece in pieces)
            {
                piece.Move(axis, direction, Size);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="layer"></param>
        /// <param name="axis"></param>
        /// <returns></returns>
        private IEnumerable<IPiece> GetAllPiecesInALayerOnAnAxis(int layer, Axes.Axis axis)
        {
            var pieces = new List<IPiece>();
            if (layer >= Size) throw new IndexOutOfRangeException();

            pieces.AddRange(Pieces.Values.Where(piece => PieceIsInLayerOnAxis(piece, layer, axis)));
            return pieces;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="piece"></param>
        /// <param name="layer"></param>
        /// <param name="axis"></param>
        /// <returns></returns>
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
            }
            throw new InvalidOperationException("Axis provided wasn't one of the ones available. Somehow.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Cube other)
        {
            if (other == null) return -1;

            var thisScore = Score;
            var otherScore = other.Score;

            if (thisScore < otherScore) return -1;
            return thisScore == otherScore ? 0 : 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moves"></param>
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
