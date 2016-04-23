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
			var expected = Colors.Color.White;
			var actual = _piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceFrontIsRed()
		{
			var expected = Colors.Color.Red;
			var actual = _piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceRightIsBlue()
		{
			var expected = Colors.Color.Blue;
			var actual = _piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceBottomIsYellow()
		{
			var expected = Colors.Color.Yellow;
			var actual = _piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceBackIsOrange()
		{
			var expected = Colors.Color.Orange;
			var actual = _piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceLeftIsGreen()
		{
			var expected = Colors.Color.Green;
			var actual = _piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnTopIsRed()
		{
			var expected = Colors.Color.Red;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnFrontIsYellow()
		{
			var expected = Colors.Color.Yellow;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnRightIsBlue()
		{
			var expected = Colors.Color.Blue;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnBottomIsOrange()
		{
			var expected = Colors.Color.Orange;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnBackIsWhite()
		{
			var expected = Colors.Color.White;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnLeftIsGreen()
		{
			var expected = Colors.Color.Green;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnTopIsOrange()
		{
			var expected = Colors.Color.Orange;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnFrontIsWhite()
		{
			var expected = Colors.Color.White;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnRightIsBlue()
		{
			var expected = Colors.Color.Blue;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnBottomIsRed()
		{
			var expected = Colors.Color.Red;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnBackIsYellow()
		{
			var expected = Colors.Color.Yellow;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnLeftIsGreen()
		{
			var expected = Colors.Color.Green;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnTopIsWhite()
		{
			var expected = Colors.Color.White;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnFrontIsBlue()
		{
			var expected = Colors.Color.Blue;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnRightIsOrange()
		{
			var expected = Colors.Color.Orange;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnBottomIsYellow()
		{
			var expected = Colors.Color.Yellow;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnBackIsGreen()
		{
			var expected = Colors.Color.Green;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnLeftIsRed()
		{
			var expected = Colors.Color.Red;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnTopIsWhite()
		{
			var expected = Colors.Color.White;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnFrontIsGreen()
		{
			var expected = Colors.Color.Green;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnRightIsRed()
		{
			var expected = Colors.Color.Red;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnBottomIsYellow()
		{
			var expected = Colors.Color.Yellow;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnBackIsBlue()
		{
			var expected = Colors.Color.Blue;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnLeftIsOrange()
		{
			var expected = Colors.Color.Orange;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnTopIsGreen()
		{
			var expected = Colors.Color.Green;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnFrontIsRed()
		{
			var expected = Colors.Color.Red;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnRightIsWhite()
		{
			var expected = Colors.Color.White;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnBottomIsBlue()
		{
			var expected = Colors.Color.Blue;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnBackIsOrange()
		{
			var expected = Colors.Color.Orange;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnLeftIsYellow()
		{
			var expected = Colors.Color.Yellow;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnTopIsBlue()
		{
			var expected = Colors.Color.Blue;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnFrontIsRed()
		{
			var expected = Colors.Color.Red;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnRightIsYellow()
		{
			var expected = Colors.Color.Yellow;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnBottomIsGreen()
		{
			var expected = Colors.Color.Green;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnBackIsOrange()
		{
			var expected = Colors.Color.Orange;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnLeftIsWhite()
		{
			var expected = Colors.Color.White;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}
	}
}
