using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaximumUnitTest
    {
        [Test]
        public void GivenMaxNumber_WhenAtFirstPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility testMax = new Generics.TestMaximumUtility();
            int maximumNumber = testMax.findMaximum(6, 5, 4);
            Assert.AreEqual(6,maximumNumber);
        }

        [Test]
        public void GivenMaxNumber_WhenAtSecondPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility testMax = new Generics.TestMaximumUtility();
            int maximumNumber = testMax.findMaximum(5, 6, 4);
            Assert.AreEqual(6, maximumNumber);
        }

        [Test]
        public void GivenMaxNumber_WhenAtThirdPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility testMax = new Generics.TestMaximumUtility();
            int maximumNumber = testMax.findMaximum(5, 4, 6);
            Assert.AreEqual(6, maximumNumber);
        }
    }
}