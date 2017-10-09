using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long value = 0;
            if (long.TryParse(number, out value))
            {
            if (value <= sbyte.MaxValue && value >= sbyte.MinValue) Console.WriteLine("Sunny");
            else if (value <= int.MaxValue && value >= int.MinValue) Console.WriteLine("Cloudy");
            else if (value <= long.MaxValue && value >= long.MinValue) Console.WriteLine("Windy");
            }
            else
            {
            double value2 = 0.0;
            double.TryParse(number, out value2);
            if (value <= double.MaxValue && value >= double.MinValue) Console.WriteLine("Rainy");

            }
        }
    }
}
