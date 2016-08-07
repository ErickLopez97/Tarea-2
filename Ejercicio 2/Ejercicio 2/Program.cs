using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, w, y;
            String num = "";           
            Console.WriteLine("Ingresa numero");
            n = Convert.ToInt32(Console.ReadLine());
            for (y = 1; y < n + 1; y++)
            {
                for (w = 1; w < y + 1; w++)
                {
                    num = num + (n);
                }
                num = num + "\n";
            }
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
