using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Unseen_Piece_Tests
{
	[TestClass]
	public class ConstructorTests
	{
		private UnseenPiece piece;

		[TestInitialize]
		public void CreatePiece()
		{
			piece = new UnseenPiece();
		}

		[TestMethod]
		public void NewPiece()
		{
			var expected = PieceTypes.PieceType.Unseen;
			var actual = piece.type;
			Assert.AreEqual(expected, actual);
		}
	}
}
