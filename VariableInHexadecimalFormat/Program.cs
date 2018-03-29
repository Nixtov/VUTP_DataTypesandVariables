using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Convert.ToInt32(num, 16);
            //  num Convert.ToString((long)int.MaxValue + 1, 16);
            Console.WriteLine(num);

        }
    }
}
