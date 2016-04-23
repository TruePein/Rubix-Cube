using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Piece_Tests
{
	[TestClass]
    public class PieceGetSideByColorTests
    {
        private TargetPiece _piece;

        [TestInitialize]
        public void MakePiece()
        {
            _piece = new TargetPiece();
        }

        [TestMethod]
        public void NewPieceWhiteSideIsOnTheTop()
        {
            var expected = SidePositions.Position.Top;
            var actual = _piece.GetSideByColor(Colors.Color.White).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceRedSideIsOnTheFront()
        {
            var expected = SidePositions.Position.Front;
            var actual = _piece.GetSideByColor(Colors.Color.Red).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceBlueSideIsOnTheRight()
        {
            var expected = SidePositions.Position.Right;
            var actual = _piece.GetSideByColor(Colors.Color.Blue).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceYellowSideIsOnTheBottom()
        {
            var expected = SidePositions.Position.Bottom;
            var actual = _piece.GetSideByColor(Colors.Color.Yellow).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceOrangeSideIsOnTheBack()
        {
            var expected = SidePositions.Position.Back;
            var actual = _piece.GetSideByColor(Colors.Color.Orange).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewPieceGreenSideIsOnTheLeft()
        {
            var expected = SidePositions.Position.Left;
            var actual = _piece.GetSideByColor(Colors.Color.Green).Position;
            Assert.AreEqual(expected, actual);
        }
		
		[TestMethod]
		public void PieceClockWiseXTurnWhiteSideIsOnTheBack()
		{
			var expected = SidePositions.Position.Back;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.White).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
        public void PieceClockWiseXTurnRedSideIsOnTheTop()
        {
            var expected = SidePositions.Position.Top;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
            var actual = _piece.GetSideByColor(Colors.Color.Red).Position;
            Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseXTurnBlueSideIsOnTheRight()
		{
			var expected = SidePositions.Position.Right;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Blue).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
        public void PieceClockWiseXTurnYellowSideIsOnTheFront()
        {
            var expected = SidePositions.Position.Front;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Yellow).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PieceClockWiseXTurnOrangeSideIsOnTheBottom()
        {
            var expected = SidePositions.Position.Bottom;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Orange).Position;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PieceClockWiseXTurnGreenSideIsOnTheLeft()
        {
            var expected = SidePositions.Position.Left;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Green).Position;
            Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnWhiteSideIsOnTheFront()
		{
			var expected = SidePositions.Position.Front;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.White).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnRedSideIsOnTheTopBottom()
		{
			var expected = SidePositions.Position.Bottom;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Red).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnBlueSideIsOnTheRight()
		{
			var expected = SidePositions.Position.Right;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Blue).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnYellowSideIsOnTheBack()
		{
			var expected = SidePositions.Position.Back;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Yellow).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnOrangeSideIsOnTheTop()
		{
			var expected = SidePositions.Position.Top;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Orange).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseXTurnGreenSideIsOnTheLeft()
		{
			var expected = SidePositions.Position.Left;
			_piece.TurnPiece(Axes.Axis.X, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Green).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnWhiteSideIsOnTheTop()
		{
			var expected = SidePositions.Position.Top;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.White).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnRedSideIsOnTheLeft()
		{
			var expected = SidePositions.Position.Left;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Red).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnBlueSideIsOnTheFront()
		{
			var expected = SidePositions.Position.Front;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Blue).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnYellowSideIsOnTheBottom()
		{
			var expected = SidePositions.Position.Bottom;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Yellow).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnOrangeSideIsOnTheRight()
		{
			var expected = SidePositions.Position.Right;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Orange).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseZTurnGreenSideIsOnTheBack()
		{
			var expected = SidePositions.Position.Back;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Green).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnWhiteSideIsOnTheTop()
		{
			var expected = SidePositions.Position.Top;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.White).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnRedSideIsOnTheTopRight()
		{
			var expected = SidePositions.Position.Right;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Red).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnBlueSideIsOnTheBack()
		{
			var expected = SidePositions.Position.Back;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Blue).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnYellowSideIsOnTheBottom()
		{
			var expected = SidePositions.Position.Bottom;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Yellow).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnOrangeSideIsOnTheLeft()
		{
			var expected = SidePositions.Position.Left;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Orange).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseZTurnGreenSideIsOnTheFront()
		{
			var expected = SidePositions.Position.Front;
			_piece.TurnPiece(Axes.Axis.Z, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Green).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnWhiteSideIsOnTheRight()
		{
			var expected = SidePositions.Position.Right;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.White).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnRedSideIsOnTheFront()
		{
			var expected = SidePositions.Position.Front;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Red).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnBlueSideIsOnTheBottom()
		{
			var expected = SidePositions.Position.Bottom;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Blue).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnYellowSideIsOnTheLeft()
		{
			var expected = SidePositions.Position.Left;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Yellow).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnOrangeSideIsOnTheBack()
		{
			var expected = SidePositions.Position.Back;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Orange).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceClockWiseYTurnGreenSideIsOnTheTop()
		{
			var expected = SidePositions.Position.Top;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.Clockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Green).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnWhiteSideIsOnTheLeft()
		{
			var expected = SidePositions.Position.Left;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.White).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnRedSideIsOnTheTopFront()
		{
			var expected = SidePositions.Position.Front;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Red).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnBlueSideIsOnTheTop()
		{
			var expected = SidePositions.Position.Top;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Blue).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnYellowSideIsOnTheRight()
		{
			var expected = SidePositions.Position.Right;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Yellow).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnOrangeSideIsOnTheBack()
		{
			var expected = SidePositions.Position.Back;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Orange).Position;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PieceCounterClockWiseYTurnGreenSideIsOnTheBottom()
		{
			var expected = SidePositions.Position.Bottom;
			_piece.TurnPiece(Axes.Axis.Y, Directions.Direction.CounterClockwise);
			var actual = _piece.GetSideByColor(Colors.Color.Green).Position;
			Assert.AreEqual(expected, actual);
		}
	}
}
