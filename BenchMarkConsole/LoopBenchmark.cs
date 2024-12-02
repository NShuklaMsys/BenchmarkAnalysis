using BenchmarkDotNet.Attributes;

public class LoopBenchmark
{
    private int[]? numbers;

    // Setup method to initialize the array
    [GlobalSetup]
    public void Setup()
    {
        numbers = new int[1000000]; // Array of size 1 million
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }
    }

    // Benchmark for 'for' loop
    [Benchmark]
    public long ForLoop()
    {
        long sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    // Benchmark for 'foreach' loop
    [Benchmark]
    public long ForeachLoop()
    {
        long sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}

