using Rubix_Cube.Enums;

namespace Rubix_Cube.Pieces
{
	public class InnerPiece : Piece
    {
        public ColorEnum ColorEnum { get; }
        
	    public InnerPiece(int x, int y, int z, ColorEnum colorEnum) : base(x, y, z)
        {
            TypeEnum = PieceTypeEnum.Inner;
            ColorEnum = colorEnum;
        }
        
		public InnerPiece(InnerPiece piece) : base(piece)
		{
		    TypeEnum = PieceTypeEnum.Inner;
			ColorEnum = piece.ColorEnum;
		}
        
		public override int CalculateDistance(TargetPiece target)
        {
            var targetSide = target.GetSideByColor(ColorEnum);
            var actualPosition = GetSideByColor(ColorEnum).SidePositionEnum;
            return targetSide.GetDistanceFrom(actualPosition);
        }
    }
}
