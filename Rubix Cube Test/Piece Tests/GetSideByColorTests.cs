using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;

namespace Rubix_Cube_Test.Piece_Tests
{
	[TestClass]
    public class GetSideByColorTests
    {
        public TargetPiece piece;

        [TestInitialize]
        public void makePiece()
        {
            piece = new TargetPiece();
        }

        [TestMethod]
        public void NewPieceWhiteSideIsOnTheTop()
        {
            var expected = Side.Position.Top;
            var actual = piece.getSideByColor(Side.Color.White).SidePosition;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceRedSideIsOnTheFront()
        {
            var expected = Side.Position.Front;
            var actual = piece.getSideByColor(Side.Color.Red).SidePosition;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceBlueSideIsOnTheRight()
        {
            var expected = Side.Position.Right;
            var actual = piece.getSideByColor(Side.Color.Blue).SidePosition;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceYellowSideIsOnTheBottom()
        {
            var expected = Side.Position.Bottom;
            var actual = piece.getSideByColor(Side.Color.Yellow).SidePosition;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceOrangeSideIsOnTheBack()
        {
            var expected = Side.Position.Back;
            var actual = piece.getSideByColor(Side.Color.Orange).SidePosition;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceGreenSideIsOnTheLeft()
        {
            var expected = Side.Position.Left;
            var actual = piece.getSideByColor(Side.Color.Green).SidePosition;
            Assert.AreEqual(expected, actual);
        }
		
		[TestMethod]
		public void PieceClockWiseXTurnWhiteSideIsOnTheBack()
		{
			var expected = Side.Position.Back;
			piece.turnPiece(0, true);
			var actual = piece.getSideByColor(Side.Color.White).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
        public void PieceClockWiseXTurnRedSideIsOnTheTop()
        {
            var expected = Side.Position.Top;
			piece.turnPiece(0, true);
            var actual = piece.getSideByColor(Side.Color.Red).SidePosition;
            Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnBlueSideIsOnTheRight()
		{
			var expected = Side.Position.Right;
			piece.turnPiece(0, true);
			var actual = piece.getSideByColor(Side.Color.Blue).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
        public void PieceClockWiseXTurnYellowSideIsOnTheFront()
        {
            var expected = Side.Position.Front;
			piece.turnPiece(0, true);
			var actual = piece.getSideByColor(Side.Color.Yellow).SidePosition;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PieceClockWiseXTurnOrangeSideIsOnTheBottom()
        {
            var expected = Side.Position.Bottom;
			piece.turnPiece(0, true);
			var actual = piece.getSideByColor(Side.Color.Orange).SidePosition;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PieceClockWiseXTurnGreenSideIsOnTheLeft()
        {
            var expected = Side.Position.Left;
			piece.turnPiece(0, true);
			var actual = piece.getSideByColor(Side.Color.Green).SidePosition;
            Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnWhiteSideIsOnTheFront()
		{
			var expected = Side.Position.Front;
			piece.turnPiece(0, false);
			var actual = piece.getSideByColor(Side.Color.White).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnRedSideIsOnTheTopBottom()
		{
			var expected = Side.Position.Bottom;
			piece.turnPiece(0, false);
			var actual = piece.getSideByColor(Side.Color.Red).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnBlueSideIsOnTheRight()
		{
			var expected = Side.Position.Right;
			piece.turnPiece(0, false);
			var actual = piece.getSideByColor(Side.Color.Blue).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnYellowSideIsOnTheBack()
		{
			var expected = Side.Position.Back;
			piece.turnPiece(0, false);
			var actual = piece.getSideByColor(Side.Color.Yellow).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnOrangeSideIsOnTheTop()
		{
			var expected = Side.Position.Top;
			piece.turnPiece(0, false);
			var actual = piece.getSideByColor(Side.Color.Orange).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnGreenSideIsOnTheLeft()
		{
			var expected = Side.Position.Left;
			piece.turnPiece(0, false);
			var actual = piece.getSideByColor(Side.Color.Green).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnWhiteSideIsOnTheTop()
		{
			var expected = Side.Position.Top;
			piece.turnPiece(1, true);
			var actual = piece.getSideByColor(Side.Color.White).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnRedSideIsOnTheLeft()
		{
			var expected = Side.Position.Left;
			piece.turnPiece(1, true);
			var actual = piece.getSideByColor(Side.Color.Red).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnBlueSideIsOnTheFront()
		{
			var expected = Side.Position.Front;
			piece.turnPiece(1, true);
			var actual = piece.getSideByColor(Side.Color.Blue).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnYellowSideIsOnTheBottom()
		{
			var expected = Side.Position.Bottom;
			piece.turnPiece(1, true);
			var actual = piece.getSideByColor(Side.Color.Yellow).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnOrangeSideIsOnTheRight()
		{
			var expected = Side.Position.Right;
			piece.turnPiece(1, true);
			var actual = piece.getSideByColor(Side.Color.Orange).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnGreenSideIsOnTheBack()
		{
			var expected = Side.Position.Back;
			piece.turnPiece(1, true);
			var actual = piece.getSideByColor(Side.Color.Green).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnWhiteSideIsOnTheTop()
		{
			var expected = Side.Position.Top;
			piece.turnPiece(1, false);
			var actual = piece.getSideByColor(Side.Color.White).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnRedSideIsOnTheTopRight()
		{
			var expected = Side.Position.Right;
			piece.turnPiece(1, false);
			var actual = piece.getSideByColor(Side.Color.Red).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnBlueSideIsOnTheBack()
		{
			var expected = Side.Position.Back;
			piece.turnPiece(1, false);
			var actual = piece.getSideByColor(Side.Color.Blue).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnYellowSideIsOnTheBottom()
		{
			var expected = Side.Position.Bottom;
			piece.turnPiece(1, false);
			var actual = piece.getSideByColor(Side.Color.Yellow).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnOrangeSideIsOnTheLeft()
		{
			var expected = Side.Position.Left;
			piece.turnPiece(1, false);
			var actual = piece.getSideByColor(Side.Color.Orange).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnGreenSideIsOnTheFront()
		{
			var expected = Side.Position.Front;
			piece.turnPiece(1, false);
			var actual = piece.getSideByColor(Side.Color.Green).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnWhiteSideIsOnTheRight()
		{
			var expected = Side.Position.Right;
			piece.turnPiece(2, true);
			var actual = piece.getSideByColor(Side.Color.White).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnRedSideIsOnTheFront()
		{
			var expected = Side.Position.Front;
			piece.turnPiece(2, true);
			var actual = piece.getSideByColor(Side.Color.Red).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnBlueSideIsOnTheBottom()
		{
			var expected = Side.Position.Bottom;
			piece.turnPiece(2, true);
			var actual = piece.getSideByColor(Side.Color.Blue).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnYellowSideIsOnTheLeft()
		{
			var expected = Side.Position.Left;
			piece.turnPiece(2, true);
			var actual = piece.getSideByColor(Side.Color.Yellow).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnOrangeSideIsOnTheBack()
		{
			var expected = Side.Position.Back;
			piece.turnPiece(2, true);
			var actual = piece.getSideByColor(Side.Color.Orange).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnGreenSideIsOnTheTop()
		{
			var expected = Side.Position.Top;
			piece.turnPiece(2, true);
			var actual = piece.getSideByColor(Side.Color.Green).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnWhiteSideIsOnTheLeft()
		{
			var expected = Side.Position.Left;
			piece.turnPiece(2, false);
			var actual = piece.getSideByColor(Side.Color.White).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnRedSideIsOnTheTopFront()
		{
			var expected = Side.Position.Front;
			piece.turnPiece(2, false);
			var actual = piece.getSideByColor(Side.Color.Red).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnBlueSideIsOnTheTop()
		{
			var expected = Side.Position.Top;
			piece.turnPiece(2, false);
			var actual = piece.getSideByColor(Side.Color.Blue).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnYellowSideIsOnTheRight()
		{
			var expected = Side.Position.Right;
			piece.turnPiece(2, false);
			var actual = piece.getSideByColor(Side.Color.Yellow).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnOrangeSideIsOnTheBack()
		{
			var expected = Side.Position.Back;
			piece.turnPiece(2, false);
			var actual = piece.getSideByColor(Side.Color.Orange).SidePosition;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnGreenSideIsOnTheBottom()
		{
			var expected = Side.Position.Bottom;
			piece.turnPiece(2, false);
			var actual = piece.getSideByColor(Side.Color.Green).SidePosition;
			Assert.AreEqual(expected, actual);
		}
	}
}
