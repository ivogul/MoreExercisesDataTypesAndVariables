using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            BigInteger id = 0;
            BigInteger ofset = (BigInteger)long.MaxValue + long.MaxValue; //?
            byte n = byte.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                BigInteger tempId = long.Parse(Console.ReadLine());
                BigInteger tempOfset = 0;
                switch(numeralType)
                {
                    case "sbyte":
                        if (tempId > sbyte.MaxValue || tempId < sbyte.MinValue) break;
                        tempOfset = (int)(sbyte.MaxValue - tempId);
                        if (tempOfset <= ofset)
                        {
                            ofset = tempOfset;
                            id = tempId;
                        }
                    break;
                    case "int":
                        if (tempId > int.MaxValue || tempId < int.MinValue) break;
                        tempOfset = (long)(int.MaxValue - tempId);
                        if (tempOfset <= ofset)
                        {
                            ofset = tempOfset;
                            id = tempId;
                        }
                        break;
                    case "long":
                        tempOfset = (BigInteger)long.MaxValue - tempId;
                        if (tempOfset <= ofset)
                        {
                            ofset = tempOfset;
                            id = tempId;
                        }
                        break;
                    default: break;
                }

            }
                Console.WriteLine(id);
        }
    }
}
