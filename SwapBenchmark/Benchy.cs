using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace SwapBenchmark
{

    [MemoryDiagnoser]
    //[SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class Benchy
    {
        public static int A = 1;
        public static int B = 2;
        public static int C = 1;
        public static int D = 2;

        [Benchmark]
        public void TupleSwapBenchmark()
        {
            TupleSwap(ref A, ref B);
        }

        [Benchmark]
        public void TempSwapBenchmark()
        {
            TempSwap(ref C, ref D);
        }
/*
        [Benchmark]
        public void XorSwapBenchmark()
        {
            XorSwap(ref A, ref B);
        }

        [Benchmark]
        public void ArithmeticSwapBenchmark()
        {
            ArithmeticSwap(ref A, ref B);
        }*/

        private void TupleSwap(ref int x, ref int y)
        {
            (x, y) = (y, x);
        }

        private void TempSwap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = x;
        }


        private void XorSwap(ref int x, ref int y)
        {
            x = x ^ y;
            y = y ^ x;
            x = x ^ y;
        }


        private void ArithmeticSwap(ref int x, ref int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
        }
    }
}