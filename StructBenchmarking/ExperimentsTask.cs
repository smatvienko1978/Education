using System.Collections.Generic;

namespace StructBenchmarking
{
    public class Experiments
    {
        public static ChartData BuildChartDataForArrayCreation(
            IBenchmark benchmark, int repetitionsCount)
        {


            var classesTimes = new List<ExperimentResult>();
            var structuresTimes = new List<ExperimentResult>();

            foreach (var item in Constants.FieldCounts)
            {
                classesTimes.Add(new ExperimentResult(item, benchmark.MeasureDurationInMs(new ClassArrayCreationTask(item), repetitionsCount)));
                structuresTimes.Add(new ExperimentResult(item, benchmark.MeasureDurationInMs(new StructArrayCreationTask(item), repetitionsCount)));
            }

            return new ChartData
            {
                Title = "Create array",
                ClassPoints = classesTimes,
                StructPoints = structuresTimes,
            };
        }

        public static ChartData BuildChartDataForMethodCall(
            IBenchmark benchmark, int repetitionsCount)
        {
            var classesTimes = new List<ExperimentResult>();
            var structuresTimes = new List<ExperimentResult>();

            //...
            

            foreach (var item in Constants.FieldCounts)
            {
                structuresTimes.Add(new ExperimentResult(item, benchmark.MeasureDurationInMs(new MethodCallWithStructArgumentTask(item), repetitionsCount)));
                classesTimes.Add(new ExperimentResult(item, benchmark.MeasureDurationInMs(new MethodCallWithClassArgumentTask(item), repetitionsCount)));
            }

                return new ChartData
            {
                Title = "Call method with argument",
                ClassPoints = classesTimes,
                StructPoints = structuresTimes,
            };
        }
    }
}