using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int v_num;
            string binario = "";
            int i;
            Console.WriteLine("Ingrese un valor decimal");
            v_num = Int32.Parse(Console.ReadLine());

            if (v_num !=1)
            {
                for (i=v_num;i!=0&&i!=1;i=i/2)
                {
                    binario = (i % 2) + binario;
                }
                    if(i==0)
                    {
                        Console.WriteLine("El valor binario es 0");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("EL VALOR BINARIO ES:   {0}", binario);
                        Console.ReadLine();
                    }
            }
            else 
            {
                Console.WriteLine("El valor binario es 1");
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
