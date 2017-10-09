using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            double multiplier = 0d;
            string metricUnit = "meters";
            switch (imperialUnit)
            {
                case "miles": multiplier = 1.6; metricUnit = "kilometers"; break;
                case "inches": multiplier = 2.54; metricUnit = "centimeters"; break;
                case "feet": multiplier = 30; metricUnit = "centimeters"; break;
                case "yards": multiplier = 0.91; metricUnit = "meters"; break;
                case "gallons": multiplier = 3.8; metricUnit = "liters"; break;
                default:
                    break;
            }
            double metricValue = value * multiplier;
            Console.WriteLine($"{value} {imperialUnit} = {metricValue:f2} {metricUnit}");

        }
    }
}
