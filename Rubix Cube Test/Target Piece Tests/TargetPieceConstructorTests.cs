using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Target_Piece_Tests
{
    [TestClass]
    public class TargetPieceConstructorTests
    {
        private TargetPiece _piece;

        [TestInitialize]
        public void CreatePiece()
        {
            _piece = new TargetPiece();
        }

        [TestMethod]
        public void NewPiece()
        {
            var expected = PieceTypes.PieceType.Target;
            var actual = _piece.Type;
            Assert.AreEqual(expected, actual);
        }
    }
}
