using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Inner_Piece_Tests
{
    [TestClass]
    public class CopyConstructorTests
    {
        InnerPiece original;
        InnerPiece copy;

        [TestInitialize]
        public void CreateAndCopyPiece()
        {
            original = new InnerPiece(1, 1, 0, Colors.Color.White);
            copy = new InnerPiece(original);
        }

        [TestMethod]
        public void PiecesAreDifferent()
        {
            Assert.AreNotEqual(original, copy);
        }

        [TestMethod]
        public void PiecesHaveSameCoordinates()
        {
            Assert.AreEqual(original.Coordinates, copy.Coordinates);
        }

        [TestMethod]
        public void PiecesHaveSameTypes()
        {
            Assert.AreEqual(original.Type, copy.Type);
        }

        [TestMethod]
        public void PiecesHaveSameColor()
        {
            Assert.AreEqual(original.Color, copy.Color);
        }

        [TestMethod]
        public void ChangingCoordinatesOfCopyDoesNotChangeTheOriginal()
        {
            copy.MoveToNextCoordinates(Axes.Axis.X, Directions.Direction.Clockwise, 3);
            Assert.AreNotEqual(original.Coordinates, copy.Coordinates);
        }
    }
}
