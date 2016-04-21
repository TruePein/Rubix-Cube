using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

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
			Side refSide = _originalSide;
			_originalSide.Position = SidePositions.Position.Back;
			Assert.AreNotEqual(_originalSide.Position, _copySide.Position);
			Assert.AreEqual(_originalSide.Position, refSide.Position);
		}

		[TestMethod]
		public void ChangeCopyAndSidesAreDifferent()
		{
			Side refSide = _originalSide;
			_copySide.Position = SidePositions.Position.Back;
			Assert.AreNotEqual(_originalSide.Position, _copySide.Position);
			Assert.AreEqual(_originalSide.Position, refSide.Position);
		}
	}
}
