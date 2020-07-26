using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaximumUnitTest
    {
        [Test]
        public void GivenMaxNumber_WhenAtFirstPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility<int> testMax = new Generics.TestMaximumUtility<int>();
            int maximumNumber = testMax.findMaximum(6, 5, 4, 3, 2, 1);
            Assert.AreEqual(6,maximumNumber);
        }

        [Test]
        public void GivenMaxNumber_WhenAtSecondPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility<int> testMax = new Generics.TestMaximumUtility<int>();
            int maximumNumber = testMax.findMaximum(5, 6, 4,3,2,1);
            Assert.AreEqual(6, maximumNumber);
        }

        [Test]
        public void GivenMaxNumber_WhenAtThirdPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility<int> testMax = new Generics.TestMaximumUtility<int>();
            int maximumNumber = testMax.findMaximum(5, 4, 6,3,2,1);
            Assert.AreEqual(6, maximumNumber);
        }

        [Test]
        public void GivenFloatNumber_WhenAtFirstPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility<float> testMax = new Generics.TestMaximumUtility<float>();
            float maximumNumber = testMax.findMaximum(6.0f, 5.1f, 2.1f,1.1f,1.2f);
            Assert.AreEqual(6.0f, maximumNumber);
        }

        [Test]
        public void GivenFloatNumber_WhenAtSecondPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility<float> testMax = new Generics.TestMaximumUtility<float>();
            float maximumNumber = testMax.findMaximum(5.1f, 6.2f, 4.2f,1.1f,2.1f);
            Assert.AreEqual(6.2f, maximumNumber);
        }

        [Test]
        public void GivenFloatNumber_WhenAtThirdPosition_ShouldReturnTrue()
        {
            Generics.TestMaximumUtility<float> testMax = new Generics.TestMaximumUtility<float>();
            float maximumNumber = testMax.findMaximum(5.1f, 4.2f, 6.1f,1.1f,1.2f,1.3f);
            Assert.AreEqual(6.1f, maximumNumber);
        }

        [Test]
        public void GivenString_WhenAtFirstPosition_ShouldReturnSameString()
        {
            Generics.TestMaximumUtility<string> testMax = new Generics.TestMaximumUtility<string>();
            string maximumString = testMax.findMaximum("Pineapple", "Apple", "Banana","Mango");
            Assert.AreEqual("Pineapple", maximumString);
        }

        [Test]
        public void GivenString_WhenAtSecondPosition_ShouldReturnSameString()
        {
            Generics.TestMaximumUtility<string> testMax = new Generics.TestMaximumUtility<string>();
            string maximumString = testMax.findMaximum("Apple", "Pineapple", "Banana","Mango");
            Assert.AreEqual("Pineapple", maximumString);
        }

        [Test]
        public void GivenString_WhenAtThirdPosition_ShouldReturnSameString()
        {
            Generics.TestMaximumUtility<string> testMax = new Generics.TestMaximumUtility<string>();
            string maximumString = testMax.findMaximum("Apple", "Banana", "Pineapple","Mango");
            Assert.AreEqual("Pineapple", maximumString);
        }
    }
}