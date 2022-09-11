using LongestIncSubsequence.Extentions;

namespace UnitTest
{
    public class TestStringExtention
    {
        #region Test ToArray wit integers

        /// <summary>
        /// For string of numbers delimited by white spaces, get int array
        /// </summary>
        [Test]
        public void ToArray_StringOfNumbersDelimitedByWhiteSpaces_ReturnsIntArray()
        {
            // Arrange
            string input = "6 1 5 9 2";
            int[] expected = new int[] { 6, 1, 5, 9, 2 };

            // Act
            int[] actual = input.ToArray<int>();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        /// <summary>
        /// For string of single number, get int array with one element
        /// </summary>
        [Test]
        public void ToArray_StringOfSingleNumber_ReturnsIntArrayWithOneNumber()
        {
            // Arrange
            string input = "6";
            int[] expected = new int[] { 6 };

            // Act
            int[] actual = input.ToArray<int>();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        /// <summary>
        /// For empty string, throws FormatException
        /// </summary>
        [Test]
        public void ToArray_EmptyString_ThrowsFormatException()
        {
            // Arrange
            string input = String.Empty;

            // Act
            var fn = () => input.ToArray<int>();

            // Assert
            Assert.Throws<FormatException>(() => fn());
        }

        /// <summary>
        /// For empty string, throws NullReferenceException
        /// </summary>
        [Test]
        public void ToArray_NullString_ThrowsNullReferenceException()
        {
            // Arrange
            string input = null;

            // Act
            var fn = () => input.ToArray<int>();

            // Assert
            Assert.Throws<NullReferenceException>(() => fn());
        }

        /// <summary>
        /// For string delimited by non space, throws FormatException
        /// </summary>
        [Test]
        public void ToArray_StringDelimitedByNonSpace_ThrowsFormatException()
        {
            // Arrange
            string input = "6?23";

            // Act
            var fn = () => input.ToArray<int>();

            // Assert
            Assert.Throws<FormatException>(() => fn());
        }

        /// <summary>
        /// For string delimited by non space, throws FormatException
        /// </summary>
        [Test]
        public void ToArray_StringDelimitedByMultipleSpaces_ThrowsFormatException()
        {
            // Arrange
            string input = "6   23";

            // Act
            var fn = () => input.ToArray<int>();

            // Assert
            Assert.Throws<FormatException>(() => fn());
        }

        #endregion

        #region Test ToArray with double

        /// <summary>
        /// For string with double, returns array of double
        /// </summary>
        [Test]
        public void ToArray_StringWithDouble_ReturnsDoubleArray()
        {
            // Arrange
            string input = "6.23 23.5";
            double[] expected = new double[] { 6.23, 23.5 };

            // Act
            double[] actual = input.ToArray<double>();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        #endregion
    }
}
