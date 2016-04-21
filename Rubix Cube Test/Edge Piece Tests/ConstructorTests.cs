using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Edge_Piece_Tests
{
    [TestClass]
    public class ConstructorTests
    {
        EdgePiece piece;

        [TestInitialize]
        public void CreatePiece()
        {
            piece = new EdgePiece(1, 0, 0);
        }
        [TestMethod]
        public void newPieceIsEdge()
        {
            var expected = PieceTypes.PieceType.Edge;
            var actual = piece.Type;
            Assert.AreEqual(expected, actual);
        }
    }
}
