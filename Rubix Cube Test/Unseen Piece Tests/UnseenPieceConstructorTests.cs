using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Unseen_Piece_Tests
{
	[TestClass]
	public class UnseenPieceConstructorTests
	{
		private UnseenPiece _piece;

		[TestInitialize]
		public void CreatePiece()
		{
			_piece = new UnseenPiece(0,0,0);
		}

		[TestMethod]
		public void NewPiece()
		{
			var expected = PieceTypes.PieceType.Unseen;
			var actual = _piece.Type;
			Assert.AreEqual(expected, actual);
		}
	}
}
