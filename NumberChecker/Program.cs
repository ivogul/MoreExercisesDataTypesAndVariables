using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long integer = long.Parse(Console.ReadLine());
                Console.WriteLine("integer");
            }
            catch (Exception)
            {
                Console.WriteLine("floating-point");
                //throw;
            }
        }
    }
}
