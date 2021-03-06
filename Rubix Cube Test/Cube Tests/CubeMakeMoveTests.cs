﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube;
using Rubix_Cube.Enums;
using Rubix_Cube.IEqualityComparers;

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
            _cube.MakeMove(AxisEnum.X, 0, DirectionEnum.Clockwise);
            var actual = _cube.MovesMade;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakingAMoveAndBackIncreaseTheNumberOfMovesByTwoButThePositionsAreTheSame()
        {
            var copy = new Cube(_cube);
            _cube.MakeMove(AxisEnum.X, 0, DirectionEnum.Clockwise);
            _cube.MakeMove(AxisEnum.X, 0, DirectionEnum.CounterClockwise);
            var expected = copy.MovesMade + 2;
            var actual = _cube.MovesMade;
            Assert.AreEqual(expected, actual);
            var comparer = new CubePiecesEqualityComparer();
            Assert.IsTrue(comparer.Equals(copy, _cube));
        }

        [TestMethod]
        public void Turning2LayerXAxisClockwiseShouldMovePieceFromm222To202()
        {
            var piece = _cube.Pieces[_cube.Pieces.Count-1];
            _cube.MakeMove(AxisEnum.X, 2, DirectionEnum.Clockwise);
            var expected = new Tuple<int, int, int>(2, 0, 2);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Turning2LayerXAxisCounterClockwiseShouldMovePieceFromm222To220()
        {
            var piece = _cube.Pieces[_cube.Pieces.Count - 1];
            _cube.MakeMove(AxisEnum.X, 2, DirectionEnum.CounterClockwise);
            var expected = new Tuple<int, int, int>(2, 2, 0);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Turning2LayerYAxisClockwiseShouldMovePieceFromm222To220()
        {
            var piece = _cube.Pieces[_cube.Pieces.Count - 1];
            _cube.MakeMove(AxisEnum.Y, 2, DirectionEnum.Clockwise);
            var expected = new Tuple<int, int, int>(2, 2, 0);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Turning2LayerYAxisCounterClockwiseShouldMovePieceFromm222To022()
        {
            var piece = _cube.Pieces[_cube.Pieces.Count - 1];
            _cube.MakeMove(AxisEnum.Y, 2, DirectionEnum.CounterClockwise);
            var expected = new Tuple<int, int, int>(0, 2, 2);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Turning2LayerZAxisClockwiseShouldMovePieceFromm222To022()
        {
            var piece = _cube.Pieces[_cube.Pieces.Count - 1];
            _cube.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            var expected = new Tuple<int, int, int>(0, 2, 2);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Turning2LayerZAxisCounterClockwiseShouldMovePieceFromm222To202()
        {
            var piece = _cube.Pieces[_cube.Pieces.Count - 1];
            _cube.MakeMove(AxisEnum.Z, 2, DirectionEnum.CounterClockwise);
            var expected = new Tuple<int, int, int>(2, 0, 2);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Turning0LayerXAxisClockwiseShouldMovePieceFromm222To220()
        {
            var piece = _cube.Pieces[_cube.Pieces.Count - 1];
            _cube.MakeMove(AxisEnum.X, 0, DirectionEnum.Clockwise);
            var expected = new Tuple<int, int, int>(2, 2, 0);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Turning0LayerXAxisCounterClockwiseShouldMovePieceFromm222To202()
        {
            var piece = _cube.Pieces[_cube.Pieces.Count - 1];
            _cube.MakeMove(AxisEnum.X, 0, DirectionEnum.CounterClockwise);
            var expected = new Tuple<int, int, int>(2, 0, 2);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Turning0LayerYAxisClockwiseShouldMovePieceFromm222To022()
        {
            var piece = _cube.Pieces[_cube.Pieces.Count - 1];
            _cube.MakeMove(AxisEnum.Y, 0, DirectionEnum.Clockwise);
            var expected = new Tuple<int, int, int>(0, 2, 2);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Turning0LayerYAxisCounterClockwiseShouldMovePieceFromm222To220()
        {
            var piece = _cube.Pieces[_cube.Pieces.Count - 1];
            _cube.MakeMove(AxisEnum.Y, 0, DirectionEnum.CounterClockwise);
            var expected = new Tuple<int, int, int>(2, 2, 0);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Turning0LayerZAxisClockwiseShouldMovePieceFromm222To202()
        {
            var piece = _cube.Pieces[_cube.Pieces.Count - 1];
            _cube.MakeMove(AxisEnum.Z, 0, DirectionEnum.Clockwise);
            var expected = new Tuple<int, int, int>(2, 0, 2);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Turning0LayerZAxisCounterClockwiseShouldMovePieceFromm222To022()
        {
            var piece = _cube.Pieces[_cube.Pieces.Count - 1];
            _cube.MakeMove(AxisEnum.Z, 0, DirectionEnum.CounterClockwise);
            var expected = new Tuple<int, int, int>(0, 2, 2);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IfLayerIsTooBigThrowsError()
        {
            var layer = _cube.Size;
            _cube.MakeMove(AxisEnum.X, layer, DirectionEnum.Clockwise);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IfLayerIsTooSmallThrowsError()
        {
            var layer = -1;
            _cube.MakeMove(AxisEnum.X, layer, DirectionEnum.Clockwise);
        }
    }
}
