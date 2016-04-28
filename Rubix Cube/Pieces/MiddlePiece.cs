using Rubix_Cube.Enums;
namespace Rubix_Cube.Pieces
{
	public class MiddlePiece : MiddleOrUnseenOrTargetPiece
    {
        public ColorEnum ColorEnum { get; }
        
	    public MiddlePiece(int x, int y, int z, ColorEnum colorEnum) : base(x, y, z)
        {
            TypeEnum = PieceTypeEnum.Middle;
	        ColorEnum = colorEnum;
        }
        
		public MiddlePiece(MiddlePiece piece) : base(piece)
		{
		    TypeEnum = PieceTypeEnum.Middle;
		    ColorEnum = piece.ColorEnum;
		}
    }
}
