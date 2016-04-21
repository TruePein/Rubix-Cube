using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Inner_Piece_Tests
{
    [TestClass]
    public class InnerPieceCopyConstructorTests
    {
        private InnerPiece _original;
        private InnerPiece _copy;

        [TestInitialize]
        public void CreateAndCopyPiece()
        {
            _original = new InnerPiece(1, 1, 0, Colors.Color.White);
            _copy = new InnerPiece(_original);
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
        public void PiecesHaveSameColor()
        {
            Assert.AreEqual(_original.Color, _copy.Color);
        }

        [TestMethod]
        public void ChangingCoordinatesOfCopyDoesNotChangeTheOriginal()
        {
            _copy.MoveToNextCoordinates(Axes.Axis.X, Directions.Direction.Clockwise, 3);
            Assert.AreNotEqual(_original.Coordinates, _copy.Coordinates);
        }
    }
}
