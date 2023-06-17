using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {

        public static void Main()
        {
            int a, b, wynik = 1;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            while (b > 0)
            {
                wynik *= a;
                b--;
            }

            Console.WriteLine(wynik);
            Console.ReadKey();




        }
    }
}
