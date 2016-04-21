using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Middle_Piece_Tests
{
    [TestClass]
    public class MiddlePieceConstructorTests
    {
        private MiddlePiece _piece;

        [TestInitialize]
        public void CreatePiece()
        {
            _piece = new MiddlePiece(0, 0, 0);
        }

        [TestMethod]
        public void NewPieceIsMiddle()
        {
            var expected = PieceTypes.PieceType.Middle;
            var actual = _piece.Type;
            Assert.AreEqual(expected, actual);
        }
    }
}
