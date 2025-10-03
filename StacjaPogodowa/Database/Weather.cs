using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Weather
    {
        public int Id { get; set; }
        public string MeasuredBy { get; set; } = string.Empty;
        public DateTime MeasuredByDate { get; set; }
    }
}
