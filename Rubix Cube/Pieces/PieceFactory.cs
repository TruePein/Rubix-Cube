﻿using Rubix_Cube.Enums;
namespace Rubix_Cube.Pieces
{
    public static class PieceFactory
    {
		public static Piece GetPiece()
		{
			return new TargetPiece();
		}

        public static Piece GetPiece(int x, int y, int z, int size)
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

			if (edgeOfAxis == 3) return new CornerPiece();
			if (edgeOfAxis == 2) return new EdgePiece();
			if (edgeOfAxis == 0) return new UnseenPiece();
			if (centerOfAxis == 2) return new MiddlePiece();

			//only piece left is inner piece, which needs a color
			if (x == 0) return new InnerPiece(Colors.Color.White);
			if (x == size - 1) return new InnerPiece(Colors.Color.Yellow);
			if (y == 0) return new InnerPiece(Colors.Color.Blue);
			if (y == size - 1) return new InnerPiece(Colors.Color.Green);
			if (z == 0) return new InnerPiece(Colors.Color.Red);
			return new InnerPiece(Colors.Color.Orange);
		}

		public static Piece GetPiece(Piece piece)
		{
			if (piece.type == PieceTypes.PieceType.Corner) return new CornerPiece(piece as CornerPiece);
			if (piece.type == PieceTypes.PieceType.Edge) return new EdgePiece(piece as EdgePiece);
			if (piece.type == PieceTypes.PieceType.Middle) return new MiddlePiece(piece as MiddlePiece);
			if (piece.type == PieceTypes.PieceType.Inner) return new InnerPiece(piece as InnerPiece);
			if (piece.type == PieceTypes.PieceType.Target) return new TargetPiece(piece as TargetPiece);
			return new UnseenPiece(piece as UnseenPiece);
		}
    }
}
