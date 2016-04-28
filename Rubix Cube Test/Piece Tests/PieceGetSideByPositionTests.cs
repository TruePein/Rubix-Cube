using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Piece_Tests
{
	[TestClass]
	public class PieceGetSideByPositionTests
	{
		private TargetPiece _piece;

		[TestInitialize]
		public void MakePiece()
		{
			_piece = new TargetPiece();
		}

		[TestMethod]
		public void NewPieceTopIsWhite()
		{
			var expected = ColorEnum.White;
			var actual = _piece.GetSideByPosition(SidePositionEnum.Top).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceFrontIsRed()
		{
			var expected = ColorEnum.Red;
			var actual = _piece.GetSideByPosition(SidePositionEnum.Front).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceRightIsBlue()
		{
			var expected = ColorEnum.Blue;
			var actual = _piece.GetSideByPosition(SidePositionEnum.Right).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceBottomIsYellow()
		{
			var expected = ColorEnum.Yellow;
			var actual = _piece.GetSideByPosition(SidePositionEnum.Bottom).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceBackIsOrange()
		{
			var expected = ColorEnum.Orange;
			var actual = _piece.GetSideByPosition(SidePositionEnum.Back).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceLeftIsGreen()
		{
			var expected = ColorEnum.Green;
			var actual = _piece.GetSideByPosition(SidePositionEnum.Left).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnTopIsRed()
		{
			var expected = ColorEnum.Red;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Top).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnFrontIsYellow()
		{
			var expected = ColorEnum.Yellow;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Front).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnRightIsBlue()
		{
			var expected = ColorEnum.Blue;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Right).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnBottomIsOrange()
		{
			var expected = ColorEnum.Orange;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Bottom).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnBackIsWhite()
		{
			var expected = ColorEnum.White;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Back).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnLeftIsGreen()
		{
			var expected = ColorEnum.Green;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Left).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnTopIsOrange()
		{
			var expected = ColorEnum.Orange;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Top).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnFrontIsWhite()
		{
			var expected = ColorEnum.White;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Front).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnRightIsBlue()
		{
			var expected = ColorEnum.Blue;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Right).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnBottomIsRed()
		{
			var expected = ColorEnum.Red;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Bottom).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnBackIsYellow()
		{
			var expected = ColorEnum.Yellow;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Back).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnLeftIsGreen()
		{
			var expected = ColorEnum.Green;
			_piece.TurnPiece(AxisEnum.X, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Left).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnTopIsWhite()
		{
			var expected = ColorEnum.White;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Top).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnFrontIsBlue()
		{
			var expected = ColorEnum.Blue;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Front).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnRightIsOrange()
		{
			var expected = ColorEnum.Orange;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Right).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnBottomIsYellow()
		{
			var expected = ColorEnum.Yellow;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Bottom).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnBackIsGreen()
		{
			var expected = ColorEnum.Green;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Back).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnLeftIsRed()
		{
			var expected = ColorEnum.Red;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Left).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnTopIsWhite()
		{
			var expected = ColorEnum.White;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Top).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnFrontIsGreen()
		{
			var expected = ColorEnum.Green;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Front).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnRightIsRed()
		{
			var expected = ColorEnum.Red;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Right).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnBottomIsYellow()
		{
			var expected = ColorEnum.Yellow;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Bottom).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnBackIsBlue()
		{
			var expected = ColorEnum.Blue;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Back).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnLeftIsOrange()
		{
			var expected = ColorEnum.Orange;
			_piece.TurnPiece(AxisEnum.Z, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Left).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnTopIsGreen()
		{
			var expected = ColorEnum.Green;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Top).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnFrontIsRed()
		{
			var expected = ColorEnum.Red;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Front).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnRightIsWhite()
		{
			var expected = ColorEnum.White;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Right).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnBottomIsBlue()
		{
			var expected = ColorEnum.Blue;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Bottom).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnBackIsOrange()
		{
			var expected = ColorEnum.Orange;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Back).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnLeftIsYellow()
		{
			var expected = ColorEnum.Yellow;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Left).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnTopIsBlue()
		{
			var expected = ColorEnum.Blue;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Top).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnFrontIsRed()
		{
			var expected = ColorEnum.Red;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Front).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnRightIsYellow()
		{
			var expected = ColorEnum.Yellow;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Right).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnBottomIsGreen()
		{
			var expected = ColorEnum.Green;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Bottom).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnBackIsOrange()
		{
			var expected = ColorEnum.Orange;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Back).ColorEnum;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnLeftIsWhite()
		{
			var expected = ColorEnum.White;
			_piece.TurnPiece(AxisEnum.Y, DirectionEnum.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositionEnum.Left).ColorEnum;
			Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NoTopSidesWillThrowAnError()
        {
            _piece.Sides[0] = new Side(ColorEnum.Red, SidePositionEnum.Front);
            _piece.GetSideByPosition(SidePositionEnum.Top);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TwoTopSidesWillThrowAnError()
        {
            _piece.Sides[1] = new Side(ColorEnum.White, SidePositionEnum.Top);
            _piece.GetSideByPosition(SidePositionEnum.Top);
        }
    }
}
