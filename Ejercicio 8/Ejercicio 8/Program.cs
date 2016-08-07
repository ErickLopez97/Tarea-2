using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double v_radio, v_superficie, v_volumen, v_pi;
            v_radio = 0.0;
            v_pi = 3.141592654;

            Console.WriteLine("Ingrese el Radio de la Esfera");
            v_radio = double.Parse(Console.ReadLine());

            v_superficie = 4 * v_pi * (v_radio * v_radio);
            Console.WriteLine("La superficie es:   " + v_superficie);

            v_volumen = (4 * v_pi * (v_radio * v_radio * v_radio)) / 3;
            Console.WriteLine("El volumen es:      " + v_volumen);

            Console.ReadKey();
        }
    }
}
