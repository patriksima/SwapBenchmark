using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace SwapBenchmark;

[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net90)]
public class Benchy
{
    private int a, b;

    [GlobalSetup(Target = nameof(TupleSwapBenchmark))]
    public void SetupTuple() => (a, b) = (1, 2);

    [Benchmark]
    public (int, int) TupleSwapBenchmark()
    {
        TupleSwap(ref a, ref b);
        return (a, b);
    }

    [GlobalSetup(Target = nameof(TempSwapBenchmark))]
    public void SetupTemp() => (a, b) = (1, 2);

    [Benchmark]
    public (int, int) TempSwapBenchmark()
    {
        TempSwap(ref a, ref b);
        return (a, b);
    }

    [GlobalSetup(Target = nameof(XorSwapBenchmark))]
    public void SetupXor() => (a, b) = (1, 2);

    [Benchmark]
    public (int, int) XorSwapBenchmark()
    {
        XorSwap(ref a, ref b);
        return (a, b);
    }

    [GlobalSetup(Target = nameof(ArithmeticSwapBenchmark))]
    public void SetupArithmetic() => (a, b) = (1, 2);

    [Benchmark]
    public (int, int) ArithmeticSwapBenchmark()
    {
        ArithmeticSwap(ref a, ref b);
        return (a, b);
    }

    private void TupleSwap(ref int x, ref int y)
    {
        (x, y) = (y, x);
    }

    private void TempSwap(ref int x, ref int y)
    {
        var t = x;
        x = y;
        y = t;
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