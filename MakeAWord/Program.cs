using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
                char[] word = new char[n];
            for (int i = 0; i < n; i++)
            {
                word[i] = char.Parse(Console.ReadLine());

            }
            Console.Write("The word is: ");
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();
        }
    }
}
