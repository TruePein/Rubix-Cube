using Rubix_Cube.Enums;
namespace Rubix_Cube.Pieces
{
	public class TargetPiece : MiddleOrUnseenOrTargetPiece
    {
		public TargetPiece() : base(0, 0, 0){
            TypeEnum = PieceTypeEnum.Target;
        }
        
		public TargetPiece(IPiece piece) : base(piece)
		{
			TypeEnum = PieceTypeEnum.Target;
		}
    }
}
