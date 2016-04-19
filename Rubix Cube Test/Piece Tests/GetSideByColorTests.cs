using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

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
            var expected = SidePositions.Position.Top;
            var actual = piece.getSideByColor(Colors.Color.White).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceRedSideIsOnTheFront()
        {
            var expected = SidePositions.Position.Front;
            var actual = piece.getSideByColor(Colors.Color.Red).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceBlueSideIsOnTheRight()
        {
            var expected = SidePositions.Position.Right;
            var actual = piece.getSideByColor(Colors.Color.Blue).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceYellowSideIsOnTheBottom()
        {
            var expected = SidePositions.Position.Bottom;
            var actual = piece.getSideByColor(Colors.Color.Yellow).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceOrangeSideIsOnTheBack()
        {
            var expected = SidePositions.Position.Back;
            var actual = piece.getSideByColor(Colors.Color.Orange).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceGreenSideIsOnTheLeft()
        {
            var expected = SidePositions.Position.Left;
            var actual = piece.getSideByColor(Colors.Color.Green).Position;
            Assert.AreEqual(expected, actual);
        }
		
		[TestMethod]
		public void PieceClockWiseXTurnWhiteSideIsOnTheBack()
		{
			var expected = SidePositions.Position.Back;
			piece.turnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.White).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
        public void PieceClockWiseXTurnRedSideIsOnTheTop()
        {
            var expected = SidePositions.Position.Top;
			piece.turnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            var actual = piece.getSideByColor(Colors.Color.Red).Position;
            Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnBlueSideIsOnTheRight()
		{
			var expected = SidePositions.Position.Right;
			piece.turnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Blue).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
        public void PieceClockWiseXTurnYellowSideIsOnTheFront()
        {
            var expected = SidePositions.Position.Front;
			piece.turnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Yellow).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PieceClockWiseXTurnOrangeSideIsOnTheBottom()
        {
            var expected = SidePositions.Position.Bottom;
			piece.turnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Orange).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PieceClockWiseXTurnGreenSideIsOnTheLeft()
        {
            var expected = SidePositions.Position.Left;
			piece.turnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Green).Position;
            Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnWhiteSideIsOnTheFront()
		{
			var expected = SidePositions.Position.Front;
			piece.turnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.White).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnRedSideIsOnTheTopBottom()
		{
			var expected = SidePositions.Position.Bottom;
			piece.turnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Red).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnBlueSideIsOnTheRight()
		{
			var expected = SidePositions.Position.Right;
			piece.turnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Blue).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnYellowSideIsOnTheBack()
		{
			var expected = SidePositions.Position.Back;
			piece.turnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Yellow).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnOrangeSideIsOnTheTop()
		{
			var expected = SidePositions.Position.Top;
			piece.turnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Orange).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnGreenSideIsOnTheLeft()
		{
			var expected = SidePositions.Position.Left;
			piece.turnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Green).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnWhiteSideIsOnTheTop()
		{
			var expected = SidePositions.Position.Top;
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.White).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnRedSideIsOnTheLeft()
		{
			var expected = SidePositions.Position.Left;
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Red).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnBlueSideIsOnTheFront()
		{
			var expected = SidePositions.Position.Front;
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Blue).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnYellowSideIsOnTheBottom()
		{
			var expected = SidePositions.Position.Bottom;
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Yellow).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnOrangeSideIsOnTheRight()
		{
			var expected = SidePositions.Position.Right;
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Orange).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnGreenSideIsOnTheBack()
		{
			var expected = SidePositions.Position.Back;
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Green).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnWhiteSideIsOnTheTop()
		{
			var expected = SidePositions.Position.Top;
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.White).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnRedSideIsOnTheTopRight()
		{
			var expected = SidePositions.Position.Right;
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Red).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnBlueSideIsOnTheBack()
		{
			var expected = SidePositions.Position.Back;
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Blue).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnYellowSideIsOnTheBottom()
		{
			var expected = SidePositions.Position.Bottom;
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Yellow).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnOrangeSideIsOnTheLeft()
		{
			var expected = SidePositions.Position.Left;
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Orange).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnGreenSideIsOnTheFront()
		{
			var expected = SidePositions.Position.Front;
			piece.turnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Green).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnWhiteSideIsOnTheRight()
		{
			var expected = SidePositions.Position.Right;
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.White).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnRedSideIsOnTheFront()
		{
			var expected = SidePositions.Position.Front;
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Red).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnBlueSideIsOnTheBottom()
		{
			var expected = SidePositions.Position.Bottom;
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Blue).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnYellowSideIsOnTheLeft()
		{
			var expected = SidePositions.Position.Left;
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Yellow).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnOrangeSideIsOnTheBack()
		{
			var expected = SidePositions.Position.Back;
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Orange).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnGreenSideIsOnTheTop()
		{
			var expected = SidePositions.Position.Top;
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = piece.getSideByColor(Colors.Color.Green).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnWhiteSideIsOnTheLeft()
		{
			var expected = SidePositions.Position.Left;
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.White).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnRedSideIsOnTheTopFront()
		{
			var expected = SidePositions.Position.Front;
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Red).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnBlueSideIsOnTheTop()
		{
			var expected = SidePositions.Position.Top;
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Blue).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnYellowSideIsOnTheRight()
		{
			var expected = SidePositions.Position.Right;
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Yellow).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnOrangeSideIsOnTheBack()
		{
			var expected = SidePositions.Position.Back;
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Orange).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnGreenSideIsOnTheBottom()
		{
			var expected = SidePositions.Position.Bottom;
			piece.turnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = piece.getSideByColor(Colors.Color.Green).Position;
			Assert.AreEqual(expected, actual);
		}
	}
}
