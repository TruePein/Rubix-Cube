﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.IEqualityComparers;
using Rubix_Cube.Pieces;

namespace Rubix_Cube_Test.Unseen_Piece_Tests
{
	[TestClass]
	public class UnseenPieceCopyConstructorTests
	{
	    private UnseenPiece _original;
	    private UnseenPiece _copy;

		[TestInitialize]
		public void CreateAndCopyPiece()
		{
			_original = new UnseenPiece(0,0,0);
			_copy = new UnseenPiece(_original);
		}

		[TestMethod]
		public void PiecesAreNotTheSame()
		{
			Assert.AreNotEqual(_original, _copy);
        }

        [TestMethod]
        public void PiecesAreEquivelent()
        {
            var pieceComparer = new PieceEqualityComparer();
            Assert.IsTrue(pieceComparer.Equals(_original, _copy));
        }
    }
}
