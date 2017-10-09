using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int frezult = 0;
            int sresult = 0;
            byte n = byte.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                if(input == "UPGRADE")
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                }
                if (i % 2 != 0 && input != "UPGRADE")
                {

                    frezult += input.Length;
                }
                else if(i % 2 == 0 && input != "UPGRADE") sresult += input.Length;
                    if(frezult >= 50)
                    {
                        //Console.WriteLine(firstBoat);
                        break;
                    }
                    else if(sresult >= 50)
                {
                    //Console.WriteLine(secondBoat);
                    break;
                }
            }
            if (frezult > sresult) Console.WriteLine(firstBoat);
            else Console.WriteLine(secondBoat);
        }
    }
}
