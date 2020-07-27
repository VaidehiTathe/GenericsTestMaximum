using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaximumUnitTest
    {
        [Test]
        public void GivenMaxNumber_WhenAtFirstPosition_ShouldReturnSameNummber()
        {
            Generics.TestMaximumUtility<int> testMax = new Generics.TestMaximumUtility<int>();
            int result = testMax.findMaximum(6, 5, 4);
            int expected = 6;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenMaxNumber_WhenAtSecondPosition_ShouldReturnSameNummber()
        {
            Generics.TestMaximumUtility<int> testMax = new Generics.TestMaximumUtility<int>();
            int result = testMax.findMaximum(5, 6, 4);
            int expected = 6;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenMaxNumber_WhenAtThirdPosition_ShouldReturnSameNummber()
        {
            Generics.TestMaximumUtility<int> testMax = new Generics.TestMaximumUtility<int>();
            int result = testMax.findMaximum(5, 4, 6);
            int expected = 6;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenFloatNumber_WhenAtFirstPosition_ShouldReturnSameNummber()
        {
            Generics.TestMaximumUtility<float> testMax = new Generics.TestMaximumUtility<float>();
            float result = testMax.findMaximum(6.0f, 5.1f, 2.1f);
            float expected = 6.0f;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenFloatNumber_WhenAtSecondPosition_ShouldReturnSameNummber()
        {
            Generics.TestMaximumUtility<float> testMax = new Generics.TestMaximumUtility<float>();
            float result = testMax.findMaximum(5.1f, 6.2f, 4.2f);
            float expected = 6.2f;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenFloatNumber_WhenAtThirdPosition_ShouldReturnSameNummber()
        {
            Generics.TestMaximumUtility<float> testMax = new Generics.TestMaximumUtility<float>();
            float result = testMax.findMaximum(5.1f, 4.2f, 6.1f);
            float expected = 6.1f;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenString_WhenAtFirstPosition_ShouldReturnSameString()
        {
            Generics.TestMaximumUtility<string> testMax = new Generics.TestMaximumUtility<string>();
            string result = testMax.findMaximum("Pineapple", "Apple", "Banana");
            string expected = "Pineapple";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenString_WhenAtSecondPosition_ShouldReturnSameString()
        {
            Generics.TestMaximumUtility<string> testMax = new Generics.TestMaximumUtility<string>();
            string result = testMax.findMaximum("Apple", "Pineapple", "Banana");
            string expected = "Pineapple";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenString_WhenAtThirdPosition_ShouldReturnSameString()
        {
            Generics.TestMaximumUtility<string> testMax = new Generics.TestMaximumUtility<string>();
            string result = testMax.findMaximum("Apple", "Banana", "Pineapple");
            string expected = "Pineapple";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenMultipleIntegerNumber_WhenAtFirstPosition_ShouldReturnSameNummber()
        {
            Generics.TestMaximumUtility<int> testMax = new Generics.TestMaximumUtility<int>();
            int result = testMax.findMaximum(6, 5, 4, 3, 2, 1);
            int expected = 6;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenMultipleFloatNumber_WhenAtFirstPosition_ShouldReturnSameNummber()
        {
            Generics.TestMaximumUtility<float> testMax = new Generics.TestMaximumUtility<float>();
            float result = testMax.findMaximum(6.0f, 5.1f, 2.1f, 1.1f, 1.2f);
            float expected = 6.0f;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenMultipleString_WhenAtFirstPosition_ShouldReturnSameString()
        {
            Generics.TestMaximumUtility<string> testMax = new Generics.TestMaximumUtility<string>();
            string result = testMax.findMaximum("Pineapple", "Apple", "Banana", "Mango");
            string expected = "Pineapple";
            Assert.AreEqual(expected, result);
        }
    }
}
