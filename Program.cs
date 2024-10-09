using BenchmarkDotNet.Running;
using YieldExample;

class Program
{
    public static void Main()
    {
        _ = BenchmarkRunner.Run<YieldVsNonYieldBenchmark>();
    }
}
