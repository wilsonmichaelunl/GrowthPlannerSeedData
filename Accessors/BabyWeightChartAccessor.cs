using Shared.Contracts.AccessorContracts;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Accessors
{
    public class BabyWeightChartAccessor : IBabyWeightChartAccessor
    {
        public async Task InsertBabyWeightChartData(List<WeightChart> models)
        {
            using (var db = new BabyWeightChartContext())
            {
                try
                {
                    db.WeightCharts.AddRange(models);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

    }
}
