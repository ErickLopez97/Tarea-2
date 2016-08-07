using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float primero; 
            float segundo; 
            string operacion;

            Console.WriteLine("Introduzca el primer numero");
            primero=float.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la operacion a realizar (+,-,*,/)");
            operacion = Console.ReadLine();
            Console.WriteLine("Introduzca el segundo numero");
            segundo=float.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: ");
            Console.WriteLine(calcular(primero, segundo, operacion));
            Console.ReadKey();
        }
        private static string calcular (float primero, float segundo, string operacion)
        {
            float temp;
            switch (operacion)
            {
                case "+":
                    temp= primero + segundo;
                    return temp.ToString ();
                case "-":
                    temp= primero - segundo;
                    return temp.ToString ();
                case "*":
                    temp= primero * segundo;
                    return temp.ToString();
                case "/":
                    temp= primero / segundo;
                    return temp.ToString();
            }
            return "-1";
        }
    }
}
