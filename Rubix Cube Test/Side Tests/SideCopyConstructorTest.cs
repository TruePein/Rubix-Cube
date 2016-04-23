using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;
using Rubix_Cube.IEqualityComparers;

namespace Rubix_Cube_Test.Side_Tests
{
	[TestClass]
	public class SideCopyConstructorTest
	{
		private Side _originalSide;
		private Side _copySide;

		[TestInitialize]
		public void MakeSides()
		{
			_originalSide = new Side(Colors.Color.White, SidePositions.Position.Top);
			_copySide = new Side(_originalSide);
		}

		[TestMethod]
		public void NoChangesAndSidesAreTheSame()
		{
			Assert.AreEqual(_originalSide.Position, _copySide.Position);
		}

		[TestMethod]
		public void ChangeOriginalAndSidesAreDifferent()
		{
			var refSide = _originalSide;
			_originalSide.MoveToNextPosition(Axes.Axis.X, Directions.Direction.Clockwise);
			Assert.AreNotEqual(_originalSide.Position, _copySide.Position);
			Assert.AreEqual(_originalSide.Position, refSide.Position);
		}

		[TestMethod]
		public void ChangeCopyAndSidesAreDifferent()
		{
			var refSide = _originalSide;
			_copySide.MoveToNextPosition(Axes.Axis.X, Directions.Direction.Clockwise);
			Assert.AreNotEqual(_originalSide.Position, _copySide.Position);
			Assert.AreEqual(_originalSide.Position, refSide.Position);
		}

	    [TestMethod]
	    public void CopySideIsADuplicateOfTheOriginal()
	    {
	        var sideComparer = new SideEqualityComparer();
            Assert.IsTrue(sideComparer.Equals(_originalSide, _copySide));
	    }

	    [TestMethod]
	    public void AChangedCopySideIsNoLongerADuplicate()
	    {
	        _copySide.MoveToNextPosition(0, Directions.Direction.Clockwise);
            var sideComparer = new SideEqualityComparer();
            Assert.IsFalse(sideComparer.Equals(_originalSide, _copySide));
        }

        [TestMethod]
        public void AChangedOriginalSideAfterCopyIsNoLongerADuplicate()
        {
            _originalSide.MoveToNextPosition(0, Directions.Direction.Clockwise);
            var sideComparer = new SideEqualityComparer();
            Assert.IsFalse(sideComparer.Equals(_originalSide, _copySide));
        }
    }
}
