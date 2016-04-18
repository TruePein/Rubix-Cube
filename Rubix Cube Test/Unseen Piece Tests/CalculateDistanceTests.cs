using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;

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
			piece = new UnseenPiece();
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
			piece.turnPiece(0, true);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CounterClockWiseXTurnHasADistanceOfZero()
		{
			piece.turnPiece(0, false);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ClockWiseYTurnHasADistanceOfZero()
		{
			piece.turnPiece(1, true);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CounterClockWiseYTurnHasADistanceOfZero()
		{
			piece.turnPiece(1, false);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ClockWiseZTurnHasADistanceOfZero()
		{
			piece.turnPiece(2, true);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CounterClockWiseZTurnHasADistanceOfZero()
		{
			piece.turnPiece(2, false);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TwoClockWiseXTurnsHasADistanceOfZero()
		{
			piece.turnPiece(0, true);
			piece.turnPiece(0, true);
			var actual = piece.calculateDistance(target);
			Assert.AreEqual(expected, actual);
		}
	}
}
