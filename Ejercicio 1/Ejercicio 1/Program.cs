using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Letra = new string[5];
            int c = 4;
            string cad = "";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese una letra ");
                Letra[i] = Console.ReadLine();
            }
            while (c >= 0)
            {
                cad = cad + "  " + Letra[c];
                c--;
            }
            Console.WriteLine(cad);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
