using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;

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
			var expected = Side.Color.White;
			var actual = piece.getSideByPosition(Side.Position.Top).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceFrontIsRed()
		{
			var expected = Side.Color.Red;
			var actual = piece.getSideByPosition(Side.Position.Front).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceRightIsBlue()
		{
			var expected = Side.Color.Blue;
			var actual = piece.getSideByPosition(Side.Position.Right).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceBottomIsYellow()
		{
			var expected = Side.Color.Yellow;
			var actual = piece.getSideByPosition(Side.Position.Bottom).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceBackIsOrange()
		{
			var expected = Side.Color.Orange;
			var actual = piece.getSideByPosition(Side.Position.Back).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NewPieceLeftIsGreen()
		{
			var expected = Side.Color.Green;
			var actual = piece.getSideByPosition(Side.Position.Left).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnTopIsRed()
		{
			var expected = Side.Color.Red;
			piece.turnPiece(0, true);
			var actual = piece.getSideByPosition(Side.Position.Top).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnFrontIsYellow()
		{
			var expected = Side.Color.Yellow;
			piece.turnPiece(0, true);
			var actual = piece.getSideByPosition(Side.Position.Front).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnRightIsBlue()
		{
			var expected = Side.Color.Blue;
			piece.turnPiece(0, true);
			var actual = piece.getSideByPosition(Side.Position.Right).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnBottomIsOrange()
		{
			var expected = Side.Color.Orange;
			piece.turnPiece(0, true);
			var actual = piece.getSideByPosition(Side.Position.Bottom).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnBackIsWhite()
		{
			var expected = Side.Color.White;
			piece.turnPiece(0, true);
			var actual = piece.getSideByPosition(Side.Position.Back).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnLeftIsGreen()
		{
			var expected = Side.Color.Green;
			piece.turnPiece(0, true);
			var actual = piece.getSideByPosition(Side.Position.Left).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnTopIsOrange()
		{
			var expected = Side.Color.Orange;
			piece.turnPiece(0, false);
			var actual = piece.getSideByPosition(Side.Position.Top).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnFrontIsWhite()
		{
			var expected = Side.Color.White;
			piece.turnPiece(0, false);
			var actual = piece.getSideByPosition(Side.Position.Front).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnRightIsBlue()
		{
			var expected = Side.Color.Blue;
			piece.turnPiece(0, false);
			var actual = piece.getSideByPosition(Side.Position.Right).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnBottomIsRed()
		{
			var expected = Side.Color.Red;
			piece.turnPiece(0, false);
			var actual = piece.getSideByPosition(Side.Position.Bottom).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnBackIsYellow()
		{
			var expected = Side.Color.Yellow;
			piece.turnPiece(0, false);
			var actual = piece.getSideByPosition(Side.Position.Back).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnLeftIsGreen()
		{
			var expected = Side.Color.Green;
			piece.turnPiece(0, false);
			var actual = piece.getSideByPosition(Side.Position.Left).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnTopIsWhite()
		{
			var expected = Side.Color.White;
			piece.turnPiece(1, true);
			var actual = piece.getSideByPosition(Side.Position.Top).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnFrontIsBlue()
		{
			var expected = Side.Color.Blue;
			piece.turnPiece(1, true);
			var actual = piece.getSideByPosition(Side.Position.Front).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnRightIsOrange()
		{
			var expected = Side.Color.Orange;
			piece.turnPiece(1, true);
			var actual = piece.getSideByPosition(Side.Position.Right).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnBottomIsYellow()
		{
			var expected = Side.Color.Yellow;
			piece.turnPiece(1, true);
			var actual = piece.getSideByPosition(Side.Position.Bottom).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnBackIsGreen()
		{
			var expected = Side.Color.Green;
			piece.turnPiece(1, true);
			var actual = piece.getSideByPosition(Side.Position.Back).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnLeftIsRed()
		{
			var expected = Side.Color.Red;
			piece.turnPiece(1, true);
			var actual = piece.getSideByPosition(Side.Position.Left).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnTopIsWhite()
		{
			var expected = Side.Color.White;
			piece.turnPiece(1, false);
			var actual = piece.getSideByPosition(Side.Position.Top).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnFrontIsGreen()
		{
			var expected = Side.Color.Green;
			piece.turnPiece(1, false);
			var actual = piece.getSideByPosition(Side.Position.Front).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnRightIsRed()
		{
			var expected = Side.Color.Red;
			piece.turnPiece(1, false);
			var actual = piece.getSideByPosition(Side.Position.Right).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnBottomIsYellow()
		{
			var expected = Side.Color.Yellow;
			piece.turnPiece(1, false);
			var actual = piece.getSideByPosition(Side.Position.Bottom).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnBackIsBlue()
		{
			var expected = Side.Color.Blue;
			piece.turnPiece(1, false);
			var actual = piece.getSideByPosition(Side.Position.Back).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnLeftIsOrange()
		{
			var expected = Side.Color.Orange;
			piece.turnPiece(1, false);
			var actual = piece.getSideByPosition(Side.Position.Left).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnTopIsGreen()
		{
			var expected = Side.Color.Green;
			piece.turnPiece(2, true);
			var actual = piece.getSideByPosition(Side.Position.Top).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnFrontIsRed()
		{
			var expected = Side.Color.Red;
			piece.turnPiece(2, true);
			var actual = piece.getSideByPosition(Side.Position.Front).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnRightIsWhite()
		{
			var expected = Side.Color.White;
			piece.turnPiece(2, true);
			var actual = piece.getSideByPosition(Side.Position.Right).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnBottomIsBlue()
		{
			var expected = Side.Color.Blue;
			piece.turnPiece(2, true);
			var actual = piece.getSideByPosition(Side.Position.Bottom).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnBackIsOrange()
		{
			var expected = Side.Color.Orange;
			piece.turnPiece(2, true);
			var actual = piece.getSideByPosition(Side.Position.Back).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnLeftIsYellow()
		{
			var expected = Side.Color.Yellow;
			piece.turnPiece(2, true);
			var actual = piece.getSideByPosition(Side.Position.Left).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnTopIsBlue()
		{
			var expected = Side.Color.Blue;
			piece.turnPiece(2, false);
			var actual = piece.getSideByPosition(Side.Position.Top).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnFrontIsRed()
		{
			var expected = Side.Color.Red;
			piece.turnPiece(2, false);
			var actual = piece.getSideByPosition(Side.Position.Front).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnRightIsYellow()
		{
			var expected = Side.Color.Yellow;
			piece.turnPiece(2, false);
			var actual = piece.getSideByPosition(Side.Position.Right).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnBottomIsGreen()
		{
			var expected = Side.Color.Green;
			piece.turnPiece(2, false);
			var actual = piece.getSideByPosition(Side.Position.Bottom).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnBackIsOrange()
		{
			var expected = Side.Color.Orange;
			piece.turnPiece(2, false);
			var actual = piece.getSideByPosition(Side.Position.Back).SideColor;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnLeftIsWhite()
		{
			var expected = Side.Color.White;
			piece.turnPiece(2, false);
			var actual = piece.getSideByPosition(Side.Position.Left).SideColor;
			Assert.AreEqual(expected, actual);
		}
	}
}
