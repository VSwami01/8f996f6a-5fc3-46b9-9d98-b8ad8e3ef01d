using LongestIncSubsequence.Extentions;

namespace UnitTest
{
    public class TestStringExtention
    {
        #region Test ToIntArray

        /// <summary>
        /// For string of numbers delimited by white spaces, get int array
        /// </summary>
        [Test]
        public void ToIntArray_StringOfNumbersDelimitedByWhiteSpaces_ReturnsIntArray()
        {
            // Arrange
            string input = "6 1 5 9 2";
            char delimiter = ' ';
            int[] expected = new int[] { 6, 1, 5, 9, 2 };

            // Act
            int[] actual = input.ToIntArray(delimiter);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        /// <summary>
        /// For string of single number, get int array with one element
        /// </summary>
        [Test]
        public void ToIntArray_StringOfSingleNumber_ReturnsIntArrayWithOneNumber()
        {
            // Arrange
            string input = "6";
            char delimiter = ' ';
            int[] expected = new int[] { 6 };

            // Act
            int[] actual = input.ToIntArray(delimiter);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        /// <summary>
        /// For empty string, throws FormatException
        /// </summary>
        [Test]
        public void ToIntArray_EmptyString_ThrowsFormatException()
        {
            // Arrange
            string input = String.Empty;
            char delimiter = ' ';

            // Act
            var fn = () => input.ToIntArray(delimiter);

            // Assert
            Assert.Throws<FormatException>(() => fn());
        }

        /// <summary>
        /// For empty string, throws NullReferenceException
        /// </summary>
        [Test]
        public void ToIntArray_NullString_ThrowsNullReferenceException()
        {
            // Arrange
            string? input = null;
            char delimiter = ' ';

            // Act
            var fn = () => input.ToIntArray(delimiter);

            // Assert
            Assert.Throws<NullReferenceException>(() => fn());
        }

        /// <summary>
        /// For string delimited by non space, throws FormatException
        /// </summary>
        [Test]
        public void ToIntArray_StringDelimitedByNonSpace_ThrowsFormatException()
        {
            // Arrange
            string input = "6?23";
            char delimiter = ' ';

            // Act
            var fn = () => input.ToIntArray(delimiter);

            // Assert
            Assert.Throws<FormatException>(() => fn());
        }

        /// <summary>
        /// For string delimited by non space, throws FormatException
        /// </summary>
        [Test]
        public void ToIntArray_StringDelimitedByMultipleSpaces_ThrowsFormatException()
        {
            // Arrange
            string input = "6   23";
            char delimiter = ' ';

            // Act
            var fn = () => input.ToIntArray(delimiter);

            // Assert
            Assert.Throws<FormatException>(() => fn());
        }

        #endregion

        #region Test ToArray

        /// <summary>
        /// For string with double, returns array of double
        /// </summary>
        [Test]
        public void ToArray_StringWithDouble_ReturnsDoubleArray()
        {
            // Arrange
            string input = "6.23 23.5";
            char delimiter = ' ';
            double[] expected = new double[] { 6.23, 23.5 };

            // Act
            double[] actual = input.ToArray<double>(delimiter);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        #endregion
    }
}
