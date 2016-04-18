using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;

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
			var expected = Piece.Type.Unseen;
			var actual = piece.type;
			Assert.AreEqual(expected, actual);
		}
	}
}
