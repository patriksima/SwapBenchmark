# Swap Benchmark

This project benchmarks different integer swapping techniques in C# using [BenchmarkDotNet](https://benchmarkdotnet.org/).

## Benchmarked Methods

- **Tuple Swap**: `(x, y) = (y, x);`
- **Temporary Variable Swap**: `var t = x; x = y; y = t;`
- **XOR Swap**: Bitwise XOR swapping
- **Arithmetic Swap**: Uses addition and subtraction

## Purpose

To compare performance and memory allocations of different swapping strategies across multiple .NET runtimes.

## Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

## How to Run

1. Clone the repository or copy the files to your project.
2. Restore dependencies and build the project:

```bash
dotnet restore
dotnet build -c Release
```

## Notes
The return values from swap methods are used to prevent dead code elimination by the JIT.
Each benchmark is isolated and initialized with the same input values before execution.

## Result

| Method                  | Job      | Runtime  | Mean     | Error     | StdDev    | Allocated |
|------------------------ |--------- |--------- |---------:|----------:|----------:|----------:|
| TupleSwapBenchmark      | .NET 6.0 | .NET 6.0 | 4.262 ns | 0.0540 ns | 0.0479 ns |         - |
| TempSwapBenchmark       | .NET 6.0 | .NET 6.0 | 4.174 ns | 0.0369 ns | 0.0345 ns |         - |
| XorSwapBenchmark        | .NET 6.0 | .NET 6.0 | 4.770 ns | 0.0329 ns | 0.0291 ns |         - |
| ArithmeticSwapBenchmark | .NET 6.0 | .NET 6.0 | 4.577 ns | 0.0600 ns | 0.0561 ns |         - |
| TupleSwapBenchmark      | .NET 7.0 | .NET 7.0 | 4.018 ns | 0.0472 ns | 0.0441 ns |         - |
| TempSwapBenchmark       | .NET 7.0 | .NET 7.0 | 4.141 ns | 0.0491 ns | 0.0459 ns |         - |
| XorSwapBenchmark        | .NET 7.0 | .NET 7.0 | 4.750 ns | 0.0580 ns | 0.0484 ns |         - |
| ArithmeticSwapBenchmark | .NET 7.0 | .NET 7.0 | 4.492 ns | 0.0553 ns | 0.0491 ns |         - |
| TupleSwapBenchmark      | .NET 8.0 | .NET 8.0 | 3.946 ns | 0.0667 ns | 0.0623 ns |         - |
| TempSwapBenchmark       | .NET 8.0 | .NET 8.0 | 4.037 ns | 0.0162 ns | 0.0144 ns |         - |
| XorSwapBenchmark        | .NET 8.0 | .NET 8.0 | 4.598 ns | 0.0189 ns | 0.0167 ns |         - |
| ArithmeticSwapBenchmark | .NET 8.0 | .NET 8.0 | 4.439 ns | 0.0378 ns | 0.0335 ns |         - |
| TupleSwapBenchmark      | .NET 9.0 | .NET 9.0 | 3.947 ns | 0.0419 ns | 0.0350 ns |         - |
| TempSwapBenchmark       | .NET 9.0 | .NET 9.0 | 4.010 ns | 0.0344 ns | 0.0287 ns |         - |
| XorSwapBenchmark        | .NET 9.0 | .NET 9.0 | 4.702 ns | 0.0489 ns | 0.0434 ns |         - |
| ArithmeticSwapBenchmark | .NET 9.0 | .NET 9.0 | 4.429 ns | 0.0068 ns | 0.0060 ns |         - |
