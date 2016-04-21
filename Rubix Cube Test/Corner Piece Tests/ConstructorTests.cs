using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Corner_Piece_Tests
{
    [TestClass]
    public class ConstructorTests
    {
        CornerPiece piece;

        [TestInitialize]
        public void CreatePiece()
        {
            piece = new CornerPiece(0, 0, 0);
        }
        [TestMethod]
        public void newPieceIsCorner()
        {
            var expected = PieceTypes.PieceType.Corner;
            var actual = piece.Type;
            Assert.AreEqual(expected, actual);
        }
    }
}
