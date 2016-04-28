using Rubix_Cube.Enums;

namespace Rubix_Cube.Pieces
{
	public class CornerPiece : CornerOrEdgePiece
	{
		public CornerPiece(int x, int y, int z) : base(x, y, z)
		{
			TypeEnum = PieceTypeEnum.Corner;
		}
        
		public CornerPiece(IPiece piece) : base(piece)
		{
			TypeEnum = PieceTypeEnum.Corner;
		}
    }
}
