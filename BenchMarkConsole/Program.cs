// See https://aka.ms/new-console-template for more information

using BenchmarkConsole;
using BenchMarkLib;
using BenchMarkPerformanceAnalysis.Benchmarks;

BaseBenchmark.Execute<ConcatenationBenchmark>();
//BaseBenchmark.Execute<LoopBenchmark>();
//BaseBenchmark.Execute<SearchBenchmark>();
//BaseBenchmark.Execute<SortingBenchmarks>();
//BaseBenchmark.Execute<ProductBenchmarks>();

