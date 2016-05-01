using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rubix_Cube_Test.Cube_Tests
{
    [TestClass]
    public class ScrambleTests
    {
        private static Random _r;

        [ClassInitialize]
        public static void CreateRandom(TestContext context)
        {
            _r = new Random();
        }

        [TestMethod]
        public void OneThousandRandomsAreRelativelyEvenlyDistributed()
        {
            var xCount = 0;
            var yCount = 0;
            var zCount = 0;
            var layer0Count = 0;
            var layer1Count = 0;
            var layer2Count = 0;
            var clockwiseCount = 0;
            var counterclockwiseCount = 0;

            for (var i = 0; i < 1000; i++)
            {
                var axis = _r.Next(3);
                switch (axis)
                {
                    case 0:
                        xCount++;
                        break;
                    case 1:
                        yCount++;
                        break;
                    case 2:
                        zCount++;
                        break;
                }

                var layer = _r.Next(3);
                switch (layer)
                {
                    case 0:
                        layer0Count++;
                        break;
                    case 1:
                        layer1Count++;
                        break;
                    case 2:
                        layer2Count++;
                        break;
                }

                var direction = _r.Next(2);
                switch (direction)
                {
                    case 0:
                        clockwiseCount++;
                        break;
                    case 1:
                        counterclockwiseCount++;
                        break;
                }
            }

            var allowedDifference = 100;
            Assert.IsTrue(allowedDifference >= Math.Abs(xCount - yCount));
            Assert.IsTrue(allowedDifference >= Math.Abs(yCount - zCount));
            Assert.IsTrue(allowedDifference >= Math.Abs(zCount - xCount));
            Assert.IsTrue(allowedDifference >= Math.Abs(layer0Count - layer1Count));
            Assert.IsTrue(allowedDifference >= Math.Abs(layer1Count - layer2Count));
            Assert.IsTrue(allowedDifference >= Math.Abs(layer2Count - layer0Count));
            Assert.IsTrue(allowedDifference >= Math.Abs(clockwiseCount - counterclockwiseCount));
        }
    }
}
