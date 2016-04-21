using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Inner_Piece_Tests
{
    [TestClass]
    public class ConstructorTests
    {
        InnerPiece piece;

        [TestInitialize]
        public void CreatePiece()
        {
            piece = new InnerPiece(0, 0, 0, Colors.Color.White);
        }

        [TestMethod]
        public void NewPieceIsInner()
        {
            var expected = PieceTypes.PieceType.Inner;
            var actual = piece.Type;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewWhitePieceIsWhite()
        {
            var expected = Colors.Color.White;
            var actual = piece.Color;
            Assert.AreEqual(expected, actual);
        }
    }
}
