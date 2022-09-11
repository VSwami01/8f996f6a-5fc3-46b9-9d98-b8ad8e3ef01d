using LongestIncSubsequence.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LongestIncSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup Dependency Injection
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IProcessSequence, ProcessSequence>()
                .AddSingleton<ISequenceService, SequenceService>()
                .BuildServiceProvider();

            // Start processing sequence
            serviceProvider.GetService<IProcessSequence>().Start();

        }
    }
}