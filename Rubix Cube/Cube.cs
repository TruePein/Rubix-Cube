using System;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Rubix_Cube
{
    public class Cube : IComparable<Cube>
    {
        public List<Step> Path { get; }
        
        public readonly int Size;
        
        public int MovesMade { get; private set; }
        
        public Dictionary<int,IPiece> Pieces { get; }
        
        public int Score => GetScore();
        
        public readonly TargetPiece Target;

#region constructors
        public Cube(int size = 3)
        {
            Size = size;
            MovesMade = 0;
            Pieces = new Dictionary<int, IPiece>();
            CreateRubixCube();
            Path = new List<Step>();
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
            Path = new List<Step>();
            foreach (var step in c.Path)
            {
                Path.Add(step);
            }
            Target = PieceFactory.GetPiece(c.Target) as TargetPiece;
        }
#endregion

#region creating rubix cube
        private void CreateRubixCube()
        {
            var numberOfPieces = GetNumberOfPieces();
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
        #endregion

#region scoring
        private int GetScore()
        {
            return MovesMade + GetDistanceFromSolved();
        }
        
        public int GetDistanceFromSolved()
        {
            if (Size == 1) return 0;
            var distance = Pieces.Sum(piece => piece.Value.CalculateDistance(Target));
            return distance;
            return distance / (int)(Math.Pow(Size, 2) - Math.Pow(Size - 2, 2));
        }
        #endregion

#region movemont
        public void MakeMove(AxisEnum axisEnum, int layer, DirectionEnum directionEnum)
        {
            if (layer >= Size || layer < 0)
                throw new IndexOutOfRangeException($"Expected range to be between 0 and {Size - 1}.");
            if (Size % 2 == 1 && (layer == 0 || layer == Size / 2))
            {
                Target.TurnPiece(axisEnum, directionEnum);
            }
            AddToPath(axisEnum, layer, directionEnum);
            if (layer == 0)
            {
                directionEnum = directionEnum == DirectionEnum.Clockwise
                                ? DirectionEnum.CounterClockwise
                                : DirectionEnum.Clockwise;
                for (layer = 1; layer < Size; layer++)
                {
                    FindAndMovePieces(axisEnum,layer, directionEnum);
                }

                MovesMade++;
                return;
            }

            FindAndMovePieces(axisEnum, layer, directionEnum);

            MovesMade++;
        }

        private void AddToPath(AxisEnum axisEnum, int layer, DirectionEnum directionEnum)
        {
            var step = new Step(axisEnum, layer, directionEnum);
            Path.Add(step);
        }
        
        private void FindAndMovePieces(AxisEnum axisEnum, int layer, DirectionEnum directionEnum)
        {
            var pieces = GetAllPiecesInALayerOnAnAxis(layer, axisEnum);
            MovePieces(pieces, axisEnum, directionEnum);
        }
        
        private void MovePieces(IEnumerable<IPiece> pieces, AxisEnum axisEnum, DirectionEnum directionEnum)
        {
            foreach (var piece in pieces)
            {
                piece.Move(axisEnum, directionEnum, Size);
            }
        }
        
        private IEnumerable<IPiece> GetAllPiecesInALayerOnAnAxis(int layer, AxisEnum axisEnum)
        {
            var pieces = new List<IPiece>();
            if (layer >= Size) throw new IndexOutOfRangeException();

            pieces.AddRange(Pieces.Values.Where(piece => PieceIsInLayerOnAxis(piece, layer, axisEnum)));
            return pieces;
        }
        
        private static bool PieceIsInLayerOnAxis(IPiece piece, int layer, AxisEnum axisEnum)
        {
            switch (axisEnum)
            {
                case AxisEnum.X:
                    {
                        return piece.Coordinates.Item1 == layer;
                    }
                case AxisEnum.Y:
                    {
                        return piece.Coordinates.Item2 == layer;
                    }
                case AxisEnum.Z:
                    {
                        return piece.Coordinates.Item3 == layer;
                    }
            }
            throw new InvalidOperationException("Axis provided wasn't one of the ones available. Somehow.");
        }
#endregion

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
                var axis = (AxisEnum) r.Next(3);
                var layer = r.Next(Size);
                var direction = (DirectionEnum) r.Next(2);
                MakeMove(axis, layer, direction);
            }

            MovesMade = 0;
            Path.Clear();
        }

        public IPiece GetPieceByCoordinates(int x, int y, int z)
        {
            foreach (var piece in Pieces)
            {
                if (piece.Value.Coordinates.Item1 != x) continue;
                if (piece.Value.Coordinates.Item2 != y) continue;
                if (piece.Value.Coordinates.Item3 != z) continue;

                return piece.Value;
            }
            throw new IndexOutOfRangeException("Coordinates provided don't exist. Somehow.");
        }
    }
}
