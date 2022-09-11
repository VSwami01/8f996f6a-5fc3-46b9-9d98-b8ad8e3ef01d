using LongestIncSubsequence.Services;

namespace LongestIncSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISequenceService sequenceService = new SequenceService();

            var result = sequenceService.GetLongestIncreasingSubSequence
                (new int[] {6, 2, 4, 6, 1, 5, 9, 12 });

            Console.WriteLine($"[{string.Join(", ", result)}]");

            Console.ReadLine();
        }
    }
}