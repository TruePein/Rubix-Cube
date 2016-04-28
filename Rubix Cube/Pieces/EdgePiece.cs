using Rubix_Cube.Enums;

namespace Rubix_Cube.Pieces
{
	public class EdgePiece : CornerOrEdgePiece
    {
		public EdgePiece(int x, int y, int z) : base(x, y, z)
        {
            TypeEnum = PieceTypeEnum.Edge;
        }
        
		public EdgePiece(IPiece piece) : base(piece)
		{
			TypeEnum = PieceTypeEnum.Edge;
		}
    }
}
