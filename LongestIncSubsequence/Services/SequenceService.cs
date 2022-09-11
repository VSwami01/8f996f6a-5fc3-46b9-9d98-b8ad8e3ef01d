using LongestIncSubsequence.Extentions;

namespace LongestIncSubsequence.Services
{
    public class SequenceService : ISequenceService
    {
        //
        // Summary:
        //     Accepts a string of numbers seperated by white spaces and returns longest increasing subsequence.
        //
        // Parameters:
        //   string:
        //     String having delimited values that can be compared.
        //
        // Returns:
        //     A string of longest increasing subsequence separated by white space
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     string is null.
        //   T:System.ArgumentNullException:
        //     string is null.
        //   T:System.FormatException:
        //     string not in correct format.
        //   T:System.InvalidCastException:
        //     conversion not supported.
        public string GetLongestIncreasingSubSequence<T>(string input) where T: IComparable, IConvertible
        {
            if(string.IsNullOrEmpty(input))
                return string.Empty;

            return string.Join(' ', GetLongestIncreasingSubSequence(input.ToArray<T>()));
        }

        private T[] GetLongestIncreasingSubSequence<T>(T[] input) where T : IComparable
        {
            if (input.Length == 0)
                return input;

            // variables to track current sub sequence
            int subSequenceStartIndex = 0;
            int subSequenceCount = 0;

            // variables to store details of longest increasing sub sequence
            int maxSequenceStartIndex = 0;
            int maxSequenceCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                // if it is start of the loop or current value is greater than previous one
                if (i == 0 || input[i].CompareTo(input[i - 1]) == 1)
                {
                    subSequenceCount++;

                    // if curerent subsequence is greater than a prviously found max sequence
                    // then we have a new winner. Store the startIndex and length of this new sequence
                    if (subSequenceCount > maxSequenceCount)
                    {
                        maxSequenceStartIndex = subSequenceStartIndex;
                        maxSequenceCount = subSequenceCount;
                    }
                }
                // if current value is NOT greater than previous one, we start a new sub sequence
                else
                {
                    subSequenceStartIndex = i;
                    subSequenceCount = 1;
                }
            }

            return input[maxSequenceStartIndex..(maxSequenceStartIndex + maxSequenceCount)];
        }

    }
}
