using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            double volume = 0.0;
            string winner = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double tempVolume = Math.PI * (radius * radius) * height;
                //Console.WriteLine(tempVolume);
                if (tempVolume > volume)
                {
                    volume = tempVolume;
                    winner = model;
                }
            }
            Console.WriteLine(winner);
        }
    }
}
