namespace LongestIncSubsequence.Services
{
    public interface ISequenceService
    {
        string GetLongestIncreasingSubSequence<T>(string input) where T : IComparable, IConvertible;
    }
}
