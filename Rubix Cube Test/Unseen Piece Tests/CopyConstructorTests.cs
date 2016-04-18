using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;

namespace Rubix_Cube_Test.Unseen_Piece_Tests
{
	[TestClass]
	public class CopyConstructorTests
	{
		UnseenPiece original;
		UnseenPiece copy;

		[TestInitialize]
		public void CreateAndCopyPiece()
		{
			original = new UnseenPiece();
			copy = new UnseenPiece(original);
		}

		[TestMethod]
		public void PiecesAreNotTheSame()
		{
			Assert.AreNotEqual(original, copy);
		}
	}
}
