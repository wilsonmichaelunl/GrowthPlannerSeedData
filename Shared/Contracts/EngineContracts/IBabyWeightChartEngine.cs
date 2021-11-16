﻿using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Contracts.EngineContracts
{
    public interface IBabyWeightChartEngine
    {
        Task<List<WeightChart>> BuildWeightChartFromCSV();
    }
}
