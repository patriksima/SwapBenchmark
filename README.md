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
