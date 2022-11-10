using BenchmarkDotNet.Running;

namespace SwapBenchmark
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchy>();
        }
    }
}