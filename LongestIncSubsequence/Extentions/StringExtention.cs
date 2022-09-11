using System.Text.RegularExpressions;

namespace LongestIncSubsequence.Extentions
{
    public static class StringExtention
    {
        //
        // Summary:
        //     Converts a string to integer array using a delimeter.
        //
        // Parameters:
        //   string:
        //     String having numbers to convert to an integer array.
        //
        // Returns:
        //     An array of integer type containing numbers from the source string.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     string is null.

        public static int[] ToIntArray(this string input, char delimiter)
        {
            var inputNumString = input.Split(delimiter);

            return Array.ConvertAll(inputNumString, int.Parse);
        }
    }
}
