using Shared.Contracts.AccessorContracts;
using Shared.Contracts.EngineContracts;
using Shared.Contracts.ManagerContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Managers
{
    public class BabyWeightChartManager : IBabyWeightChartManager
    {
        private readonly IBabyWeightChartEngine _babyWeightChartEngine;
        private readonly IBabyWeightChartAccessor _babyWeightChartAccessor;

        public BabyWeightChartManager(IBabyWeightChartEngine babyWeightChartEngine, IBabyWeightChartAccessor babyWeightChartAccessor)
        {
            _babyWeightChartEngine = babyWeightChartEngine;
            _babyWeightChartAccessor = babyWeightChartAccessor;
        }

        public async Task InsertBabyWeightChartData()
        {
            var models = await _babyWeightChartEngine.BuildWeightChartFromCSV();
            await _babyWeightChartAccessor.InsertBabyWeightChartData(models);
        }
    }
}
