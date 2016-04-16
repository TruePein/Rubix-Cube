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
        public void PieceClockWiseXTurnRedSideIsOnTheTop()
        {
            var expected = Side.Position.Top;
			piece.turnPiece(0, true);
            var actual = piece.getSideByColor(Side.Color.Red).SidePosition;
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
        public void PieceClockWiseXTurnBlueSideIsOnTheRight()
        {
            var expected = Side.Position.Right;
			piece.turnPiece(0, true);
			var actual = piece.getSideByColor(Side.Color.Blue).SidePosition;
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
        public void PieceClockWiseXTurnWhiteSideIsOnTheBack()
        {
            var expected = Side.Position.Back;
			piece.turnPiece(0, true);
			var actual = piece.getSideByColor(Side.Color.White).SidePosition;
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
    }
}
