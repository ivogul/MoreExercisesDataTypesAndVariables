using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int sum = 0;
            byte lines = byte.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (sum + liters <= capacity)
                sum += liters;
                else Console.WriteLine("Insufficient capacity!");
            }
            Console.WriteLine(sum);
        }
    }
}
