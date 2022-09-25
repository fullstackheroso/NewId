using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace MassTransit.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MemoryDiagnoser]
    [GcServer(true)]
    [GcForce]
    public class Benchmarker
    {
        [Benchmark(Baseline = true, Description = "Next")]
        public NewId GetNext() => NewId.Next();

        [Benchmark(Description = "Next(batch)", OperationsPerInvoke = 100)]
        public NewId[] GetNextBatch() => NewId.Next(100);

        [Benchmark(Description = "NextGuid")]
        public Guid GetNextGuid() => NewId.NextGuid();

        [Benchmark(Description = "NextSequentialGuid")]
        public Guid GetNextSequentialGuid() => NewId.NextSequentialGuid();
    }
}
