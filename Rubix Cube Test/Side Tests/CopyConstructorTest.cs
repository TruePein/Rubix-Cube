using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubix_Cube.Pieces;

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
			Assert.AreEqual(originalSide.SidePosition, copySide.SidePosition);
		}

		[TestMethod]
		public void ChangeOriginalAndSidesAreDifferent()
		{
			Side refSide = originalSide;
			originalSide.SidePosition = Side.Position.Back;
			Assert.AreNotEqual(originalSide.SidePosition, copySide.SidePosition);
			Assert.AreEqual(originalSide.SidePosition, refSide.SidePosition);
		}

		[TestMethod]
		public void ChangeCopyAndSidesAreDifferent()
		{
			Side refSide = originalSide;
			copySide.SidePosition = Side.Position.Back;
			Assert.AreNotEqual(originalSide.SidePosition, copySide.SidePosition);
			Assert.AreEqual(originalSide.SidePosition, refSide.SidePosition);
		}
	}
}
