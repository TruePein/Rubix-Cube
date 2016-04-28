using Rubix_Cube.Enums;
namespace Rubix_Cube.Pieces
{
	public class UnseenPiece : MiddleOrUnseenOrTargetPiece
    {
		public UnseenPiece(int x, int y, int z) : base(x, y, z)
        {
            TypeEnum = PieceTypeEnum.Unseen;
        }
        
		public UnseenPiece(IPiece piece) : base(piece)
        {
            TypeEnum = PieceTypeEnum.Unseen;
        }
    }
}
