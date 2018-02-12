using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O365Mobile.Models
{
    public class TrendingInsightValue
    {
        public string id { get; set; }
        public double weight { get; set; }
        public ResourceVisualization resourceVisualization { get; set; }
        public ResourceReference resourceReference { get; set; }
    }
}
