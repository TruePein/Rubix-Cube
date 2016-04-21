﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Unseen_Piece_Tests
{
	[TestClass]
	public class UnseenPieceCalculateDistanceTests
	{
	    private UnseenPiece _piece;
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
			_piece = new UnseenPiece(0,0,0);
		}

		[TestMethod]
		public void NewUnseenPieceHasADistanceofZero()
		{
			var actual = _piece.CalculateDistance(_target);
			Assert.AreEqual(Expected, actual);
		}

		[TestMethod]
		public void ClockWiseXTurnHasADistanceOfZero()
		{
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = _piece.CalculateDistance(_target);
			Assert.AreEqual(Expected, actual);
		}

		[TestMethod]
		public void CounterClockWiseXTurnHasADistanceOfZero()
		{
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = _piece.CalculateDistance(_target);
			Assert.AreEqual(Expected, actual);
		}

		[TestMethod]
		public void ClockWiseYTurnHasADistanceOfZero()
		{
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = _piece.CalculateDistance(_target);
			Assert.AreEqual(Expected, actual);
		}

		[TestMethod]
		public void CounterClockWiseYTurnHasADistanceOfZero()
		{
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = _piece.CalculateDistance(_target);
			Assert.AreEqual(Expected, actual);
		}

		[TestMethod]
		public void ClockWiseZTurnHasADistanceOfZero()
		{
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = _piece.CalculateDistance(_target);
			Assert.AreEqual(Expected, actual);
		}

		[TestMethod]
		public void CounterClockWiseZTurnHasADistanceOfZero()
		{
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = _piece.CalculateDistance(_target);
			Assert.AreEqual(Expected, actual);
		}

		[TestMethod]
		public void TwoClockWiseXTurnsHasADistanceOfZero()
		{
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = _piece.CalculateDistance(_target);
			Assert.AreEqual(Expected, actual);
		}
	}
}