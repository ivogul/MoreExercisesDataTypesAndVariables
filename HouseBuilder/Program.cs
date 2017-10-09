using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            if (input1 > 127)
            {
                long total = (long)input1 * 10 + input2 * 4;
                Console.WriteLine(total);
            }
            else
            {
                long total = input1 * 4 + (long)input2 * 10;
                Console.WriteLine(total);
            }
        }
    }
}
