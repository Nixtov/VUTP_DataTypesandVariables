using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= limit; currentNumber++)
            {
                bool finalNum = true;
                for (int num2 = 2; num2 <= Math.Sqrt(currentNumber); num2++)
                {
                    if (currentNumber % num2 == 0)
                    {
                        finalNum = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {finalNum}");
            }

        }
    }
}
