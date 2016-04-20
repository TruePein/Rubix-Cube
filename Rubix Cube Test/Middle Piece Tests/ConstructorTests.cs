using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Middle_Piece_Tests
{
    [TestClass]
    public class ConstructorTests
    {
        MiddlePiece piece;

        [TestInitialize]
        public void CreatePiece()
        {
            piece = new MiddlePiece(0, 0, 0);
        }
        [TestMethod]
        public void newPieceIsCorner()
        {
            var expected = PieceTypes.PieceType.Middle;
            var actual = piece.type;
            Assert.AreEqual(expected, actual);
        }
    }
}
