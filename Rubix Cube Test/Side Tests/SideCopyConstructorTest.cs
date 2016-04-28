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
	    private SideEqualityComparer _comparer;

		[TestInitialize]
		public void MakeSides()
		{
			_originalSide = new Side(ColorEnum.White, SidePositionEnum.Top);
			_copySide = new Side(_originalSide);
            _comparer = new SideEqualityComparer();
		}

		[TestMethod]
		public void NoChangesAndSidesAreTheSame()
		{
            Assert.IsTrue(_comparer.Equals(_originalSide, _copySide));
		}
    }
}
