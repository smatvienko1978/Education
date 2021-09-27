using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using NUnit.Framework;

namespace StructBenchmarking
{
    public class Benchmark : IBenchmark
	{
        public double MeasureDurationInMs(ITask task, int repetitionCount)
        {
            GC.Collect();                   // Эти две строчки нужны, чтобы уменьшить вероятность того,
            GC.WaitForPendingFinalizers();  // что Garbadge Collector вызовется в середине измерений
                                            // и как-то повлияет на них.
			task.Run();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < repetitionCount; i++)
                task.Run();
            stopWatch.Stop();
            return stopWatch.Elapsed.TotalMilliseconds / repetitionCount;
        }
	}

    public class StringConstructorTest : ITask
    {
        public void Run()
        {
            var result = new string('a', 10000);
        }
    }
    public class StringBuilderTest : ITask
    {
        public void Run()
        {
            var result = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                result.Append("a");
            }
            result.ToString();
        }
    }

    [TestFixture]
    public class RealBenchmarkUsageSample
    {
        [Test]
        public void StringConstructorFasterThanStringBuilder()
        {
            var bench = new Benchmark();
            var stringTest = bench.MeasureDurationInMs(new StringConstructorTest(),10);
            var builderTest = bench.MeasureDurationInMs(new StringBuilderTest(), 10);

            Assert.Less(stringTest, builderTest);
        }
    }
}