using Microsoft.Extensions.DependencyInjection;
using Shared.Contracts.AccessorContracts;
using Shared.Contracts.EngineContracts;
using Shared.Contracts.ManagerContracts;
using System;
using Accessors;
using Managers;
using Engines;

namespace GrowthPlannerSeed
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IBabyWeightChartManager, BabyWeightChartManager>()
                .AddTransient<IBabyWeightChartEngine, BabyWeightChartEngine>()
                .AddTransient<IBabyWeightChartAccessor, BabyWeightChartAccessor>()
                .BuildServiceProvider();

            var manager = serviceProvider.GetService<IBabyWeightChartManager>();
            manager.InsertBabyWeightChartData();
        }
    }
}
