using BenchmarkDotNet.Attributes;

namespace BenchmarkConsole
{
    [MemoryDiagnoser]
    public class SearchBenchmark
    {
        private List<int> _list;
        private int _target;

        [GlobalSetup]
        public void Setup()
        {
            // Initialize a large list of integers.
            _list = Enumerable.Range(1, 10_000).ToList();
            _target = 9_999; // Target is near the end of the list for worst-case performance.
        }

        [Benchmark]
        public bool ForLoopSearch()
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i] == _target)
                    return true;
            }
            return false;
        }

        [Benchmark]
        public bool ContainsSearch()
        {
            return _list.Contains(_target);
        }
    }
}
