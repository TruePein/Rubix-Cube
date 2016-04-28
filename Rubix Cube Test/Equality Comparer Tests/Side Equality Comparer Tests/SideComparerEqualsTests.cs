using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Enums;
using Rubix_Cube.IEqualityComparers;
using Rubix_Cube.Pieces;
// ReSharper disable ReturnValueOfPureMethodIsNotUsed

namespace Rubix_Cube_Test.Equality_Comparer_Tests.Side_Equality_Comparer_Tests
{
    [TestClass]
    public class SideComparerEqualsTests
    {
        static SideEqualityComparer _comparer;
        private Side _side;

        [ClassInitialize]
        public static void CreateComparer(TestContext context)
        {
            _comparer = new SideEqualityComparer();
        }

        [TestInitialize]
        public void CreateSide()
        {
            _side = new Side(ColorEnum.White, SidePositionEnum.Top);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingASideToItselfThrowsAnError()
        {
            _comparer.Equals(_side, _side);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ComparingASideToASameReferenceThrowsAnError()
        {
            var copy = _side;
            _comparer.Equals(_side, copy);
        }

        [TestMethod]
        public void ComparingASideToItsCopyReturnsTrue()
        {
            var copy = new Side(_side);
            Assert.IsTrue(_comparer.Equals(_side, copy));
        }

        [TestMethod]
        public void ComparingASideToAnotherThatWasCreatedTheSameWayReturnsTrue()
        {
            var other = new Side(ColorEnum.White, SidePositionEnum.Top);
            Assert.IsTrue(_comparer.Equals(_side, other));
        }

        [TestMethod]
        public void CaomparingASideWithAnotherWithADifferentColorReturnsFalse()
        {
            var other = new Side(ColorEnum.Red, SidePositionEnum.Top);
            Assert.IsFalse(_comparer.Equals(_side, other));
        }

        [TestMethod]
        public void CaomparingASideWithAnotherWithADifferentPositionReturnsFalse()
        {
            var other = new Side(ColorEnum.White, SidePositionEnum.Front);
            Assert.IsFalse(_comparer.Equals(_side, other));
        }
    }
}
