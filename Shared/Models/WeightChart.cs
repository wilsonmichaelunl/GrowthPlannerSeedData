using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared.Models
{
    public class WeightChart
    {
        [Key]
        public int RecordId { get; set; }
        public double AgeMonths { get; set; }
        public double BoxCoxTransformation { get; set; }
        public double Median { get; set; }
        public double CoefficientOfVariation { get; set; }
        public int Sex { get; set; }
        public double P3 { get; set; }
        public double P5 { get; set; }
        public double P10 { get; set; }
        public double P25 { get; set; }
        public double P50 { get; set; }
        public double P75 { get; set; }
        public double P90 { get; set; }
        public double P95 { get; set; }
        public double P97 { get; set; }
    }
}
