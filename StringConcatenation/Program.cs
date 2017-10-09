using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string isEven = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string newString = "";
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                if (isEven == "odd")
                {
                   if(i == 1) newString += input;
                    if (i % 2 != 0 && i > 2)
                    newString = newString + (delimiter + input);
                }
                else if (isEven == "even")
                {
                    if(i == 2) newString += input;
                    if (i % 2 == 0 && i > 3)
                        newString = newString + (delimiter + input);
                }

            }
            Console.WriteLine(newString);
        }
    }
}
