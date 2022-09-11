using LongestIncSubsequence.Extentions;

namespace LongestIncSubsequence.Services
{
    public class SequenceService : ISequenceService
    {
        public string GetLongestIncreasingSubSequence<T>(string input) where T: IComparable, IConvertible
        {
            return string.Join(' ', GetLongestIncreasingSubSequence(input.ToArray<T>(' ')));
        }

        private T[] GetLongestIncreasingSubSequence<T>(T[] input) where T : IComparable
        {
            if (input.Length == 0)
                return input;

            int subSequenceStartIndex = 0;
            int subSequenceCount = 0;

            int maxSequenceStartIndex = 0;
            int maxSequenceCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 || input[i].CompareTo(input[i - 1]) == 1)
                {
                    subSequenceCount++;

                    if (subSequenceCount > maxSequenceCount)
                    {
                        maxSequenceStartIndex = subSequenceStartIndex;
                        maxSequenceCount = subSequenceCount;
                    }
                }
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
