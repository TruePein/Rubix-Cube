using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Piece_Tests
{
	[TestClass]
	public class GetSideByPositionTests
	{
		public TargetPiece piece;

		[TestInitialize]
		public void makePiece()
		{
			piece = new TargetPiece();
		}

		[TestMethod]
		public void NewPieceTopIsWhite()
		{
			var expected = Colors.Color.White;
			var actual = piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceFrontIsRed()
		{
			var expected = Colors.Color.Red;
			var actual = piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceRightIsBlue()
		{
			var expected = Colors.Color.Blue;
			var actual = piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceBottomIsYellow()
		{
			var expected = Colors.Color.Yellow;
			var actual = piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceBackIsOrange()
		{
			var expected = Colors.Color.Orange;
			var actual = piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceLeftIsGreen()
		{
			var expected = Colors.Color.Green;
			var actual = piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnTopIsRed()
		{
			var expected = Colors.Color.Red;
			piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnFrontIsYellow()
		{
			var expected = Colors.Color.Yellow;
			piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnRightIsBlue()
		{
			var expected = Colors.Color.Blue;
			piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnBottomIsOrange()
		{
			var expected = Colors.Color.Orange;
			piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnBackIsWhite()
		{
			var expected = Colors.Color.White;
			piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnLeftIsGreen()
		{
			var expected = Colors.Color.Green;
			piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnTopIsOrange()
		{
			var expected = Colors.Color.Orange;
			piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnFrontIsWhite()
		{
			var expected = Colors.Color.White;
			piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnRightIsBlue()
		{
			var expected = Colors.Color.Blue;
			piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnBottomIsRed()
		{
			var expected = Colors.Color.Red;
			piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnBackIsYellow()
		{
			var expected = Colors.Color.Yellow;
			piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnLeftIsGreen()
		{
			var expected = Colors.Color.Green;
			piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnTopIsWhite()
		{
			var expected = Colors.Color.White;
			piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnFrontIsBlue()
		{
			var expected = Colors.Color.Blue;
			piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnRightIsOrange()
		{
			var expected = Colors.Color.Orange;
			piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnBottomIsYellow()
		{
			var expected = Colors.Color.Yellow;
			piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnBackIsGreen()
		{
			var expected = Colors.Color.Green;
			piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnLeftIsRed()
		{
			var expected = Colors.Color.Red;
			piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnTopIsWhite()
		{
			var expected = Colors.Color.White;
			piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnFrontIsGreen()
		{
			var expected = Colors.Color.Green;
			piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnRightIsRed()
		{
			var expected = Colors.Color.Red;
			piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnBottomIsYellow()
		{
			var expected = Colors.Color.Yellow;
			piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnBackIsBlue()
		{
			var expected = Colors.Color.Blue;
			piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnLeftIsOrange()
		{
			var expected = Colors.Color.Orange;
			piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnTopIsGreen()
		{
			var expected = Colors.Color.Green;
			piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnFrontIsRed()
		{
			var expected = Colors.Color.Red;
			piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnRightIsWhite()
		{
			var expected = Colors.Color.White;
			piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnBottomIsBlue()
		{
			var expected = Colors.Color.Blue;
			piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnBackIsOrange()
		{
			var expected = Colors.Color.Orange;
			piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnLeftIsYellow()
		{
			var expected = Colors.Color.Yellow;
			piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnTopIsBlue()
		{
			var expected = Colors.Color.Blue;
			piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Top).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnFrontIsRed()
		{
			var expected = Colors.Color.Red;
			piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Front).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnRightIsYellow()
		{
			var expected = Colors.Color.Yellow;
			piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Right).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnBottomIsGreen()
		{
			var expected = Colors.Color.Green;
			piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Bottom).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnBackIsOrange()
		{
			var expected = Colors.Color.Orange;
			piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Back).Color;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnLeftIsWhite()
		{
			var expected = Colors.Color.White;
			piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = piece.GetSideByPosition(SidePositions.Position.Left).Color;
			Assert.AreEqual(expected, actual);
		}
	}
}
