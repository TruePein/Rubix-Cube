using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;
using Rubix_Cube.IEqualityComparers;

namespace Rubix_Cube_Test.Middle_Piece_Tests
{
    [TestClass]
    public class MiddlePieceCopyConstructorTests
    {
        private MiddlePiece _original;
        private MiddlePiece _copy;

        [TestInitialize]
        public void CreateAndCopyPiece()
        {
            _original = PieceFactory.GetPiece(0, 1, 1, 3) as MiddlePiece;
            _copy = new MiddlePiece(_original);
        }

        [TestMethod]
        public void PiecesAreDifferent()
        {
            Assert.AreNotEqual(_original, _copy);
        }

        [TestMethod]
        public void PiecesAreEquivelent()
        {
            var pieceComparer = new PieceEqualityComparer();
            Assert.IsTrue(pieceComparer.Equals(_original, _copy));
        }

        [TestMethod]
        public void MovingThePieceSoItsPositionRemainsTheSameDoesntChangeIt()
        {
            _copy.Move(AxisEnum.X, DirectionEnum.Clockwise, 3);
            var pieceComparer = new PieceEqualityComparer();
            Assert.IsTrue(pieceComparer.Equals(_original, _copy));
        }
    }
}
