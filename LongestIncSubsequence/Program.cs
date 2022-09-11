using LongestIncSubsequence.Extentions;
using LongestIncSubsequence.Services;

namespace LongestIncSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISequenceService sequenceService = new SequenceService();

            string strSequence = "6 2 4 6 1 5 9 12";

            int[] intSequence = strSequence.ToIntArray(' ');

            var result = sequenceService.GetLongestIncreasingSubSequence(intSequence);

            Console.WriteLine($"[{string.Join(", ", result)}]");

            Console.ReadLine();
        }
    }
}