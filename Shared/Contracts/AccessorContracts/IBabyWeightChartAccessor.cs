using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Contracts.AccessorContracts
{
    public interface IBabyWeightChartAccessor
    {
        Task InsertBabyWeightChartData(List<WeightChart> models);
    }
}
