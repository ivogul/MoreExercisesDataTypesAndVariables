using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            sbyte count = 0;
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                if (input.Length == 1)
                {
                    char inputChar = char.Parse(input);
                    if (inputChar == '(')
                    {
                        count++;
                        if (count > 1)
                        {
                            Console.WriteLine("UNBALANCED");
                            return;
                        }
                    }
                    else if (inputChar == ')')
                    {
                        count--;
                        if (count < 0)
                        {
                            Console.WriteLine("UNBALANCED");
                            return;
                        }
                    }
                }

            }
            if (count == 0) Console.WriteLine("BALANCED");
            else Console.WriteLine("UNBALANCED");
        }
    }
}
