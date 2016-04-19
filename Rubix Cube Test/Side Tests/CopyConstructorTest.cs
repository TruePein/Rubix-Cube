using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;
using Rubix_Cube.Enums;

namespace Rubix_Cube_Test.Side_Tests
{
	[TestClass]
	public class CopyConstructorTest
	{
		private Side originalSide;
		private Side copySide;

		[TestInitialize]
		public void MakeSides()
		{
			originalSide = new Side(0);
			copySide = new Side(originalSide);
		}

		[TestMethod]
		public void NoChangesAndSidesAreTheSame()
		{
			Assert.AreEqual(originalSide.Position, copySide.Position);
		}

		[TestMethod]
		public void ChangeOriginalAndSidesAreDifferent()
		{
			Side refSide = originalSide;
			originalSide.Position = SidePositions.Position.Back;
			Assert.AreNotEqual(originalSide.Position, copySide.Position);
			Assert.AreEqual(originalSide.Position, refSide.Position);
		}

		[TestMethod]
		public void ChangeCopyAndSidesAreDifferent()
		{
			Side refSide = originalSide;
			copySide.Position = SidePositions.Position.Back;
			Assert.AreNotEqual(originalSide.Position, copySide.Position);
			Assert.AreEqual(originalSide.Position, refSide.Position);
		}
	}
}
