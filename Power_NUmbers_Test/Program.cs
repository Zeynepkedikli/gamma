using NUnit.Framework;

namespace PowerTests
{
    [TestFixture]
    public class TestPowerFunction
    {
        [Test]
        public void Test1()
        {
            // 2^3 = 8
            Assert.AreEqual(8, Lib2.Power(2, 3));
        }

        [Test]
        public void Test2()
        {
            // 5^2 = 25
            Assert.AreEqual(25, Lib2.Power(5, 2));
        }

        [Test]
        public void Test3()
        {
            // 10^0 = 1
            Assert.AreEqual(1, Lib2.Power(10, 0));
        }

        [Test]
        public void Test4()
        {
            // 3^4 = 81
            Assert.AreEqual(81, Lib2.Power(3, 4));
        }

        [Test]
        public void Test5()
        {
            // 1^100 = 1
            Assert.AreEqual(1, Lib2.Power(1, 100));
        }
    }
}