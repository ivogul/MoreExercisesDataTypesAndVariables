using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                message += (char)(input + key);
            }
            Console.WriteLine(message);
        }
    }
}
