using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Corner_Piece_Tests
{
    [TestClass]
    public class CornerPieceCopyConstructorTests
    {
        private CornerPiece _original;
        private CornerPiece _copy;

        [TestInitialize]
        public void CreateAndCopyPiece()
        {
            _original = new CornerPiece(0, 0, 0);
            _copy = new CornerPiece(_original);
        }

        [TestMethod]
        public void PiecesAreDifferent()
        {
            Assert.AreNotEqual(_original, _copy);
        }

        [TestMethod]
        public void PiecesHaveSameCoordinates()
        {
            Assert.AreEqual(_original.Coordinates, _copy.Coordinates);
        }

        [TestMethod]
        public void PiecesHaveSameTypes()
        {
            Assert.AreEqual(_original.Type, _copy.Type);
        }

        [TestMethod]
        public void ChangingCoordinatesOfCopyDoesNotChangeTheOriginal()
        {
            _copy.MoveToNextCoordinates(Axes.Axis.X, Directions.Direction.Clockwise, 3);
            Assert.AreNotEqual(_original.Coordinates, _copy.Coordinates);
        }
    }
}
