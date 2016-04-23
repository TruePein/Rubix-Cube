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
            _original = new MiddlePiece(1, 1, 0);
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
        public void MovingCopyMakesThePiecesDifferent()
        {
            _copy.MoveToNextCoordinates(Axes.Axis.X, Directions.Direction.Clockwise, 3);
            var pieceComparer = new PieceEqualityComparer();
            Assert.IsTrue(!pieceComparer.Equals(_original, _copy));
        }


        [TestMethod]
        public void MovingOriginalMakesThePiecesDifferent()
        {
            _original.MoveToNextCoordinates(Axes.Axis.X, Directions.Direction.Clockwise, 3);
            var pieceComparer = new PieceEqualityComparer();
            Assert.IsTrue(!pieceComparer.Equals(_original, _copy));
        }
    }
}
