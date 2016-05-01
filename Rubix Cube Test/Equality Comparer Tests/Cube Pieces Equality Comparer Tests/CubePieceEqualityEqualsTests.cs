using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube;
using Rubix_Cube.Enums;
using Rubix_Cube.IEqualityComparers;

namespace Rubix_Cube_Test.Equality_Comparer_Tests.Cube_Pieces_Equality_Comparer_Tests
{
    [TestClass]
    public class CubePieceEqualityEqualsTests
    {
        private static CubePiecesEqualityComparer _comparer;

        private Cube _original;

        [ClassInitialize]
        public static void CreateComparer(TestContext context)
        {
            _comparer = new CubePiecesEqualityComparer();
        }

        [TestInitialize]
        public void CreateCube()
        {
            _original = new Cube();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingACubeAgainstItselfThrowsAnError()
        {
            Assert.IsTrue(_comparer.Equals(_original, _original));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingACubeAgainstAReferenceToItselfThrowsAnError()
        {
            var same = _original;
            Assert.IsTrue(_comparer.Equals(_original, same));
        }

        [TestMethod]
        public void ComparingACubeAgainstACopyOfItselfReturnsTrue()
        {
            var copy = new Cube(_original);
            Assert.IsTrue(_comparer.Equals(_original, copy));
        }

        [TestMethod]
        public void ComparingCubeAgainstCopyWithOneSideTurnedReturnsFalse()
        {
            var copy = new Cube(_original);
            copy.MakeMove(AxisEnum.X, 0, DirectionEnum.Clockwise);
            Assert.IsFalse(_comparer.Equals(_original, copy));
        }

        [TestMethod]
        public void ComparingCubeAgainstCopyWithAllSidesTurnedReturnsTrue()
        {
            var copy = new Cube(_original);
            copy.MakeMove(AxisEnum.X, 0, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.X, 1, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.Clockwise);
            Assert.IsTrue(_comparer.Equals(_original, copy));
        }

        [TestMethod]
        public void ComparingCubeAgainstCopySoThatOnlyMiddleIsTurnedReturnsTrue()
        {
            var copy = new Cube(_original);
            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.CounterClockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.CounterClockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);

            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.CounterClockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.CounterClockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);

            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.CounterClockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.CounterClockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.Clockwise);
            Assert.IsTrue(_comparer.Equals(_original, copy));
        }

        [TestMethod]
        public void ComparingCubeAgainstFlowerReturnsFalse()
        {
            var copy  = new Cube(_original);
            copy.MakeMove(AxisEnum.X, 0, DirectionEnum.CounterClockwise);
            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.CounterClockwise);
            copy.MakeMove(AxisEnum.Y, 0, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Y, 2, DirectionEnum.Clockwise);
            copy.MakeMove(AxisEnum.Z, 0, DirectionEnum.CounterClockwise);
            copy.MakeMove(AxisEnum.Z, 2, DirectionEnum.CounterClockwise);
            copy.MakeMove(AxisEnum.X, 0, DirectionEnum.CounterClockwise);
            copy.MakeMove(AxisEnum.X, 2, DirectionEnum.CounterClockwise);

            Assert.IsFalse(_comparer.Equals(_original, copy));
        }
    }
}
