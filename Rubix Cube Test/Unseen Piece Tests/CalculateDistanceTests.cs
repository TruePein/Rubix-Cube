using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Unseen_Piece_Tests
{
	[TestClass]
	public class CalculateDistanceTests
	{
		UnseenPiece piece;
		static TargetPiece target;
		int expected = 0;

		[ClassInitialize()]
		public static void InitializeTests(TestContext context)
		{
			target = new TargetPiece();
		}

		[TestInitialize]
		public void CreatePiece()
		{
			piece = new UnseenPiece(0,0,0);
		}

		[TestMethod]
		public void NewUnseenPieceHasADistanceofZero()
		{
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ClockWiseXTurnHasADistanceOfZero()
		{
			piece.turnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CounterClockWiseXTurnHasADistanceOfZero()
		{
			piece.turnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ClockWiseYTurnHasADistanceOfZero()
		{
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CounterClockWiseYTurnHasADistanceOfZero()
		{
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ClockWiseZTurnHasADistanceOfZero()
		{
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CounterClockWiseZTurnHasADistanceOfZero()
		{
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TwoClockWiseXTurnsHasADistanceOfZero()
		{
			piece.turnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			piece.turnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}
	}
}
