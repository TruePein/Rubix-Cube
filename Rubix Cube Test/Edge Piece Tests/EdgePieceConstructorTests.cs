using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Edge_Piece_Tests
{
    [TestClass]
    public class EdgePieceConstructorTests
    {
        private EdgePiece _piece;

        [TestInitialize]
        public void CreatePiece()
        {
            _piece = new EdgePiece(1, 0, 0);
        }
        [TestMethod]
        public void NewPieceIsEdge()
        {
            var expected = PieceTypes.PieceType.Edge;
            var actual = _piece.Type;
            Assert.AreEqual(expected, actual);
        }
    }
}
