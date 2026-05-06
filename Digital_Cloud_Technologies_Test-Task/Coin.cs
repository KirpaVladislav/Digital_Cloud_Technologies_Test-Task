using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Cloud_Technologies_Test_Task
{
    public class Coin
    {
        public string? id { get; set; }
        public string? symbol { get; set; }
        public string? name { get; set; }
        public string? image { get; set; }
        public double? price_change_percentage_24h { get; set; }
        public decimal? current_price { get; set; }
        public double? total_volume { get; set; }
    }
}
