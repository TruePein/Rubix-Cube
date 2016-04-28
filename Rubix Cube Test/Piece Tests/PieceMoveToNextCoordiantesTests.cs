using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Piece_Tests
{
    [TestClass]
    public class PieceMoveToNextCoordiantesTests
    {
        [TestMethod]
        public void XAxisCounterClockwiseTurnOfCornerPieceWillMoveFrom000To002()
        {
            var piece = getPiece(PieceTypeEnum.Corner);
            var expected = new Tuple<int, int, int>(0, 0, 2);
            piece.MoveToNextCoordinates(AxisEnum.X, DirectionEnum.CounterClockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void XAxisClockwiseTurnOfCornerPieceWillMoveFrom000To020()
        {
            var piece = getPiece(PieceTypeEnum.Corner);
            var expected = new Tuple<int, int, int>(0, 2, 0);
            piece.MoveToNextCoordinates(AxisEnum.X, DirectionEnum.Clockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YAxisClockwiseTurnOfCornerPieceWillMoveFrom000To002()
        {
            var piece = getPiece(PieceTypeEnum.Corner);
            var expected = new Tuple<int, int, int>(0, 0, 2);
            piece.MoveToNextCoordinates(AxisEnum.Y, DirectionEnum.Clockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YAxisCounterClockwiseTurnOfCornerPieceWillMoveFrom000To200()
        {
            var piece = getPiece(PieceTypeEnum.Corner);
            var expected = new Tuple<int, int, int>(2, 0, 0);
            piece.MoveToNextCoordinates(AxisEnum.Y, DirectionEnum.CounterClockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZAxisClockwiseTurnOfCornerPieceWillMoveFrom000To200()
        {
            var piece = getPiece(PieceTypeEnum.Corner);
            var expected = new Tuple<int, int, int>(2, 0, 0);
            piece.MoveToNextCoordinates(AxisEnum.Z, DirectionEnum.Clockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZAxisCounterClockwiseTurnOfCornerPieceWillMoveFrom000To020()
        {
            var piece = getPiece(PieceTypeEnum.Corner);
            var expected = new Tuple<int, int, int>(0, 2, 0);
            piece.MoveToNextCoordinates(AxisEnum.Z, DirectionEnum.CounterClockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void XAxisCounterClockwiseTurnOfEdgePieceWillMoveFrom100To102()
        {
            var piece = getPiece(PieceTypeEnum.Edge);
            var expected = new Tuple<int, int, int>(1, 0, 2);
            piece.MoveToNextCoordinates(AxisEnum.X, DirectionEnum.CounterClockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void XAxisClockwiseTurnOfEdgePieceWillMoveFrom100To120()
        {
            var piece = getPiece(PieceTypeEnum.Edge);
            var expected = new Tuple<int, int, int>(1, 2, 0);
            piece.MoveToNextCoordinates(AxisEnum.X, DirectionEnum.Clockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YAxisClockwiseTurnOfEdgePieceWillMoveFrom100To001()
        {
            var piece = getPiece(PieceTypeEnum.Edge);
            var expected = new Tuple<int, int, int>(0, 0, 1);
            piece.MoveToNextCoordinates(AxisEnum.Y, DirectionEnum.Clockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YAxisCounterClockwiseTurnOfEdgePieceWillMoveFrom100To201()
        {
            var piece = getPiece(PieceTypeEnum.Edge);
            var expected = new Tuple<int, int, int>(2, 0, 1);
            piece.MoveToNextCoordinates(AxisEnum.Y, DirectionEnum.CounterClockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZAxisClockwiseTurnOfEdgePieceWillMoveFrom100To210()
        {
            var piece = getPiece(PieceTypeEnum.Edge);
            var expected = new Tuple<int, int, int>(2, 1, 0);
            piece.MoveToNextCoordinates(AxisEnum.Z, DirectionEnum.Clockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZAxisCounterClockwiseTurnOfEdgePieceWillMoveFrom100To010()
        {
            var piece = getPiece(PieceTypeEnum.Edge);
            var expected = new Tuple<int, int, int>(0, 1, 0);
            piece.MoveToNextCoordinates(AxisEnum.Z, DirectionEnum.CounterClockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void XAxisCounterClockwiseTurnOfInnerPieceWillMoveFrom011To012()
        {
            var piece = getPiece(PieceTypeEnum.Inner);
            var expected = new Tuple<int, int, int>(0, 1, 2);
            piece.MoveToNextCoordinates(AxisEnum.X, DirectionEnum.CounterClockwise, 4);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void XAxisClockwiseTurnOfInnerPieceWillMoveFrom011To021()
        {
            var piece = getPiece(PieceTypeEnum.Inner);
            var expected = new Tuple<int, int, int>(0, 2, 1);
            piece.MoveToNextCoordinates(AxisEnum.X, DirectionEnum.Clockwise, 4);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YAxisClockwiseTurnOfInnerPieceWillMoveFrom011To113()
        {
            var piece = getPiece(PieceTypeEnum.Inner);
            var expected = new Tuple<int, int, int>(1, 1, 3);
            piece.MoveToNextCoordinates(AxisEnum.Y, DirectionEnum.Clockwise, 4);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YAxisCounterClockwiseTurnOfInnerPieceWillMoveFrom011To210()
        {
            var piece = getPiece(PieceTypeEnum.Inner);
            var expected = new Tuple<int, int, int>(2, 1, 0);
            piece.MoveToNextCoordinates(AxisEnum.Y, DirectionEnum.CounterClockwise, 4);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZAxisClockwiseTurnOfInnerPieceWillMoveFrom011To201()
        {
            var piece = getPiece(PieceTypeEnum.Inner);
            var expected = new Tuple<int, int, int>(2, 0, 1);
            piece.MoveToNextCoordinates(AxisEnum.Z, DirectionEnum.Clockwise, 4);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZAxisCounterClockwiseTurnOfInnerPieceWillMoveFrom011To131()
        {
            var piece = getPiece(PieceTypeEnum.Inner);
            var expected = new Tuple<int, int, int>(1, 3, 1);
            piece.MoveToNextCoordinates(AxisEnum.Z, DirectionEnum.CounterClockwise, 4);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void XAxisCounterClockwiseTurnOfMiddlePieceWillMoveFrom110To101()
        {
            var piece = getPiece(PieceTypeEnum.Middle);
            var expected = new Tuple<int, int, int>(1, 0, 1);
            piece.MoveToNextCoordinates(AxisEnum.X, DirectionEnum.CounterClockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void XAxisClockwiseTurnOfMiddlePieceWillMoveFrom110To121()
        {
            var piece = getPiece(PieceTypeEnum.Middle);
            var expected = new Tuple<int, int, int>(1, 2, 1);
            piece.MoveToNextCoordinates(AxisEnum.X, DirectionEnum.Clockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YAxisClockwiseTurnOfMiddlePieceWillMoveFrom110To011()
        {
            var piece = getPiece(PieceTypeEnum.Middle);
            var expected = new Tuple<int, int, int>(0, 1, 1);
            piece.MoveToNextCoordinates(AxisEnum.Y, DirectionEnum.Clockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YAxisCounterClockwiseTurnOfMiddlePieceWillMoveFrom110To211()
        {
            var piece = getPiece(PieceTypeEnum.Middle);
            var expected = new Tuple<int, int, int>(2, 1, 1);
            piece.MoveToNextCoordinates(AxisEnum.Y, DirectionEnum.CounterClockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZAxisClockwiseTurnOfMiddlePieceWillMoveFrom110To110()
        {
            var piece = getPiece(PieceTypeEnum.Middle);
            var expected = new Tuple<int, int, int>(1, 1, 0);
            piece.MoveToNextCoordinates(AxisEnum.Z, DirectionEnum.Clockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZAxisCounterClockwiseTurnOfMiddlePieceWillMoveFrom110To110()
        {
            var piece = getPiece(PieceTypeEnum.Middle);
            var expected = new Tuple<int, int, int>(1, 1, 0);
            piece.MoveToNextCoordinates(AxisEnum.Z, DirectionEnum.CounterClockwise, 3);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void XAxisCounterClockwiseTurnOfUnseenPieceWillMoveFrom111To112()
        {
            var piece = getPiece(PieceTypeEnum.Unseen);
            var expected = new Tuple<int, int, int>(1, 1, 2);
            piece.MoveToNextCoordinates(AxisEnum.X, DirectionEnum.CounterClockwise, 4);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void XAxisClockwiseTurnOfUnseenPieceWillMoveFrom111To121()
        {
            var piece = getPiece(PieceTypeEnum.Unseen);
            var expected = new Tuple<int, int, int>(1, 2, 1);
            piece.MoveToNextCoordinates(AxisEnum.X, DirectionEnum.Clockwise, 4);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YAxisClockwiseTurnOfUnseenPieceWillMoveFrom111To112()
        {
            var piece = getPiece(PieceTypeEnum.Unseen);
            var expected = new Tuple<int, int, int>(1, 1, 2);
            piece.MoveToNextCoordinates(AxisEnum.Y, DirectionEnum.Clockwise, 4);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YAxisCounterClockwiseTurnOfUnseenPieceWillMoveFrom111To211()
        {
            var piece = getPiece(PieceTypeEnum.Unseen);
            var expected = new Tuple<int, int, int>(2, 1, 1);
            piece.MoveToNextCoordinates(AxisEnum.Y, DirectionEnum.CounterClockwise, 4);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZAxisClockwiseTurnOfUnseenPieceWillMoveFrom111To211()
        {
            var piece = getPiece(PieceTypeEnum.Unseen);
            var expected = new Tuple<int, int, int>(2, 1, 1);
            piece.MoveToNextCoordinates(AxisEnum.Z, DirectionEnum.Clockwise, 4);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZAxisCounterClockwiseTurnOfUnseenPieceWillMoveFrom111To121()
        {
            var piece = getPiece(PieceTypeEnum.Unseen);
            var expected = new Tuple<int, int, int>(1, 2, 1);
            piece.MoveToNextCoordinates(AxisEnum.Z, DirectionEnum.CounterClockwise, 4);
            var actual = piece.Coordinates;
            Assert.AreEqual(expected, actual);
        }

        private IPiece getPiece(PieceTypeEnum typeEnumOfPiece, int sizeOfCube = 3)
        {
            switch (typeEnumOfPiece)
            {
                case PieceTypeEnum.Corner:
                    {
                        return new CornerPiece(0, 0, 0);
                    }
                case PieceTypeEnum.Edge:
                    {
                        return new EdgePiece(1, 0, 0);
                    }
                case PieceTypeEnum.Inner:
                    {
                        return new InnerPiece(0, 1, 1, ColorEnum.Green);
                    }
                case PieceTypeEnum.Middle:
                    {
                        var mid = sizeOfCube / 2;
                        return PieceFactory.GetPiece(mid, mid, 0, 3);
                    }
                default:
                    {
                        return new UnseenPiece(1, 1, 1);
                    }
            }
        }
    }
}
