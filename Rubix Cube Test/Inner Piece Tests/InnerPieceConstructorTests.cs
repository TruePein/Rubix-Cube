using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Inner_Piece_Tests
{
    [TestClass]
    public class InnerPieceConstructorTests
    {
        private InnerPiece _piece;

        [TestInitialize]
        public void CreatePiece()
        {
            _piece = new InnerPiece(0, 0, 0, Colors.Color.White);
        }

        [TestMethod]
        public void NewPieceIsInner()
        {
            var expected = PieceTypes.PieceType.Inner;
            var actual = _piece.Type;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewWhitePieceIsWhite()
        {
            var expected = Colors.Color.White;
            var actual = _piece.Color;
            Assert.AreEqual(expected, actual);
        }
    }
}
