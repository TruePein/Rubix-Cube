using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube;
using Rubix_Cube.Enums;
using Rubix_Cube.IEqualityComparers;
using Rubix_Cube.Pieces;

namespace Rubix_Cube_Test.Cube_Tests
{
    [TestClass]
    public class CubeMakeMoveTests
    {
        private Cube _cube;

        [TestInitialize]
        public void CreateCube()
        {
            _cube = new Cube();
        }

        [TestMethod]
        public void MakingAMoveIncreasesTheNumberOfMovesMadeByOne()
        {
            var movesMade = _cube.MovesMade;
            var expected = movesMade + 1;
            _cube.MakeMove(Axes.Axis.X, 0, Directions.Direction.Clockwise);
            var actual = _cube.MovesMade;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakingAMoveAndBackMincreaseTheNumberOfMovesByTwoButThePositionsAreTheSame()
        {
            var copy = new Cube(_cube);
            _cube.MakeMove(Axes.Axis.X, 0, Directions.Direction.Clockwise);
            _cube.MakeMove(Axes.Axis.X, 0, Directions.Direction.CounterClockwise);
            var expected = copy.MovesMade + 2;
            var actual = _cube.MovesMade;
            Assert.AreEqual(expected, actual);
            var comparer = new CubePiecesEqualityComparer();
            Assert.IsTrue(comparer.Equals(copy, _cube));
        }

        [TestMethod]
        public void MovingTheMiddleLayerTurnsTheTargetPiece()
        {
            var target = _cube.Target;
            var targetCopy = new TargetPiece(target);
            _cube.MakeMove(Axes.Axis.X, 1, Directions.Direction.Clockwise);
            var comparer = new PieceEqualityComparer();
            Assert.IsFalse(comparer.Equals(target, targetCopy), "Pieces contain the same information.");
        }

        [TestMethod]
        public void MovingTheMiddleLayerAndBackDoesNotTurnTheTargetPiece()
        {
            var target = _cube.Target;
            var targetCopy = new TargetPiece(target);
            _cube.MakeMove(Axes.Axis.X, 1, Directions.Direction.Clockwise);
            _cube.MakeMove(Axes.Axis.X, 1, Directions.Direction.CounterClockwise);
            var comparer = new PieceEqualityComparer();
            Assert.IsTrue(comparer.Equals(target, targetCopy), "Pieces contain different information.");
        }

        [TestMethod]
        public void MovingANonexistingLayerDoesNothing()
        {
            var copy = new Cube(_cube);
            _cube.MakeMove(Axes.Axis.X, 3, Directions.Direction.Clockwise);
            var comparer = new CubeFullEqualityComparer();
            Assert.IsTrue(comparer.Equals(_cube, copy));
        }
    }
}
