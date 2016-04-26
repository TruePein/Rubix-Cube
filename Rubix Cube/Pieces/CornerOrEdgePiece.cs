namespace Rubix_Cube.Pieces
{
    public class CornerOrEdgePiece : Piece
    {
        public CornerOrEdgePiece(int x, int y, int z) : base(x, y, z) { }

        public CornerOrEdgePiece(IPiece p) : base(p) { }

        public override int CalculateDistance(TargetPiece target)
        {
            var threeTurns = true;

            var distance = 0;

            foreach (var targetSide in target.Sides)
            {
                var targetColor = targetSide.Color;
                var actualPosition = GetSideByColor(targetColor).Position;

                var subDistance = targetSide.GetDistanceFrom(actualPosition);
                if (subDistance == 0)
                {
                    threeTurns = false;
                }
                distance += subDistance;
            }

            if (distance == 0)
                return distance; //piece is oriented correctly, only hapens if it is in the right place
            if (distance == 4)
                return 1; //piece requires one turn before it is oriented correctly
            if ((distance == 8 && !threeTurns) || distance == 6)
                return 2;//piece requires two turns before it is oriented correctly
            return 3;//piece requires three turns before it is oriented correctly
        }
    }
}
