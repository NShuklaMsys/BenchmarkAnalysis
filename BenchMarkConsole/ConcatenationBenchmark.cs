using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkConsole
{
    //Measures the Memory usage 
    [MemoryDiagnoser]
    public class ConcatenationBenchmark
    {
        private const int N = 1000;

        //Benchmark for PlusOperator
        [Benchmark]
        public string PlusOperator()
        {
            string result = string.Empty;
            for (int i = 0; i < N; i++)
            {
                result += i;
            }
            return result;
        }

        //Benchmark for StringBuilder
        [Benchmark]
        public string StringBuilderMethod()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                builder.Append(i);
            }
            return builder.ToString();
        }
    }
}
