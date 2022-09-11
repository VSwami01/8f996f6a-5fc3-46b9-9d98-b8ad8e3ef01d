namespace LongestIncSubsequence.Extentions
{
    public static class StringExtention
    {
        //
        // Summary:
        //     Converts a string to an array using a delimeter.
        //
        // Parameters:
        //   string:
        //     String having delimited values to convert to an array of provided type.
        //
        // Returns:
        //     An array of provided type from the source string.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     string is null.
        //   T:System.FormatException:
        //     string not in correct format.
        //   T:System.InvalidCastException:
        //     conversion not supported.
        public static T[] ToArray<T>(this string input, char delimiter) where T : IConvertible
        {
            var inputNumString = input.Split(delimiter);

            return Array.ConvertAll(inputNumString, (inputStr) =>
            {
                return (T)Convert.ChangeType(inputStr, typeof(T));
            });
        }
    }
}
