using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Piece_Tests
{
	[TestClass]
    public class PieceGetSideByColorTests
    {
        private TargetPiece _piece;

        [TestInitialize]
        public void MakePiece()
        {
            _piece = new TargetPiece();
        }

        [TestMethod]
        public void NewPieceWhiteSideIsOnTheTop()
        {
            var expected = SidePositionEnum.Top;
            var actual = _piece.GetSideByColor(ColorEnum.White).SidePositionEnum;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceRedSideIsOnTheFront()
        {
            var expected = SidePositionEnum.Front;
            var actual = _piece.GetSideByColor(ColorEnum.Red).SidePositionEnum;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceBlueSideIsOnTheRight()
        {
            var expected = SidePositionEnum.Right;
            var actual = _piece.GetSideByColor(ColorEnum.Blue).SidePositionEnum;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceYellowSideIsOnTheBottom()
        {
            var expected = SidePositionEnum.Bottom;
            var actual = _piece.GetSideByColor(ColorEnum.Yellow).SidePositionEnum;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceOrangeSideIsOnTheBack()
        {
            var expected = SidePositionEnum.Back;
            var actual = _piece.GetSideByColor(ColorEnum.Orange).SidePositionEnum;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceGreenSideIsOnTheLeft()
        {
            var expected = SidePositionEnum.Left;
            var actual = _piece.GetSideByColor(ColorEnum.Green).SidePositionEnum;
            Assert.AreEqual(expected, actual);
        }
		
		[TestMethod]
		public void PieceClockWiseXTurnWhiteSideIsOnTheBack()
		{
			var expected = SidePositionEnum.Back;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.White).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
        public void PieceClockWiseXTurnRedSideIsOnTheTop()
        {
            var expected = SidePositionEnum.Top;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
            var actual = _piece.GetSideByColor(ColorEnum.Red).SidePositionEnum;
            Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnBlueSideIsOnTheRight()
		{
			var expected = SidePositionEnum.Right;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Blue).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
        public void PieceClockWiseXTurnYellowSideIsOnTheFront()
        {
            var expected = SidePositionEnum.Front;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Yellow).SidePositionEnum;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PieceClockWiseXTurnOrangeSideIsOnTheBottom()
        {
            var expected = SidePositionEnum.Bottom;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Orange).SidePositionEnum;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PieceClockWiseXTurnGreenSideIsOnTheLeft()
        {
            var expected = SidePositionEnum.Left;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Green).SidePositionEnum;
            Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnWhiteSideIsOnTheFront()
		{
			var expected = SidePositionEnum.Front;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.White).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnRedSideIsOnTheTopBottom()
		{
			var expected = SidePositionEnum.Bottom;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Red).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnBlueSideIsOnTheRight()
		{
			var expected = SidePositionEnum.Right;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Blue).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnYellowSideIsOnTheBack()
		{
			var expected = SidePositionEnum.Back;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Yellow).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnOrangeSideIsOnTheTop()
		{
			var expected = SidePositionEnum.Top;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Orange).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnGreenSideIsOnTheLeft()
		{
			var expected = SidePositionEnum.Left;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Green).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnWhiteSideIsOnTheTop()
		{
			var expected = SidePositionEnum.Top;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.White).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnRedSideIsOnTheLeft()
		{
			var expected = SidePositionEnum.Left;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Red).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnBlueSideIsOnTheFront()
		{
			var expected = SidePositionEnum.Front;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Blue).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnYellowSideIsOnTheBottom()
		{
			var expected = SidePositionEnum.Bottom;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Yellow).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnOrangeSideIsOnTheRight()
		{
			var expected = SidePositionEnum.Right;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Orange).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnGreenSideIsOnTheBack()
		{
			var expected = SidePositionEnum.Back;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Green).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnWhiteSideIsOnTheTop()
		{
			var expected = SidePositionEnum.Top;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.White).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnRedSideIsOnTheTopRight()
		{
			var expected = SidePositionEnum.Right;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Red).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnBlueSideIsOnTheBack()
		{
			var expected = SidePositionEnum.Back;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Blue).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnYellowSideIsOnTheBottom()
		{
			var expected = SidePositionEnum.Bottom;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Yellow).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnOrangeSideIsOnTheLeft()
		{
			var expected = SidePositionEnum.Left;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Orange).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnGreenSideIsOnTheFront()
		{
			var expected = SidePositionEnum.Front;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Green).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnWhiteSideIsOnTheRight()
		{
			var expected = SidePositionEnum.Right;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.White).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnRedSideIsOnTheFront()
		{
			var expected = SidePositionEnum.Front;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Red).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnBlueSideIsOnTheBottom()
		{
			var expected = SidePositionEnum.Bottom;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Blue).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnYellowSideIsOnTheLeft()
		{
			var expected = SidePositionEnum.Left;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Yellow).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnOrangeSideIsOnTheBack()
		{
			var expected = SidePositionEnum.Back;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Orange).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnGreenSideIsOnTheTop()
		{
			var expected = SidePositionEnum.Top;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Green).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnWhiteSideIsOnTheLeft()
		{
			var expected = SidePositionEnum.Left;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.White).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnRedSideIsOnTheTopFront()
		{
			var expected = SidePositionEnum.Front;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Red).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnBlueSideIsOnTheTop()
		{
			var expected = SidePositionEnum.Top;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Blue).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnYellowSideIsOnTheRight()
		{
			var expected = SidePositionEnum.Right;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Yellow).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnOrangeSideIsOnTheBack()
		{
			var expected = SidePositionEnum.Back;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Orange).SidePositionEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnGreenSideIsOnTheBottom()
		{
			var expected = SidePositionEnum.Bottom;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByColor(ColorEnum.Green).SidePositionEnum;
			Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
	    public void NoWhiteSidesWillThrowAnError()
	    {
	        _piece.Sides[0] = new Side(ColorEnum.Red, SidePositionEnum.Front);
	        _piece.GetSideByColor(ColorEnum.White);
	    }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TwoWhiteSidesWillThrowAnError()
        {
            _piece.Sides[1] = new Side(ColorEnum.White, SidePositionEnum.Top);
            _piece.GetSideByColor(ColorEnum.White);
        }
	}
}
