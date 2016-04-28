using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Corner_Piece_Tests
{
    [TestClass]
    public class CornerPieceConstructorTests
    {
        private CornerPiece _piece;

        [TestInitialize]
        public void CreatePiece()
        {
            _piece = new CornerPiece(0, 0, 0);
        }
        [TestMethod]
        public void NewPieceIsCorner()
        {
            var expected = PieceTypeEnum.Corner;
            var actual = _piece.TypeEnum;
            Assert.AreEqual(expected, actual);
        }
    }
}
