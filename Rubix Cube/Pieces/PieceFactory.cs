using Rubix_Cube.Enums;
namespace Rubix_Cube.Pieces
{
    public static class PieceFactory
    {
		public static IPiece GetPiece()
		{
			return new TargetPiece();
		}

        public static IPiece GetPiece(int x, int y, int z, int size)
        {
			var edgeOfAxis = 0;
			var centerOfAxis = 0;

			if (x == 0 || x == size - 1) edgeOfAxis++;
			if (y == 0 || y == size - 1) edgeOfAxis++;
			if (z == 0 || z == size - 1) edgeOfAxis++;

			if (size % 2 != 0)
			{
				if (x == size / 2) centerOfAxis++;
				if (y == size / 2) centerOfAxis++;
				if (z == size / 2) centerOfAxis++;
			}

			if (edgeOfAxis == 3) return new CornerPiece(x, y, z);
			if (edgeOfAxis == 2) return new EdgePiece(x, y, z);
			if (edgeOfAxis == 0) return new UnseenPiece(x, y, z);

            var color = ColorEnum.White;
            if (x == 0) color = ColorEnum.Green;
            if (x == size -1) color = ColorEnum.Blue;
            if (y == 0) color = ColorEnum.Orange;
            if (y == size - 1) color = ColorEnum.Red;
            if (z == 0) color = ColorEnum.Yellow;
            if (centerOfAxis == 2) return new MiddlePiece(x, y, z, color);
			return new InnerPiece(x, y, z, color);
		}

		public static IPiece GetPiece(IPiece piece)
		{
			if (piece.TypeEnum == PieceTypeEnum.Corner) return new CornerPiece(piece as CornerPiece);
			if (piece.TypeEnum == PieceTypeEnum.Edge) return new EdgePiece(piece as EdgePiece);
			if (piece.TypeEnum == PieceTypeEnum.Middle) return new MiddlePiece(piece as MiddlePiece);
			if (piece.TypeEnum == PieceTypeEnum.Inner) return new InnerPiece(piece as InnerPiece);
			if (piece.TypeEnum == PieceTypeEnum.Target) return new TargetPiece(piece as TargetPiece);
			return new UnseenPiece(piece as UnseenPiece);
		}
    }
}
