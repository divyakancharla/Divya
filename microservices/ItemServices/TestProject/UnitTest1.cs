using NUnit.Framework;

namespace TestProject
{


    public class Tests
    {
        Calculate ob = null;
        [SetUp]
        public void Setup()
        {
             ob = new Calculate();
        }

        [Test]
        public void Test1()
        {
            int actual = ob.Add(5, 3);
            int expected = 8;
            Assert.AreEqual(expected, actual);


            Assert.Pass();
        }
    }
}