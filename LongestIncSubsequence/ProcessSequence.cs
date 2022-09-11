using LongestIncSubsequence.Services;

namespace LongestIncSubsequence
{
    /// <summary>
    /// Class to test Sequence service
    /// </summary>
    public interface IProcessSequence
    {
        int Start();
    }

    public class ProcessSequence : IProcessSequence
    {
        private readonly ISequenceService _sequenceService;
        public ProcessSequence(ISequenceService sequenceService)
        {
            _sequenceService = sequenceService;
        }

        public int Start()
        {
            string strSequence = "6 2 4 6 1 5 9 12";

            try
            {
                Console.WriteLine($"Enter string with numbers delimited by a space. Example: {strSequence}");

                strSequence = Console.ReadLine();

                if (string.IsNullOrEmpty(strSequence))
                    return 0;

                var result = _sequenceService.GetLongestIncreasingSubSequence<int>(strSequence);

                Console.WriteLine($"{string.Join(" ", result)}");

                Console.ReadLine();

                return 0;
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error: {exp.Message}");
                return -1;
            }
        }
    }
}
