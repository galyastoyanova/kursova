using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length Of A Rectangle:");
            var a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width Of A Rectangle:");
            var b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle Area is");
            var area = (a * b);

            Console.WriteLine(area);
            NewMethod();
            NewMethod1();
            Console.WriteLine(a * b);
        }

        private static void NewMethod1()
        {
            var b = decimal.Parse(Console.ReadLine());
        }

        private static void NewMethod()
        {
            var a = decimal.Parse(Console.ReadLine());
        }
    }
}
