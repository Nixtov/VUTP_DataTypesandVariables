using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lasrtName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long id = long.Parse(Console.ReadLine());
            long empNum = long.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\nLast name: {lasrtName}\nAge: {age}\nGender: {gender}\nPersonal ID: {id}\nUnique Employee number: {empNum}");
        }
    }
}
