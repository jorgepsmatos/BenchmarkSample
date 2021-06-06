using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Benchmark
{
    [MemoryDiagnoser]
    public class ElementCountBenchmark
    {
        private readonly IEnumerable<int> _list = Enumerable.Range(0, 100);

        [Benchmark]
        public bool ExistsProperty()
        {
            return _list.ToList().Exists(i => true);
        }

        [Benchmark]
        public bool CountProperty()
        {
            return _list.ToList().Count != 0;
        }

        [Benchmark]
        public bool CountMethod()
        {
            return _list.Count() != 0;
        }
        
        [Benchmark]
        public bool Any()
        {
            return _list.Any();
        }
    }
}