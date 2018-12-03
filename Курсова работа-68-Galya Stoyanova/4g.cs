using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4g
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, a, z, b;
            Console.Write("Въведете x:");
            x = double.Parse(Console.ReadLine());
            Console.Write("Въведете y:");
            y = double.Parse(Console.ReadLine());
            Console.Write("Въведете z:");
            z = double.Parse(Console.ReadLine());
            Console.Write("Въведете a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Въведете b:");
            b = double.Parse(Console.ReadLine());
            double result = Math.Pow(y + 6 * a - 2 / 3 * (x + 6), 6) - z / z + 7 * b;
            Console.WriteLine(result);
        }
    }
}
