using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int v_radio, v_perimetro, v_area;
            Console.WriteLine("Ingrese el Radio del Circulo");
            v_radio= int.Parse(Console.ReadLine());

            v_perimetro = 2 * (355 / 113) * v_radio;            
            Console.WriteLine("El perimetro es:   " + v_perimetro);
            v_area = (355 / 113) * v_radio*v_radio;
            Console.WriteLine("El area es:        " + v_area);
            Console.ReadKey();
        }
    }
}
