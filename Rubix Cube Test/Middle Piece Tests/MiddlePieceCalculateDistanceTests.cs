﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Middle_Piece_Tests
{
    [TestClass]
    public class MiddlePieceCalculateDistanceTests
    {
        private MiddlePiece _piece;
        private static TargetPiece _target;
        private const int Expected = 0;

        [ClassInitialize()]
        public static void InitializeTests(TestContext context)
        {
            _target = new TargetPiece();
        }

        [TestInitialize]
        public void CreatePiece()
        {
            _piece = PieceFactory.GetPiece(1, 1, 0, 3) as MiddlePiece;
        }

        [TestMethod]
        public void NewMiddlePieceHasADistanceofZero()
        {
            var actual = _piece.CalculateDistance(_target);
            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void ClockWiseXTurnHasADistanceOfZero()
        {
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var actual = _piece.CalculateDistance(_target);
            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void CounterClockWiseXTurnHasADistanceOfZero()
        {
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
            var actual = _piece.CalculateDistance(_target);
            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void ClockWiseYTurnHasADistanceOfZero()
        {
            _piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
            var actual = _piece.CalculateDistance(_target);
            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void CounterClockWiseYTurnHasADistanceOfZero()
        {
            _piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
            var actual = _piece.CalculateDistance(_target);
            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void ClockWiseZTurnHasADistanceOfZero()
        {
            _piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
            var actual = _piece.CalculateDistance(_target);
            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void CounterClockWiseZTurnHasADistanceOfZero()
        {
            _piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
            var actual = _piece.CalculateDistance(_target);
            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void TwoClockWiseXTurnsHasADistanceOfZero()
        {
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            _piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var actual = _piece.CalculateDistance(_target);
            Assert.AreEqual(Expected, actual);
        }
    }
}