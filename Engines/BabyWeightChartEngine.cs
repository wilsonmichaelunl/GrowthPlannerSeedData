using CsvHelper;
using Shared.Contracts.EngineContracts;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engines
{
    public class BabyWeightChartEngine : IBabyWeightChartEngine
    {
        public async Task<List<WeightChart>> BuildWeightChartFromCSV()
        {
            var result = new List<WeightChart>();
            using var streamReader = File.OpenText("./Data/wtageinf.csv");
            using var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);
            result = csvReader.GetRecords<WeightChart>().ToList();

            foreach (var model in result)
            {
                model.P3 = Math.Round(model.P3 * 2.20462, 9);
                model.P5 = Math.Round(model.P5 * 2.20462, 9);
                model.P10 = Math.Round(model.P10 * 2.20462, 9);
                model.P25 = Math.Round(model.P25 * 2.20462, 9);
                model.P50 = Math.Round(model.P50 * 2.20462, 9);
                model.P75 = Math.Round(model.P75 * 2.20462, 9);
                model.P90 = Math.Round(model.P90 * 2.20462, 9);
                model.P95 = Math.Round(model.P95 * 2.20462, 9);
                model.P97 = Math.Round(model.P97 * 2.20462, 9);
            }

            return result;
        }
    }
}
