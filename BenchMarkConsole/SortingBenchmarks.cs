using BenchmarkDotNet.Attributes;

public class SortingBenchmarks
{
    // Data set for benchmarking
    private int[] data;

    // Set up the benchmark data
    [GlobalSetup]
    public void Setup()
    {
        var random = new Random();
        data = Enumerable.Range(0, 1000).Select(_ => random.Next(0, 1000)).ToArray();
    }

    // Benchmark method for sorting using Array.Sort()
    [Benchmark]
    public void SortArraySort()
    {
        var copy = (int[])data.Clone();
        Array.Sort(copy);
    }

    // Benchmark method for sorting using LINQ OrderBy
    [Benchmark]
    public void SortLinqOrderBy()
    {
        var copy = data.ToArray();
        var sorted = copy.OrderBy(x => x).ToArray();
    }

}