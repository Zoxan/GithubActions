using NUnit.Framework;
using Demo;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(2, Program.Sum(1, 1));
        }
    }
}