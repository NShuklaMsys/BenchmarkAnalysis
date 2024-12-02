using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using FluentAssertions;


namespace BenchMarkLib

{
    public static class BaseBenchmark
    {
      private const string OutputFolder = @"D:\Poc";

          public static void Execute<T>()
           {
               var configOptions = ManualConfig.Create(DefaultConfig.Instance)
                   .WithArtifactsPath(OutputFolder)
                   .WithOptions(ConfigOptions.DisableOptimizationsValidator);

               configOptions.AddJob(Job.ShortRun.WithToolchain(InProcessEmitToolchain.Instance));

            //   var performanceTestType = ResolvePerformanceTestType(type);
               var result = BenchmarkRunner.Run<T>(configOptions);

               var expectedTime = new TimeSpan(0, 0, 0, 60);

               result.TotalTime.Should().BeLessThanOrEqualTo(expectedTime);
           }
       
    }
}
