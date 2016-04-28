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
            _piece = PieceFactory.GetPiece(0, 1, 1, 3) as MiddlePiece;
        }

        [TestMethod]
        public void NewPieceIsMiddle()
        {
            var expected = PieceTypeEnum.Middle;
            var actual = _piece.TypeEnum;
            Assert.AreEqual(expected, actual);
        }
    }
}
