using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int code = char.Parse(Console.ReadLine());
                sum += code;

            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
