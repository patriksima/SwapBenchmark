using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace SwapBenchmark
{

    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class Benchy
    {
        public static int A = 1;
        public static int B = 2;

        [Benchmark]
        public void TupleSwapBenchmark()
        {
            TupleSwap(ref A, ref B);
        }

        [Benchmark]
        public void TempSwapBenchmark()
        {
            TempSwap(ref A, ref B);
        }

        [Benchmark]
        public void XorSwapBenchmark()
        {
            XorSwap(ref A, ref B);
        }

        [Benchmark]
        public void ArithmeticSwapBenchmark()
        {
            ArithmeticSwap(ref A, ref B);
        }

        private static void TupleSwap(ref int x, ref int y)
        {
            (x, y) = (y, x);
        }


        private static void TempSwap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = x;
        }


        private static void XorSwap(ref int x, ref int y)
        {
            x = x ^ y;
            y = y ^ x;
            x = x ^ y;
        }


        private static void ArithmeticSwap(ref int x, ref int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
        }
    }
}