using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaximumUnitTest
    {
        [Test]
        public void GivenMaxNumber_WhenAtFirstPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility<int> testMax = new Generics.TestMaximumUtility<int>(6, 5, 4);
            int maximumNumber = testMax.findMaximum();
            Assert.AreEqual(6,maximumNumber);
        }

        [Test]
        public void GivenMaxNumber_WhenAtSecondPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility<int> testMax = new Generics.TestMaximumUtility<int>(5,6,4);
            int maximumNumber = testMax.findMaximum();
            Assert.AreEqual(6, maximumNumber);
        }

        [Test]
        public void GivenMaxNumber_WhenAtThirdPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility<int> testMax = new Generics.TestMaximumUtility<int>(5, 4, 6);
            int maximumNumber = testMax.findMaximum();
            Assert.AreEqual(6, maximumNumber);
        }

        [Test]
        public void GivenFloatNumber_WhenAtFirstPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility<float> testMax = new Generics.TestMaximumUtility<float>(6.0f, 5.1f, 2.1f);
            float maximumNumber = testMax.findMaximum();
            Assert.AreEqual(6.0f, maximumNumber);
        }

        [Test]
        public void GivenFloatNumber_WhenAtSecondPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility<float> testMax = new Generics.TestMaximumUtility<float>(5.1f, 6.2f, 4.2f);
            float maximumNumber = testMax.findMaximum();
            Assert.AreEqual(6.2f, maximumNumber);
        }

        [Test]
        public void GivenFloatNumber_WhenAtThirdPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility<float> testMax = new Generics.TestMaximumUtility<float>(5.1f, 4.2f, 6.1f);
            float maximumNumber = testMax.findMaximum();
            Assert.AreEqual(6.1f, maximumNumber);
        }

        [Test]
        public void GivenString_WhenAtFirstPosition_ShouldReturnSameString()
        {
            Generics.TestMaximumUtility<string> testMax = new Generics.TestMaximumUtility<string>("Pineapple","Apple", "Banana");
            string maximumString = testMax.findMaximum();
            Assert.AreEqual("Pineapple", maximumString);
        }

        [Test]
        public void GivenString_WhenAtSecondPosition_ShouldReturnSameString()
        {
            Generics.TestMaximumUtility<string> testMax = new Generics.TestMaximumUtility<string>("Apple", "Pineapple", "Banana");
            string maximumString = testMax.findMaximum();
            Assert.AreEqual("Pineapple", maximumString);
        }

        [Test]
        public void GivenString_WhenAtThirdPosition_ShouldReturnSameString()
        {
            Generics.TestMaximumUtility<string> testMax = new Generics.TestMaximumUtility<string>("Apple", "Banana", "Pineapple");
            string maximumString = testMax.findMaximum();
            Assert.AreEqual("Pineapple", maximumString);
        }
    }
}