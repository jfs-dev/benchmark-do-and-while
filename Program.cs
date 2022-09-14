using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run(typeof(BenchmarkDoAndWhile).Assembly);

public class BenchmarkDoAndWhile
{
    [Benchmark]
    public void UsingDo()
    {
        int n = 0;
        do
        {
            n++;
        } while (n < 200000);
    }

    [Benchmark]
    public void UsingWhile()
    {
        int n = 0;
        while (n < 200000)
        {
            n++;
        }
    }
}