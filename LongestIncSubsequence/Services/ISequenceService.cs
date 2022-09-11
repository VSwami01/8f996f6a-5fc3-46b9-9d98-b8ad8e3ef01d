namespace LongestIncSubsequence.Services
{
    public interface ISequenceService
    {
        string GetLongestIncreasingSubSequence(string input);
        int[] GetLongestIncreasingSubSequence(int[] input);
    }
}
