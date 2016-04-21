using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Middle_Piece_Tests
{
    [TestClass]
    public class CopyConstructorTests
    {
        MiddlePiece original;
        MiddlePiece copy;

        [TestInitialize]
        public void CreateAndCopyPiece()
        {
            original = new MiddlePiece(1, 1, 0);
            copy = new MiddlePiece(original);
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
        public void ChangingCoordinatesOfCopyDoesNotChangeTheOriginal()
        {
            copy.MoveToNextCoordinates(Axes.Axis.X, Directions.Direction.Clockwise, 3);
            Assert.AreNotEqual(original.Coordinates, copy.Coordinates);
        }
    }
}
