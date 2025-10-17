using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPogodowa
{
    internal class Utils
    {
        internal static Weather ChangeWeather(Weather weather)
        {
            var objectToChange = new Weather();
            Console.WriteLine($"Weather measured by: {weather.MeasuredBy}");
            weather.MeasuredBy = "Jan Kowalski";
            Console.WriteLine($"Weather measured by:{weather.MeasuredBy}");
            return objectToChange;
        }
        

    }
}
